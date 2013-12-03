/*
 * Author(s): Joshua Shadwick, 
 * Date: November 2013
 * File: ServerForm.cs
 * 
 * Description:
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Game_Server.Networking;
using Game_Server.Game;

namespace Game_Server
{
    public partial class ServerForm : Form
    {

        private static ServerSocket serverSock;
        public delegate void updateChatBoxDelegate(String textBoxString);
        public updateChatBoxDelegate updateTextBox;
        public delegate void updatePlayerBoxDelegate();
        public updatePlayerBoxDelegate updatePlayerBox;
        private delegate void LabelWriteDelegate(string value); //Used in game thread.
        private int MAXQUESTIONS = 0; //using 3 for testing, should be 10 for final submission.

        public ServerForm()
        {
            InitializeComponent();
            serverSock = new ServerSocket();
            serverSock.setForm(this); //Sending a reference of the form to the ServerSocket
            updateTextBox = new updateChatBoxDelegate(updateChatWin);
            updatePlayerBox = new updatePlayerBoxDelegate(setPlayerBox);
        }


        /*
         * Start server button
         * 
         * Binds, listens, and the begins accepting connections to the socket.  The stop server,
         * start server and start game buttons are updated accordingly.
         */
        private void startSrvBtn_Click(object sender, EventArgs e)
        {
            stopSrvBtn.Enabled = true;
            startSrvBtn.Enabled = false;
            startGameBtn.Enabled = true;

            serverSock.Bind(25001);
            serverSock.Listen(100);
            serverSock.Accept();
            updateChatWin("Waiting for connections...");
            //Thread disconnects = new Thread(findDisconnects);
            //disconnects.Start(); 
        }


        /*
         * Stop server button
         * 
         * Update the form buttons accordingly and close the listener socket, as well
         * as any handler sockets that were created for clients.
         */
        private void stopSrvBtn_Click(object sender, EventArgs e)
        {
            startSrvBtn.Enabled = true;
            stopSrvBtn.Enabled = false;  
            startGameBtn.Enabled = false;
        }


        /*
         * Start game button.  
         * 
         * Creates a new thread for the main game loop to run on.
         */
        private void startGameBtn_Click(object sender, EventArgs e)
        {
            startGameBtn.Enabled = false;
            MAXQUESTIONS = Convert.ToInt32(maxQNumtxt.Text);
            Thread game = new Thread(sendRecvQuestions);
            game.Start();    
        }


        /*
         * Intended to be run on a thread separate from the form object.  
         * 
         * Loops through the necessary number of questions, sending each to the
         * clients and then checking their answer.  The thread running this method will
         * pause for 17s between each question. At the end of the game, the scores are
         * broadcast to all clients.
         * 
         */
        private void sendRecvQuestions()
        {
            int questionNum = 1;

            while (questionNum <= MAXQUESTIONS)
            {

                //Send question
                GameMaster.questions();
                String question = "Q" + questionNum + ": " + GameMaster.newQuestion + Environment.NewLine + GameMaster.updatedAnswers;
                serverSock.sendNextQuestion(question);
                updateChatWin(question);
                Thread.Sleep(17000);

                //wait 15-20 seconds for players to submit answers.
                questionNum++;

            }

            String scores = "Scores for this game: ";

            foreach (Player p in serverSock.players)
            {
                scores += Environment.NewLine + p.userName + " : " + p.score;
            }

            serverSock.broadCast(scores);
        }


        /*
         * 
         */
        private void findDisconnects()
        {

        }


        /*
         * Updates the main chat/status textbox for the server form.
         */
        public void updateChatWin(string str)
        {
            if (InvokeRequired) //Check if another thread is calling the method.
            {
                Invoke(new LabelWriteDelegate(updateChatWin), str);
            }
            else
            {
                this.srvConslTxt.AppendText(Environment.NewLine + ">" + str);
            }
        }


        /*
         * Can be called with the updatePlayerBox delegate.  Sets the textbox containing
         * user currently connected, and their scores.
         */
        private void setPlayerBox()
        {
            this.clientListTxt.Text = "";
            foreach (Player p in serverSock.players)
            {
                this.clientListTxt.AppendText(p.userName + " : " + p.score + Environment.NewLine);
            }
        }


        /*
         * Exit button
         */
        private void extBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void srvConslTxt_TextChanged(object sender, EventArgs e)
        {

        }

    

    }
}
