using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Game_Client.Networking;
//using Game_Client.Game;

namespace Game_Client
{
    public partial class ClientForm : Form
    {


        private static ClientSocket clientSock;
        public delegate void updateChatBoxDelegate(String textBoxString); // delegate type 
        public updateChatBoxDelegate updateTextBox; // delegate object


        public ClientForm()
        {
            InitializeComponent();
            clientSock = new ClientSocket();
            clientSock.setForm(this); //Sending a reference of the form to the ServerSocket
            updateTextBox = new updateChatBoxDelegate(updateChatWin);
        }


        /*
         * Connect to server button
         */
        private void connBtn_Click(object sender, EventArgs e)
        {
            clientSock.Connect(ipAddrTxt.Text, Convert.ToInt32(portTxt.Text));
        }


        /*
         * Submit answer button
         */
        private void sbmtBtn_Click(object sender, EventArgs e)
        {

        }


        /*
         * Disconnect from server button
         */
        private void disconnbtn_Click(object sender, EventArgs e)
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
         * Updates the main chat/status textbox for the client form.
         */
        void updateChatWin(String msg)
        {
            this.clnConslTxt.Text += "> " + msg + Environment.NewLine;
        }

    }
}
