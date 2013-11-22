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
using Game_Server.Networking;
//using Game_Server.Game;

namespace Game_Server
{
    public partial class ServerForm : Form
    {

        private static ServerSocket serverSock;
        public delegate void updateChatBoxDelegate(String textBoxString); // delegate type 
        public updateChatBoxDelegate updateTextBox; // delegate object

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

        }



        /*
         * Send line button
         */
        private void sndBtn_Click(object sender, EventArgs e)
        {

        }



        /*
         * Exit button
         */
        private void extBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        /*
         * Updates the main chat/status textbox for the server form.
         */
        void updateChatWin(string str)
        {
            this.srvConslTxt.Text += ">" + str + Environment.NewLine;
        } 

    }
}
