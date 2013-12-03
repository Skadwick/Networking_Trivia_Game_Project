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
using System.Threading;
using Game_Server.Game;


namespace Game_Server.Networking
{

    /*
     * The Player class is used to keep track of the current answer, score, and
     * user name associated with each socket.  
     * 
     * Because this class holds a reference to the client's socket, we can send and
     * receive data directly from that client without having to wait
     * for an Iasync result event to trigger the socket object.
     */
    class Player
    {
        public int score;
        public String userName;
        public Socket handlerSock;
        public String answer;
    }


    class ServerSocket
    {

        private Socket listener;

        private byte[] recvBuf = new byte[1024];

        public ServerForm serverGUI;

        public List<Player> players = new List<Player>();

        private Thread killDisconnects;
  

        /*
         * Create a socket to listen for connections.
         */
        public ServerSocket()
        {
            listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            killDisconnects = new Thread(handleDisconnects);
            killDisconnects.Start();
        }


        /*
         * Sets a reference to the calling form.  This reference is used to access a
         * delegate invoke() method so that we can update fields in the form class.
         */
        public void setForm(ServerForm sf)
        {
            serverGUI = sf;
        }


        /*
         * Bind the listener socket to any ip address associated with the computer running 
         * the server, and the port which is passed as a parameter from the calling class.
         */
        public void Bind(int port)
        {
            try
            {
                listener.Bind(new IPEndPoint(IPAddress.Any, port));
            }
            catch
            {
                serverGUI.Invoke(serverGUI.updateTextBox, "Error Binding socket!");
            }
        }


        /*
         * Listen for incoming connections trying to connect to the socket.
         * 
         * backlog == the max number of clients waiting to connect at any given time.
         */
        public void Listen(int backlog)
        {
            try
            {
                listener.Listen(backlog);
            }
            catch
            {
                serverGUI.Invoke(serverGUI.updateTextBox, "Error listening for connections!");
            }
        }


        /*
         * Begin accepting connections asynchronously. Once a client is accepted, the 
         * AcceptedCallback method is called. 
         */
        public void Accept()
        {
            try
            {
                listener.BeginAccept(AcceptedCallback, null);
            }
            catch
            {
                serverGUI.Invoke(serverGUI.updateTextBox, "Error accepting clients!");
            }
        }


        /*
         * Send data to a client.  Once the message is sent, the SendCallback method is called.
         */
        public void send(Socket client, String msg)
        {
            byte[] data = Encoding.UTF8.GetBytes(msg);
            try
            {
                client.BeginSend(data, 0, data.Length, 0, new AsyncCallback(SendCallback), client);
            }
            catch
            {
                serverGUI.Invoke(serverGUI.updateTextBox, "Failed to send message.");
            }
        }


        /*
         * Sends the message passed as an argument to all players currently
         * connected. 
         */
        public void broadCast(string msg)
        {
            //handleDisconnects();
            foreach (Player p in players)
            {
                //Check if the player is still connected
                if (p.handlerSock.Connected)
                {
                    send(p.handlerSock, msg);
                }
                else
                {
                    continue;
                }    
            }
        }


        /*
         * Broadcasts the question to clients and begins trying to receive
         * their responses to the question.  Once a response is received, the 
         * ReceivedAnswer method is called.
         */
        public void sendNextQuestion(String question)
        {
            //handleDisconnects();
            foreach (Player p in players)
            {
                if (p.handlerSock.Connected)
                {
                    //recvBuf = new byte[1024];
                    send(p.handlerSock, question);
                    try
                    {
                        p.handlerSock.BeginReceive(recvBuf, 0, recvBuf.Length, SocketFlags.None, ReceivedAnswer, p.handlerSock);
                    }
                    catch
                    {
                        serverGUI.Invoke(serverGUI.updateTextBox, "Error while trying to receive an answer.");
                    }
                }
                else
                {
                    continue;
                }
  
            }
        }


        /*
         * Deleting disconnected clients from List<Player> players, while preventing 
         * the error: InvalidOperationException. Collection was modified; enumeration operation may not execute.
         */
        private void handleDisconnects()
        {
            while (true)
            {
                List<Player> notConnected = new List<Player>();

                //Find players that are no longer connected.  Add them to the notConnected list so
                //they can be handled afterwards. 
                foreach (Player p in players)
                {
                    //Check if the player is still connected
                    bool chk1 = p.handlerSock.Poll(1000, SelectMode.SelectRead);
                    bool chk2 = (p.handlerSock.Available == 0);
                    if (chk1 & chk2)
                    {
                        notConnected.Add(p);
                    }
                }

                foreach (Player nc in notConnected)
                {
                    players.Remove(nc);
                    broadCast(nc.userName + " has disconnected.");
                    serverGUI.Invoke(serverGUI.updateTextBox, nc.userName + " has disconnected.");
                }
                try
                {
                    serverGUI.Invoke(serverGUI.updatePlayerBox);
                }
                catch { }
                Thread.Sleep(1000);
            }
        }


        /*
         * Receives an answer to the current trivia question from the client.  This method updates the Player
         * object accordingly, and sends that player some feedback.
         */
        private void ReceivedAnswer(IAsyncResult result)
        {
            Socket clientSocket = result.AsyncState as Socket;
            try
            {
                int bufferSize = clientSocket.EndReceive(result);
                byte[] packet = new byte[bufferSize];
                Array.Copy(recvBuf, packet, packet.Length);
                //recvBuf = new byte[1024]; //clear the buffer for next time

                //handleDisconnects();

                foreach (Player p in players)
                {
                    if (p.handlerSock == clientSocket && p.handlerSock.Connected) //Find the client that sent the answer
                    {
                        p.answer = Encoding.UTF8.GetString(packet);
                        serverGUI.Invoke(serverGUI.updateTextBox, p.userName + " selected answer: " + p.answer);

                        //Check their response, and update their score.  
                        if (p.answer == GameMaster.updatedCorrectAnswer)
                        {
                            p.score++;
                            send(p.handlerSock, "You answered correctly!");
                        }
                        else
                        {
                            send(p.handlerSock, "You answered incorrectly :(" + Environment.NewLine +
                                                "Correct answer: " + GameMaster.updatedCorrectAnswer);
                        }
                        serverGUI.Invoke(serverGUI.updatePlayerBox);
                        break;
                    }
                }
            }
            catch
            {
                if (clientSocket.Connected)
                {
                    serverGUI.Invoke(serverGUI.updateTextBox, "Error receiving data from client.");
                }
            }
        }


        /*
         * Setup of the client handler socket.  
         * 
         * This method is triggered when a client is accepted by the socket.  A player object is
         * created for the connection, and the server sends some feedback.  Once this client
         * is completely setup, the server begins accepting again.
         */
        private void AcceptedCallback(IAsyncResult result)
        {
            Socket clientSocket = listener.EndAccept(result);
            Player newPlayer = new Player();
            newPlayer.handlerSock = clientSocket;
            players.Add(newPlayer);

            //send(clientSocket, "Welcome to the server!");

            if (clientSocket.Connected)
            {
                clientSocket.BeginReceive(recvBuf, 0, recvBuf.Length, SocketFlags.None, ReceivedCallback, clientSocket);
            }

            Accept(); //Begin accepting again.
        }


        /*
         * Handle data received from a client.  
         * 
         * This method is triggered by an IAsync event sent from the BeginReceive() method.  
         * This should be triggered only by the first response from the client. The data
         * sent from the client should contain their selected username.
         */
        private void ReceivedCallback(IAsyncResult result)
        {
            Socket clientSocket = result.AsyncState as Socket; //cast AsyncState to a Socket object
            try
            {
                int bufferSize = clientSocket.EndReceive(result);
                byte[] packet = new byte[bufferSize];
                Array.Copy(recvBuf, packet, packet.Length);
                recvBuf = new byte[1024]; //clear the buffer
                //handleDisconnects();

                //Set the client's username
                foreach (Player p in players)
                {
                    if ( p.handlerSock == clientSocket && p.userName == null && p.handlerSock.Connected )
                    {
                        p.userName = Encoding.UTF8.GetString(packet);
                        p.score = 0;
                        break;
                    }
                }
                serverGUI.Invoke(serverGUI.updateTextBox, Encoding.UTF8.GetString(packet) + " has connected.");
                broadCast(Encoding.UTF8.GetString(packet) + " has connected.");
                serverGUI.Invoke(serverGUI.updatePlayerBox);
            }
            catch
            {
                if (clientSocket.Connected)
                {
                    serverGUI.Invoke(serverGUI.updateTextBox, "Error receiving data from client.");
                }
            }

        }


        /*
         * Handle send data to a client.  
         * 
         * This method is triggered by an IAsync event sent from the BeginSend() method.  
         * When this method is called, sending data to the client that triggered 
         * the event is temporarily blocked, but resumes once the server is done
         * working with the data.
         */
        private void SendCallback(IAsyncResult result)
        {
            try
            {
                Socket client = result.AsyncState as Socket;
                client.EndSend(result);           
            }
            catch (Exception e) 
            {
                serverGUI.Invoke(serverGUI.updateTextBox, e.ToString());
            }
        }

    }
}
