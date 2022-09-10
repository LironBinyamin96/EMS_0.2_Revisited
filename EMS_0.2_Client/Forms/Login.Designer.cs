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
            this.txtIntId = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblProgrammName = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPasscode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPasscode = new System.Windows.Forms.Panel();
            this.lblPasscode = new System.Windows.Forms.Label();
            this.btnLoginPasscode = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelPasscode.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIntId
            // 
            this.txtIntId.BackColor = System.Drawing.SystemColors.Window;
            this.txtIntId.Location = new System.Drawing.Point(51, 35);
            this.txtIntId.Name = "txtIntId";
            this.txtIntId.PlaceholderText = "Internal ID";
            this.txtIntId.Size = new System.Drawing.Size(139, 23);
            this.txtIntId.TabIndex = 0;
            this.txtIntId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIntId_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(51, 88);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(141, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogin.Location = new System.Drawing.Point(75, 130);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(87, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
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
            this.pictureBox1.Location = new System.Drawing.Point(11, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txtPasscode
            // 
            this.txtPasscode.BackColor = System.Drawing.SystemColors.Window;
            this.txtPasscode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPasscode.Location = new System.Drawing.Point(56, 64);
            this.txtPasscode.Name = "txtPasscode";
            this.txtPasscode.PlaceholderText = "Passcode";
            this.txtPasscode.Size = new System.Drawing.Size(122, 23);
            this.txtPasscode.TabIndex = 8;
            this.txtPasscode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPasscode_KeyPress);
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
            this.panelPasscode.Controls.Add(this.lblPasscode);
            this.panelPasscode.Controls.Add(this.btnLoginPasscode);
            this.panelPasscode.Controls.Add(this.txtPasscode);
            this.panelPasscode.Location = new System.Drawing.Point(11, 156);
            this.panelPasscode.Name = "panelPasscode";
            this.panelPasscode.Size = new System.Drawing.Size(247, 198);
            this.panelPasscode.TabIndex = 10;
            this.panelPasscode.Visible = false;
            // 
            // lblPasscode
            // 
            this.lblPasscode.AutoSize = true;
            this.lblPasscode.BackColor = System.Drawing.Color.Transparent;
            this.lblPasscode.ForeColor = System.Drawing.Color.LightCyan;
            this.lblPasscode.Location = new System.Drawing.Point(23, 18);
            this.lblPasscode.Name = "lblPasscode";
            this.lblPasscode.Size = new System.Drawing.Size(192, 30);
            this.lblPasscode.TabIndex = 10;
            this.lblPasscode.Text = "The verification code has been sent\r\nto your email address.";
            // 
            // btnLoginPasscode
            // 
            this.btnLoginPasscode.BackColor = System.Drawing.Color.Transparent;
            this.btnLoginPasscode.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLoginPasscode.Location = new System.Drawing.Point(75, 101);
            this.btnLoginPasscode.Name = "btnLoginPasscode";
            this.btnLoginPasscode.Size = new System.Drawing.Size(87, 23);
            this.btnLoginPasscode.TabIndex = 9;
            this.btnLoginPasscode.Text = "Login";
            this.btnLoginPasscode.UseVisualStyleBackColor = false;
            this.btnLoginPasscode.Click += new System.EventHandler(this.btnLoginPasscode_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelLogin.Controls.Add(this.txtIntId);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.txtPassword);
            this.panelLogin.Location = new System.Drawing.Point(11, 156);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(247, 194);
            this.panelLogin.TabIndex = 6;
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
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtIntId;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblProgrammName;
        private Label lblExit;
        private PictureBox pictureBox1;
        private TextBox txtPasscode;
        private Panel panel1;
        private Panel panelLogin;
        private Panel panelPasscode;
        private Button btnLoginPasscode;
        private Label lblPasscode;
    }
}