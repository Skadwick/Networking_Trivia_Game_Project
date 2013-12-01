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
        public delegate void updateChatBoxDelegate(String textBoxString);
        public updateChatBoxDelegate updateTextBox;
        public delegate void startQuestionTimerDelegate();
        public startQuestionTimerDelegate startQTimer;

        public ClientForm()
        {
            InitializeComponent();
            clientSock = new ClientSocket();
            clientSock.setForm(this); //Sending a reference of the form to the ServerSocket
            updateTextBox = new updateChatBoxDelegate(updateChatWin);
            startQTimer = new startQuestionTimerDelegate(startTimer);
        }


        /*
         * Connect to server button
         */
        private void connBtn_Click(object sender, EventArgs e)
        {
            if (ipAddrTxt.Text == "" || portTxt.Text == "")
                MessageBox.Show("Please enter Server IP address and or Port Number. ");
            else if (usrNmTxt.Text == "")
                MessageBox.Show("Please enter a User Name. ");
            else
            {
                String clientName = usrNmTxt.Text;
                clientSock.setUserName(clientName);
                clientSock.Connect(ipAddrTxt.Text, Convert.ToInt32(portTxt.Text));
            }
        }


        /*
         * Submit answer button
         */
        private void sbmtBtn_Click(object sender, EventArgs e)
        {
            
            //Send the letter answer corresponding with the selected checkbox.
            String ans = "";
            if (selctA_RBtn.Checked == true)
                ans = "A";
            else if (selctB_RBtn.Checked == true)
                ans = "B";
            else if (selctC_RBtn.Checked == true)
                ans = "C";
            else if (selctD_RBtn.Checked == true)
                ans = "D";


            clientSock.send(ans);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timePrgBar.Increment(1);
        }


        /*
         * Disconnect from server button
         */
        private void disconnbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /*
         * Starts the form timer.
         */
        void startTimer()
        {
            //if time runs out null should be submitted
            this.timer1.Start();
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
