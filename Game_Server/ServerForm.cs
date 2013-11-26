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
        public delegate void updateChatBoxDelegate(String textBoxString); // delegate type 
        public updateChatBoxDelegate updateTextBox; // delegate object
        private const int MAXQUESTIONS = 1;

        public ServerForm()
        {
            InitializeComponent();
            serverSock = new ServerSocket();
            serverSock.setForm(this); //Sending a reference of the form to the ServerSocket
            updateTextBox = new updateChatBoxDelegate(updateChatWin);
        }


        /*
         * Start server button
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
        }


        /*
         * Stop server button
         */
        private void stopSrvBtn_Click(object sender, EventArgs e)
        {
            startSrvBtn.Enabled = true;
            stopSrvBtn.Enabled = false;  
        }


        /*
         * Start game button
         */
        private void startGameBtn_Click(object sender, EventArgs e)
        {
            int questionNum = 1;
            while (questionNum <= MAXQUESTIONS)
            {
                GameMaster.questions();
                String question = GameMaster.newQuestion + Environment.NewLine + GameMaster.updatedAnswers;
                serverSock.broadCast(question);
                updateChatWin(question);
                
                //wait 15-20 seconds for players to submit answers.

                foreach(Player p in serverSock.players) {
                    if (p.answer == GameMaster.updatedCorrectAnswer)
                    {
                        p.score++;
                        serverSock.send(p.handlerSock, "You answered correctly!");
                    }
                }

                questionNum++;
            }
        }


        /*
         * Send line button
         */
        private void sndBtn_Click(object sender, EventArgs e)
        {
            //send broadcast to clients
        }


        /*
         * Updates the main chat/status textbox for the server form.
         */
        void updateChatWin(string str)
        {
            this.srvConslTxt.Text += ">" + str + Environment.NewLine;
        }

        private void clientListTxt_TextChanged(object sender, EventArgs e)
        {
            //display client list (hashTable from server)
        }


        /*
         * Exit button
         */
        private void extBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
