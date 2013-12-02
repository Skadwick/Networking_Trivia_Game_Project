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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ipAddrTxt
            // 
            this.ipAddrTxt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ipAddrTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipAddrTxt.ForeColor = System.Drawing.Color.BurlyWood;
            this.ipAddrTxt.Location = new System.Drawing.Point(620, 48);
            this.ipAddrTxt.Name = "ipAddrTxt";
            this.ipAddrTxt.Size = new System.Drawing.Size(64, 20);
            this.ipAddrTxt.TabIndex = 0;
            this.ipAddrTxt.Text = "127.0.0.1";
            this.ipAddrTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // portTxt
            // 
            this.portTxt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.portTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portTxt.ForeColor = System.Drawing.Color.BurlyWood;
            this.portTxt.Location = new System.Drawing.Point(694, 48);
            this.portTxt.MaxLength = 6;
            this.portTxt.Name = "portTxt";
            this.portTxt.Size = new System.Drawing.Size(42, 20);
            this.portTxt.TabIndex = 1;
            this.portTxt.Text = "25001";
            this.portTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usrNmTxt
            // 
            this.usrNmTxt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usrNmTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrNmTxt.ForeColor = System.Drawing.Color.BurlyWood;
            this.usrNmTxt.Location = new System.Drawing.Point(620, 12);
            this.usrNmTxt.MaxLength = 40;
            this.usrNmTxt.Name = "usrNmTxt";
            this.usrNmTxt.Size = new System.Drawing.Size(116, 20);
            this.usrNmTxt.TabIndex = 2;
            this.usrNmTxt.Text = "Username";
            // 
            // connBtn
            // 
            this.connBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("connBtn.BackgroundImage")));
            this.connBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.connBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connBtn.ForeColor = System.Drawing.Color.BurlyWood;
            this.connBtn.Location = new System.Drawing.Point(620, 88);
            this.connBtn.Name = "connBtn";
            this.connBtn.Size = new System.Drawing.Size(116, 27);
            this.connBtn.TabIndex = 3;
            this.connBtn.Text = "Connect";
            this.connBtn.UseVisualStyleBackColor = true;
            this.connBtn.Click += new System.EventHandler(this.connBtn_Click);
            // 
            // disconnbtn
            // 
            this.disconnbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("disconnbtn.BackgroundImage")));
            this.disconnbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.disconnbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnbtn.ForeColor = System.Drawing.Color.BurlyWood;
            this.disconnbtn.Location = new System.Drawing.Point(492, 88);
            this.disconnbtn.Name = "disconnbtn";
            this.disconnbtn.Size = new System.Drawing.Size(116, 27);
            this.disconnbtn.TabIndex = 4;
            this.disconnbtn.Text = "Disconnect";
            this.disconnbtn.UseVisualStyleBackColor = true;
            this.disconnbtn.Click += new System.EventHandler(this.disconnbtn_Click);
            // 
            // clnConslTxt
            // 
            this.clnConslTxt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clnConslTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clnConslTxt.ForeColor = System.Drawing.Color.BurlyWood;
            this.clnConslTxt.Location = new System.Drawing.Point(318, 128);
            this.clnConslTxt.Multiline = true;
            this.clnConslTxt.Name = "clnConslTxt";
            this.clnConslTxt.ReadOnly = true;
            this.clnConslTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.clnConslTxt.Size = new System.Drawing.Size(418, 162);
            this.clnConslTxt.TabIndex = 5;
            this.clnConslTxt.Text = "Welcome to the trivia game! Connect to a server to begin.";
            // 
            // timePrgBar
            // 
            this.timePrgBar.ForeColor = System.Drawing.Color.Maroon;
            this.timePrgBar.Location = new System.Drawing.Point(103, 405);
            this.timePrgBar.Maximum = 150;
            this.timePrgBar.Name = "timePrgBar";
            this.timePrgBar.Size = new System.Drawing.Size(386, 19);
            this.timePrgBar.TabIndex = 6;
            // 
            // selctA_RBtn
            // 
            this.selctA_RBtn.AutoSize = true;
            this.selctA_RBtn.BackColor = System.Drawing.Color.Transparent;
            this.selctA_RBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selctA_RBtn.ForeColor = System.Drawing.Color.BurlyWood;
            this.selctA_RBtn.Location = new System.Drawing.Point(341, 304);
            this.selctA_RBtn.Name = "selctA_RBtn";
            this.selctA_RBtn.Size = new System.Drawing.Size(39, 24);
            this.selctA_RBtn.TabIndex = 7;
            this.selctA_RBtn.TabStop = true;
            this.selctA_RBtn.Text = "A";
            this.selctA_RBtn.UseVisualStyleBackColor = false;
            // 
            // selctB_RBtn
            // 
            this.selctB_RBtn.AutoSize = true;
            this.selctB_RBtn.BackColor = System.Drawing.Color.Transparent;
            this.selctB_RBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selctB_RBtn.ForeColor = System.Drawing.Color.Tan;
            this.selctB_RBtn.Location = new System.Drawing.Point(446, 304);
            this.selctB_RBtn.Name = "selctB_RBtn";
            this.selctB_RBtn.Size = new System.Drawing.Size(39, 24);
            this.selctB_RBtn.TabIndex = 8;
            this.selctB_RBtn.TabStop = true;
            this.selctB_RBtn.Text = "B";
            this.selctB_RBtn.UseVisualStyleBackColor = false;
            // 
            // selctC_RBtn
            // 
            this.selctC_RBtn.AutoSize = true;
            this.selctC_RBtn.BackColor = System.Drawing.Color.Transparent;
            this.selctC_RBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selctC_RBtn.ForeColor = System.Drawing.Color.BurlyWood;
            this.selctC_RBtn.Location = new System.Drawing.Point(550, 303);
            this.selctC_RBtn.Name = "selctC_RBtn";
            this.selctC_RBtn.Size = new System.Drawing.Size(39, 24);
            this.selctC_RBtn.TabIndex = 9;
            this.selctC_RBtn.TabStop = true;
            this.selctC_RBtn.Text = "C";
            this.selctC_RBtn.UseVisualStyleBackColor = false;
            // 
            // selctD_RBtn
            // 
            this.selctD_RBtn.AutoSize = true;
            this.selctD_RBtn.BackColor = System.Drawing.Color.Transparent;
            this.selctD_RBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selctD_RBtn.ForeColor = System.Drawing.Color.BurlyWood;
            this.selctD_RBtn.Location = new System.Drawing.Point(657, 304);
            this.selctD_RBtn.Name = "selctD_RBtn";
            this.selctD_RBtn.Size = new System.Drawing.Size(40, 24);
            this.selctD_RBtn.TabIndex = 10;
            this.selctD_RBtn.TabStop = true;
            this.selctD_RBtn.Text = "D";
            this.selctD_RBtn.UseVisualStyleBackColor = false;
            // 
            // sbmtBtn
            // 
            this.sbmtBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sbmtBtn.BackgroundImage")));
            this.sbmtBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbmtBtn.ForeColor = System.Drawing.Color.BurlyWood;
            this.sbmtBtn.Location = new System.Drawing.Point(556, 376);
            this.sbmtBtn.Name = "sbmtBtn";
            this.sbmtBtn.Size = new System.Drawing.Size(181, 76);
            this.sbmtBtn.TabIndex = 11;
            this.sbmtBtn.Text = "Submit";
            this.sbmtBtn.UseVisualStyleBackColor = true;
            this.sbmtBtn.Click += new System.EventHandler(this.sbmtBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(786, 481);
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
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(802, 519);
            this.MinimumSize = new System.Drawing.Size(802, 519);
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
        private System.Windows.Forms.Timer timer1;
    }
}

