namespace EMS_Server
{
    partial class EMS_ServerMainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMS_ServerMainScreen));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.centerPic = new System.Windows.Forms.PictureBox();
            this.btnSimExit = new System.Windows.Forms.Button();
            this.btnSimEnter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtServerConsole = new System.Windows.Forms.TextBox();
            this.listnerTimer = new System.Windows.Forms.Timer(this.components);
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centerPic)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Transparent;
            this.panelLeft.Controls.Add(this.centerPic);
            this.panelLeft.Controls.Add(this.btnSimExit);
            this.panelLeft.Controls.Add(this.btnSimEnter);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(185, 715);
            this.panelLeft.TabIndex = 0;
            // 
            // centerPic
            // 
            this.centerPic.Dock = System.Windows.Forms.DockStyle.Top;
            this.centerPic.Image = ((System.Drawing.Image)(resources.GetObject("centerPic.Image")));
            this.centerPic.Location = new System.Drawing.Point(0, 0);
            this.centerPic.Name = "centerPic";
            this.centerPic.Size = new System.Drawing.Size(185, 159);
            this.centerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.centerPic.TabIndex = 1;
            this.centerPic.TabStop = false;
            this.centerPic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSimExit
            // 
            this.btnSimExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSimExit.Location = new System.Drawing.Point(0, 669);
            this.btnSimExit.Name = "btnSimExit";
            this.btnSimExit.Size = new System.Drawing.Size(185, 23);
            this.btnSimExit.TabIndex = 1;
            this.btnSimExit.Text = "Simulate Exit";
            this.btnSimExit.UseVisualStyleBackColor = true;
            this.btnSimExit.Click += new System.EventHandler(this.btnSimExit_Click);
            // 
            // btnSimEnter
            // 
            this.btnSimEnter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSimEnter.Location = new System.Drawing.Point(0, 692);
            this.btnSimEnter.Name = "btnSimEnter";
            this.btnSimEnter.Size = new System.Drawing.Size(185, 23);
            this.btnSimEnter.TabIndex = 0;
            this.btnSimEnter.Text = "Simulate Enter";
            this.btnSimEnter.UseVisualStyleBackColor = true;
            this.btnSimEnter.Click += new System.EventHandler(this.btnSimEnter_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtServerConsole);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(185, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 273);
            this.panel1.TabIndex = 1;
            // 
            // txtServerConsole
            // 
            this.txtServerConsole.AcceptsReturn = true;
            this.txtServerConsole.AcceptsTab = true;
            this.txtServerConsole.AllowDrop = true;
            this.txtServerConsole.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtServerConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServerConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServerConsole.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtServerConsole.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.txtServerConsole.Location = new System.Drawing.Point(0, 0);
            this.txtServerConsole.Multiline = true;
            this.txtServerConsole.Name = "txtServerConsole";
            this.txtServerConsole.PlaceholderText = "Server Console";
            this.txtServerConsole.Size = new System.Drawing.Size(953, 273);
            this.txtServerConsole.TabIndex = 0;
            this.txtServerConsole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtServerConsole_KeyPress);
            // 
            // listnerTimer
            // 
            this.listnerTimer.Interval = 60000;
            this.listnerTimer.Tick += new System.EventHandler(this.listnerTimer_Tick);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.btnExit);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(1138, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(180, 715);
            this.panelRight.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(151, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(26, 27);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // EMS_ServerMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1318, 715);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EMS_ServerMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EMS_ServerMainScreen_Load);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.centerPic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelLeft;
        private Panel panel1;
        private TextBox txtServerConsole;
        private PictureBox centerPic;
        private System.Windows.Forms.Timer listnerTimer;
        private Panel panelRight;
        private Button btnExit;
        private Button btnSimExit;
        private Button btnSimEnter;
    }
}