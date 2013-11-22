namespace Game_Client
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ipAddrTxt = new System.Windows.Forms.TextBox();
            this.portTxt = new System.Windows.Forms.TextBox();
            this.usrNmTxt = new System.Windows.Forms.TextBox();
            this.connBtn = new System.Windows.Forms.Button();
            this.disconnbtn = new System.Windows.Forms.Button();
            this.clnConslTxt = new System.Windows.Forms.TextBox();
            this.timePrgBar = new System.Windows.Forms.ProgressBar();
            this.selctA_RBtn = new System.Windows.Forms.RadioButton();
            this.selctB_RBtn = new System.Windows.Forms.RadioButton();
            this.selctC_RBtn = new System.Windows.Forms.RadioButton();
            this.selctD_RBtn = new System.Windows.Forms.RadioButton();
            this.sbmtBtn = new System.Windows.Forms.Button();
            this.extBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ipAddrTxt
            // 
            this.ipAddrTxt.Location = new System.Drawing.Point(12, 12);
            this.ipAddrTxt.Name = "ipAddrTxt";
            this.ipAddrTxt.Size = new System.Drawing.Size(68, 20);
            this.ipAddrTxt.TabIndex = 0;
            this.ipAddrTxt.Text = "127.0.0.1";
            this.ipAddrTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // portTxt
            // 
            this.portTxt.Location = new System.Drawing.Point(86, 12);
            this.portTxt.MaxLength = 6;
            this.portTxt.Name = "portTxt";
            this.portTxt.Size = new System.Drawing.Size(42, 20);
            this.portTxt.TabIndex = 1;
            this.portTxt.Text = "25001";
            this.portTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usrNmTxt
            // 
            this.usrNmTxt.Location = new System.Drawing.Point(12, 38);
            this.usrNmTxt.MaxLength = 40;
            this.usrNmTxt.Name = "usrNmTxt";
            this.usrNmTxt.Size = new System.Drawing.Size(116, 20);
            this.usrNmTxt.TabIndex = 2;
            this.usrNmTxt.Text = "Username";
            // 
            // connBtn
            // 
            this.connBtn.Location = new System.Drawing.Point(12, 64);
            this.connBtn.Name = "connBtn";
            this.connBtn.Size = new System.Drawing.Size(116, 23);
            this.connBtn.TabIndex = 3;
            this.connBtn.Text = "Connect";
            this.connBtn.UseVisualStyleBackColor = true;
            this.connBtn.Click += new System.EventHandler(this.connBtn_Click);
            // 
            // disconnbtn
            // 
            this.disconnbtn.Location = new System.Drawing.Point(12, 93);
            this.disconnbtn.Name = "disconnbtn";
            this.disconnbtn.Size = new System.Drawing.Size(116, 23);
            this.disconnbtn.TabIndex = 4;
            this.disconnbtn.Text = "Disconnect";
            this.disconnbtn.UseVisualStyleBackColor = true;
            this.disconnbtn.Click += new System.EventHandler(this.disconnbtn_Click);
            // 
            // clnConslTxt
            // 
            this.clnConslTxt.Location = new System.Drawing.Point(134, 12);
            this.clnConslTxt.Multiline = true;
            this.clnConslTxt.Name = "clnConslTxt";
            this.clnConslTxt.ReadOnly = true;
            this.clnConslTxt.Size = new System.Drawing.Size(375, 220);
            this.clnConslTxt.TabIndex = 5;
            // 
            // timePrgBar
            // 
            this.timePrgBar.Location = new System.Drawing.Point(134, 276);
            this.timePrgBar.Name = "timePrgBar";
            this.timePrgBar.Size = new System.Drawing.Size(375, 23);
            this.timePrgBar.TabIndex = 6;
            // 
            // selctA_RBtn
            // 
            this.selctA_RBtn.AutoSize = true;
            this.selctA_RBtn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.selctA_RBtn.Location = new System.Drawing.Point(134, 241);
            this.selctA_RBtn.Name = "selctA_RBtn";
            this.selctA_RBtn.Size = new System.Drawing.Size(32, 17);
            this.selctA_RBtn.TabIndex = 7;
            this.selctA_RBtn.TabStop = true;
            this.selctA_RBtn.Text = "A";
            this.selctA_RBtn.UseVisualStyleBackColor = true;
            // 
            // selctB_RBtn
            // 
            this.selctB_RBtn.AutoSize = true;
            this.selctB_RBtn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.selctB_RBtn.Location = new System.Drawing.Point(215, 241);
            this.selctB_RBtn.Name = "selctB_RBtn";
            this.selctB_RBtn.Size = new System.Drawing.Size(32, 17);
            this.selctB_RBtn.TabIndex = 8;
            this.selctB_RBtn.TabStop = true;
            this.selctB_RBtn.Text = "B";
            this.selctB_RBtn.UseVisualStyleBackColor = true;
            // 
            // selctC_RBtn
            // 
            this.selctC_RBtn.AutoSize = true;
            this.selctC_RBtn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.selctC_RBtn.Location = new System.Drawing.Point(296, 241);
            this.selctC_RBtn.Name = "selctC_RBtn";
            this.selctC_RBtn.Size = new System.Drawing.Size(32, 17);
            this.selctC_RBtn.TabIndex = 9;
            this.selctC_RBtn.TabStop = true;
            this.selctC_RBtn.Text = "C";
            this.selctC_RBtn.UseVisualStyleBackColor = true;
            // 
            // selctD_RBtn
            // 
            this.selctD_RBtn.AutoSize = true;
            this.selctD_RBtn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.selctD_RBtn.Location = new System.Drawing.Point(377, 241);
            this.selctD_RBtn.Name = "selctD_RBtn";
            this.selctD_RBtn.Size = new System.Drawing.Size(33, 17);
            this.selctD_RBtn.TabIndex = 10;
            this.selctD_RBtn.TabStop = true;
            this.selctD_RBtn.Text = "D";
            this.selctD_RBtn.UseVisualStyleBackColor = true;
            // 
            // sbmtBtn
            // 
            this.sbmtBtn.Location = new System.Drawing.Point(430, 238);
            this.sbmtBtn.Name = "sbmtBtn";
            this.sbmtBtn.Size = new System.Drawing.Size(79, 23);
            this.sbmtBtn.TabIndex = 11;
            this.sbmtBtn.Text = "Submit";
            this.sbmtBtn.UseVisualStyleBackColor = true;
            this.sbmtBtn.Click += new System.EventHandler(this.sbmtBtn_Click);
            // 
            // extBtn
            // 
            this.extBtn.Location = new System.Drawing.Point(12, 209);
            this.extBtn.Name = "extBtn";
            this.extBtn.Size = new System.Drawing.Size(116, 23);
            this.extBtn.TabIndex = 12;
            this.extBtn.Text = "Exit";
            this.extBtn.UseVisualStyleBackColor = true;
            this.extBtn.Click += new System.EventHandler(this.extBtn_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 311);
            this.Controls.Add(this.extBtn);
            this.Controls.Add(this.sbmtBtn);
            this.Controls.Add(this.selctD_RBtn);
            this.Controls.Add(this.selctC_RBtn);
            this.Controls.Add(this.selctB_RBtn);
            this.Controls.Add(this.selctA_RBtn);
            this.Controls.Add(this.timePrgBar);
            this.Controls.Add(this.clnConslTxt);
            this.Controls.Add(this.disconnbtn);
            this.Controls.Add(this.connBtn);
            this.Controls.Add(this.usrNmTxt);
            this.Controls.Add(this.portTxt);
            this.Controls.Add(this.ipAddrTxt);
            this.Name = "ClientForm";
            this.Text = "Networking Game Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipAddrTxt;
        private System.Windows.Forms.TextBox portTxt;
        private System.Windows.Forms.TextBox usrNmTxt;
        private System.Windows.Forms.Button connBtn;
        private System.Windows.Forms.Button disconnbtn;
        private System.Windows.Forms.TextBox clnConslTxt;
        private System.Windows.Forms.ProgressBar timePrgBar;
        private System.Windows.Forms.RadioButton selctA_RBtn;
        private System.Windows.Forms.RadioButton selctB_RBtn;
        private System.Windows.Forms.RadioButton selctC_RBtn;
        private System.Windows.Forms.RadioButton selctD_RBtn;
        private System.Windows.Forms.Button sbmtBtn;
        private System.Windows.Forms.Button extBtn;
    }
}

