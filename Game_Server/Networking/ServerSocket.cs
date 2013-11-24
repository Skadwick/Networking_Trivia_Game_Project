/*
 * Author(s): Joshua Shadwick, 
 * Date: November 2013
 * File: ServerSocket.cs
 * 
 * Description:
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Game_Server.Networking
{
    class ServerSocket
    {

        private Socket listener;

        private byte[] recvBuf = new byte[1024];

        public ServerForm serverGUI;


        /*
         * Create a socket to listen for connections.
         * Address format: iPv4
         * Communication type: stream
         * protocol: TCP
         */
        public ServerSocket()
        {
            listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }



        /*
         * Bind the listener socket to any ip address associated with the computer running 
         * the server, and the port which is passed as a parameter from the calling class.
         * 
         * IPAddress.Any will listen on any IP Addresses assigned to the PC. For example, if the 
         * server is connected to a network via wireless and wired, there would be two IP Addresses 
         * assigned. This means that the server will listen for requests on both IP Addresses.
         */
        public void Bind(int port)
        {
            try
            {
                listener.Bind(new IPEndPoint(IPAddress.Any, port));
            }
            catch (Exception e)
            {
                serverGUI.Invoke(serverGUI.updateTextBox, "Error Binding socket!");
            }
        }



        /*
         * Listen for incoming connections trying to connect to the socket.
         * 
         * Backlog is passed as an argument from the calling class.  This value 
         * represents the max number of connections waiting to be served before the
         * server starts denying connections.  Around 200-300 connections is a good
         * value for most computers.
         */
        public void Listen(int backlog)
        {
            try
            {
                listener.Listen(backlog);
            }
            catch (Exception e)
            {
                serverGUI.Invoke(serverGUI.updateTextBox, "Error listening for connections!");
            }
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
        public void setForm(ServerForm sf)
        {
            serverGUI = sf;
        }



        /*
         * Begin listening for connections asynchronously.  
         * 
         * When a client is accepted, an IAsyncResult event is executed.  This IAsyncResult 
         * object contains an instance the socket object that connected and triggered 
         * the event.  This object is then sent to the AcceptedCallback method, where 
         * any work that needs to be done on the client socket can be executed.
         */
        public void Accept()
        {
            try
            {
                listener.BeginAccept(AcceptedCallback, null);
            }
            catch (Exception e)
            {
                serverGUI.Invoke(serverGUI.updateTextBox, "Error accepting a client!");
            }
        }



        /*
         * Send data to a client.
         * 
         * Converts the string data from the form class to a byte array and
         * begins trying to send it.
         */
        private void send(Socket client, String msg)
        {

            byte[] data = Encoding.UTF8.GetBytes(msg);
            try
            {
                client.BeginSend(data, 0, data.Length, 0,
                            new AsyncCallback(SendCallback), client);
            }
            catch
            {
                serverGUI.Invoke(serverGUI.updateTextBox, "Failed to send message.");
            }
        }



        /*
         * Setup of the client handler socket.  
         * 
         * This method is triggered by an IAsync event in the BeginAccept() method.  
         * The IAsyncResult object contains a reference tothe client that connected's socket.  
         * Acceptance of connections is temporarily blocked while work is being 
         * done on the current connection, but clients attempting to connect
         * during this time will not be lost.  Connections will still be in the backlog list
         * which was initiated in the Listen() method.  Once the server is done setting up the
         * current client, it begins accepting again, and any clients that attempted to connect while
         * accept was blocked will now be able to connect.
         */
        private void AcceptedCallback(IAsyncResult result)
        {
            serverGUI.Invoke(serverGUI.updateTextBox, "A client has connected");
            Socket clientSocket = listener.EndAccept(result);
            send(clientSocket, "Welcome to the server!");
            recvBuf = new byte[1024]; //clear the buffer
            if (clientSocket.Connected)
            {
                clientSocket.BeginReceive(recvBuf, 0, recvBuf.Length, SocketFlags.None, ReceivedCallback, clientSocket);
            }
            else
            {
                serverGUI.Invoke(serverGUI.updateTextBox, "A client has disconnected");
            }
            Accept();
        }



        /*
         * Handle data received from a client.  
         * 
         * This method is triggered by an IAsync event sent from the BeginReceive() method.  
         * When this method is called, receiving data from the client that triggered 
         * the event is temporarily blocked, but resumes once the server is done
         * working with the data.  
         */
        private void ReceivedCallback(IAsyncResult result)
        {
            Socket clientSocket = result.AsyncState as Socket; //cast AsyncState to a Socket object
            try
            {
                int bufferSize = clientSocket.EndReceive(result);
                byte[] packet = new byte[bufferSize];
                Array.Copy(recvBuf, packet, packet.Length);

                //Code to Handle the packet
                serverGUI.Invoke(serverGUI.updateTextBox, Encoding.UTF8.GetString(packet));
            }
            catch (Exception e)
            {
                if (clientSocket.Connected)
                {
                    serverGUI.Invoke(serverGUI.updateTextBox, "Error receiving data from client.");
                }
                else
                {
                    serverGUI.Invoke(serverGUI.updateTextBox, "A client has disconnected.");
                }
                return;
            }

            recvBuf = new byte[1024]; //clear the buffer
            if (clientSocket.Connected)
            {
                clientSocket.BeginReceive(recvBuf, 0, recvBuf.Length, SocketFlags.None, ReceivedCallback, clientSocket);
            }

        }



        /*
         * 
         */
        private void SendCallback(IAsyncResult result)
        {

            Socket client = result.AsyncState as Socket;

            // Complete sending the data to the remote device.
            int bytesSent = client.EndSend(result);
            //serverGUI.Invoke(serverGUI.updateTextBox, "Sent message to client");
        }




    }
}
