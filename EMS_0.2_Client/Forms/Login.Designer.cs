namespace EMS_Client.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblProgrammName = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPasscode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPasscode = new System.Windows.Forms.Panel();
            this.btnSendAgain = new System.Windows.Forms.Button();
            this.panelPasscodeText = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblPasscode = new System.Windows.Forms.Label();
            this.btnLoginPasscode = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.pictureBoxEye = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.txtIntId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelPasscode.SuspendLayout();
            this.panelPasscodeText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.panelPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.LightGray;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.txtPassword.Location = new System.Drawing.Point(40, 9);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(176, 19);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // lblProgrammName
            // 
            this.lblProgrammName.BackColor = System.Drawing.Color.Transparent;
            this.lblProgrammName.Font = new System.Drawing.Font("Yu Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblProgrammName.ForeColor = System.Drawing.Color.LightCyan;
            this.lblProgrammName.Location = new System.Drawing.Point(12, 446);
            this.lblProgrammName.Name = "lblProgrammName";
            this.lblProgrammName.Size = new System.Drawing.Size(558, 40);
            this.lblProgrammName.TabIndex = 3;
            this.lblProgrammName.Text = "Employee Management System";
            this.lblProgrammName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblProgrammName_MouseDown);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExit.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblExit.Location = new System.Drawing.Point(712, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(20, 21);
            this.lblExit.TabIndex = 4;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txtPasscode
            // 
            this.txtPasscode.BackColor = System.Drawing.Color.LightGray;
            this.txtPasscode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasscode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPasscode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPasscode.Location = new System.Drawing.Point(41, 5);
            this.txtPasscode.Name = "txtPasscode";
            this.txtPasscode.PlaceholderText = "Passcode";
            this.txtPasscode.Size = new System.Drawing.Size(198, 19);
            this.txtPasscode.TabIndex = 8;
            this.txtPasscode.Click += new System.EventHandler(this.txtPasscode_Click);
            this.txtPasscode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPasscode_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panelPasscode);
            this.panel1.Controls.Add(this.panelLogin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 373);
            this.panel1.TabIndex = 9;
            // 
            // panelPasscode
            // 
            this.panelPasscode.BackColor = System.Drawing.Color.Transparent;
            this.panelPasscode.Controls.Add(this.btnSendAgain);
            this.panelPasscode.Controls.Add(this.panelPasscodeText);
            this.panelPasscode.Controls.Add(this.lblPasscode);
            this.panelPasscode.Controls.Add(this.btnLoginPasscode);
            this.panelPasscode.Location = new System.Drawing.Point(11, 157);
            this.panelPasscode.Name = "panelPasscode";
            this.panelPasscode.Size = new System.Drawing.Size(247, 211);
            this.panelPasscode.TabIndex = 10;
            this.panelPasscode.Visible = false;
            // 
            // btnSendAgain
            // 
            this.btnSendAgain.BackColor = System.Drawing.Color.Transparent;
            this.btnSendAgain.FlatAppearance.BorderSize = 0;
            this.btnSendAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendAgain.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSendAgain.ForeColor = System.Drawing.Color.White;
            this.btnSendAgain.Location = new System.Drawing.Point(158, 120);
            this.btnSendAgain.Name = "btnSendAgain";
            this.btnSendAgain.Size = new System.Drawing.Size(86, 28);
            this.btnSendAgain.TabIndex = 14;
            this.btnSendAgain.Text = "Send again";
            this.btnSendAgain.UseVisualStyleBackColor = false;
            this.btnSendAgain.Click += new System.EventHandler(this.btnSendAgain_Click);
            // 
            // panelPasscodeText
            // 
            this.panelPasscodeText.BackColor = System.Drawing.Color.LightGray;
            this.panelPasscodeText.Controls.Add(this.pictureBox3);
            this.panelPasscodeText.Controls.Add(this.txtPasscode);
            this.panelPasscodeText.Location = new System.Drawing.Point(0, 82);
            this.panelPasscodeText.Name = "panelPasscodeText";
            this.panelPasscodeText.Size = new System.Drawing.Size(247, 35);
            this.panelPasscodeText.TabIndex = 13;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // lblPasscode
            // 
            this.lblPasscode.AutoSize = true;
            this.lblPasscode.BackColor = System.Drawing.Color.Transparent;
            this.lblPasscode.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPasscode.ForeColor = System.Drawing.Color.LightCyan;
            this.lblPasscode.Location = new System.Drawing.Point(8, 21);
            this.lblPasscode.Name = "lblPasscode";
            this.lblPasscode.Size = new System.Drawing.Size(236, 34);
            this.lblPasscode.TabIndex = 10;
            this.lblPasscode.Text = "The verification code has been sent\r\nto your email address.";
            // 
            // btnLoginPasscode
            // 
            this.btnLoginPasscode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLoginPasscode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLoginPasscode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginPasscode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoginPasscode.ForeColor = System.Drawing.Color.White;
            this.btnLoginPasscode.Location = new System.Drawing.Point(58, 166);
            this.btnLoginPasscode.Name = "btnLoginPasscode";
            this.btnLoginPasscode.Size = new System.Drawing.Size(117, 38);
            this.btnLoginPasscode.TabIndex = 9;
            this.btnLoginPasscode.Text = "Login";
            this.btnLoginPasscode.UseVisualStyleBackColor = false;
            this.btnLoginPasscode.Click += new System.EventHandler(this.btnLoginPasscode_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelLogin.Controls.Add(this.panelPassword);
            this.panelLogin.Controls.Add(this.panelUser);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Location = new System.Drawing.Point(11, 156);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(247, 214);
            this.panelLogin.TabIndex = 6;
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.Color.LightGray;
            this.panelPassword.Controls.Add(this.pictureBoxEye);
            this.panelPassword.Controls.Add(this.pictureBox2);
            this.panelPassword.Controls.Add(this.txtPassword);
            this.panelPassword.Location = new System.Drawing.Point(0, 106);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(247, 35);
            this.panelPassword.TabIndex = 13;
            // 
            // pictureBoxEye
            // 
            this.pictureBoxEye.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEye.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEye.Image")));
            this.pictureBoxEye.Location = new System.Drawing.Point(218, 7);
            this.pictureBoxEye.Name = "pictureBoxEye";
            this.pictureBoxEye.Size = new System.Drawing.Size(25, 23);
            this.pictureBoxEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEye.TabIndex = 13;
            this.pictureBoxEye.TabStop = false;
            this.pictureBoxEye.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxEye_MouseDown);
            this.pictureBoxEye.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxEye_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.LightGray;
            this.panelUser.Controls.Add(this.pictureBoxUser);
            this.panelUser.Controls.Add(this.txtIntId);
            this.panelUser.Location = new System.Drawing.Point(0, 55);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(247, 35);
            this.panelUser.TabIndex = 12;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUser.Image")));
            this.pictureBoxUser.Location = new System.Drawing.Point(3, 4);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(30, 26);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.TabIndex = 11;
            this.pictureBoxUser.TabStop = false;
            // 
            // txtIntId
            // 
            this.txtIntId.BackColor = System.Drawing.Color.LightGray;
            this.txtIntId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIntId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIntId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.txtIntId.Location = new System.Drawing.Point(38, 8);
            this.txtIntId.Name = "txtIntId";
            this.txtIntId.PlaceholderText = "Internal ID";
            this.txtIntId.Size = new System.Drawing.Size(190, 19);
            this.txtIntId.TabIndex = 0;
            this.txtIntId.Click += new System.EventHandler(this.txtIntId_Click);
            this.txtIntId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIntId_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Login to your account";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(57, 169);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(118, 38);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = global::EMS_Client.Properties.Resources.global_data_and_hand;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 501);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblProgrammName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelPasscode.ResumeLayout(false);
            this.panelPasscode.PerformLayout();
            this.panelPasscodeText.ResumeLayout(false);
            this.panelPasscodeText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtPassword;
        private Label lblProgrammName;
        private Label lblExit;
        private PictureBox pictureBox1;
        private TextBox txtPasscode;
        private Panel panel1;
        private Panel panelLogin;
        private Panel panelPasscode;
        private Button btnLoginPasscode;
        private Label label1;
        private TextBox txtIntId;
        private Button btnLogin;
        private Label lblPasscode;
        private Panel panelPassword;
        private Panel panelUser;
        private PictureBox pictureBox2;
        private PictureBox pictureBoxUser;
        private PictureBox pictureBoxEye;
        private Panel panelPasscodeText;
        private PictureBox pictureBox3;
        private Button btnSendAgain;
    }
}