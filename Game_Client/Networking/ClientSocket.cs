using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace Game_Client.Networking
{
    class ClientSocket
    {

        private Socket socket;
        private byte[] buffer;
        ClientForm clientGUI;
        string username;
        public Boolean isConnected;


        /*
         * Create the socket to connect with the server
         * 
         * Address format: iPv4
         * Communication type: stream
         * protocol: TCP
         */
        public ClientSocket()
        {
            isConnected = false;
        }


        /*
         * Set's the username for this client so that it can be sent to the server.
         */
        public void setUserName(string nm)
        {
            username = nm;
        }



        /*
         * Sets a reference to the calling form.  This reference is used to access a
         * delegate invoke() method so that we can update fields in the form class.
         * 
         * For example, the following line of code calls a delegate in the form class.
         * serverGUI.Invoke(serverGUI.updateTextBox, "A client has connected");
         * In this case, updateTextBox is a delegate which updates the main text window on
         * the server form.  The string following the delegate call is the parameter
         * to be passed to the method that the delegate is handleing. 
         */
        public void setForm(ClientForm frm)
        {
            clientGUI = frm;
        }


        /*
         * Attempts to connect to the server.
         * 
         * When connected, the ConnectCallback method if called, and an IAsync event is called.
         * This IAsyncResult object contains an instance the socket object that connected and triggered 
         * the event.  This object is then sent to the AcceptedCallback method, where 
         * any work that needs to be done on the client socket can be executed.
         */
        public void Connect(string ipAddress, int port)
        {
            clientGUI.Invoke(clientGUI.updateTextBox, "Attempting to connect...");
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.BeginConnect(new IPEndPoint(IPAddress.Parse(ipAddress), port), ConnectCallback, null);
            }
            catch
            {
                clientGUI.Invoke(clientGUI.updateTextBox, "Error connecting to server.");
            }
        }


        /*
         * Send data to the server.
         * 
         * Converts the string data from the form class to a byte array and
         * tries to send it.
         */
        public void send(string msg)
        {
            try
            {
                socket.Send(Encoding.UTF8.GetBytes(msg), SocketFlags.None);
            }
            catch
            {
                clientGUI.Invoke(clientGUI.updateTextBox, "Failed to send message.");
            }
        }


        /*
         * Finish the connection to the server.
         * 
         * ConnectCallback is called after the client connects to a server. Once connected,
         * it stops trying to connect and begins trying to receive data.  Once data is
         * received, an IAsync event is created and sent to the ReceivedCallback method.
         */
        private void ConnectCallback(IAsyncResult result)
        {
            
            if (socket.Connected)
            {
                clientGUI.Invoke(clientGUI.updateTextBox, "Connected to server.");
                isConnected = true;
                socket.EndConnect(result);
                send(username);
                buffer = new byte[1024];
                socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceivedCallback, null);
            }
            else
            {
                clientGUI.Invoke(clientGUI.updateTextBox, "Failed to connect.");
                return;
            }
        }


        /*
         * Handle data received from the server.  
         * 
         * This method is triggered by an IAsync event sent from the BeginReceive() method.  
         * When this method is called, receiving data from the client that triggered 
         * the event is temporarily blocked, but resumes once the server is done
         * working with the data.  
         */
        private void ReceivedCallback(IAsyncResult result)
        {
            int bufLength = socket.EndReceive(result);
            byte[] packet = new byte[bufLength];
            Array.Copy(buffer, packet, packet.Length);
            String msg = Encoding.UTF8.GetString(packet);          

            //Check if the message is a question.  All questions begin with
            // the same format: Q(digit)
            if (msg[0] == 'Q' && Char.IsNumber(msg[1]))
            {
                clientGUI.Invoke(clientGUI.startQTimer);
                clientGUI.Invoke(clientGUI.submitButton, true); //Enable the submit button.
                clientGUI.Invoke(clientGUI.updateTextBox, msg);
            }
            //If not a question, handle the message like normal.
            else
            {
                clientGUI.Invoke(clientGUI.updateTextBox, "(Server): " + msg);
            }

            buffer = new byte[1024];
            socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceivedCallback, null);
        }


        /*
         * Close sending and receiving from the server socket.
         */
        public void disconnect()
        {
            try
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.BeginDisconnect(true, new AsyncCallback(DisconnectCallback), socket);
            }
            catch
            {
                clientGUI.Invoke(clientGUI.updateTextBox, "Error trying to disconnect!");
            }
        }

        private void DisconnectCallback(IAsyncResult ar)
        {
            // Complete the disconnect request.
            Socket client = (Socket)ar.AsyncState;
            client.EndDisconnect(ar);

            // Signal that the disconnect is complete.
            clientGUI.Invoke(clientGUI.updateTextBox, "Disconnected from the server.");
        }

    }
}
