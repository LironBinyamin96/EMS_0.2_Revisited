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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCaptureFace = new System.Windows.Forms.Button();
            this.btnCapture = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.boxTest = new System.Windows.Forms.PictureBox();
            this.grayFaceBox = new System.Windows.Forms.PictureBox();
            this.txtServerConsole = new System.Windows.Forms.TextBox();
            this.listnerTimer = new System.Windows.Forms.Timer(this.components);
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.videoFeed = new System.Windows.Forms.PictureBox();
            this.faceDetected = new System.Windows.Forms.PictureBox();
            this.picDetected = new System.Windows.Forms.PictureBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayFaceBox)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoFeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faceDetected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetected)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.boxTest);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(184, 715);
            this.panelLeft.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 543);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCaptureFace
            // 
            this.btnCaptureFace.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCaptureFace.Location = new System.Drawing.Point(271, 366);
            this.btnCaptureFace.Name = "btnCaptureFace";
            this.btnCaptureFace.Size = new System.Drawing.Size(75, 23);
            this.btnCaptureFace.TabIndex = 2;
            this.btnCaptureFace.Text = "Capture face";
            this.btnCaptureFace.UseVisualStyleBackColor = true;
            this.btnCaptureFace.Click += new System.EventHandler(this.btnCaptureFace_Click);
            // 
            // btnCapture
            // 
            this.btnCapture.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCapture.Location = new System.Drawing.Point(190, 366);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(75, 23);
            this.btnCapture.TabIndex = 2;
            this.btnCapture.Text = "btnCapture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grayFaceBox);
            this.panel1.Controls.Add(this.txtServerConsole);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(184, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 273);
            this.panel1.TabIndex = 1;
            // 
            // boxTest
            // 
            this.boxTest.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.boxTest.Location = new System.Drawing.Point(29, 429);
            this.boxTest.Name = "boxTest";
            this.boxTest.Size = new System.Drawing.Size(119, 108);
            this.boxTest.TabIndex = 10;
            this.boxTest.TabStop = false;
            // 
            // grayFaceBox
            // 
            this.grayFaceBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.grayFaceBox.Location = new System.Drawing.Point(672, 69);
            this.grayFaceBox.Name = "grayFaceBox";
            this.grayFaceBox.Size = new System.Drawing.Size(320, 320);
            this.grayFaceBox.TabIndex = 9;
            this.grayFaceBox.TabStop = false;
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
            this.txtServerConsole.Size = new System.Drawing.Size(998, 273);
            this.txtServerConsole.TabIndex = 0;
            this.txtServerConsole.TextChanged += new System.EventHandler(this.txtServerConsole_TextChanged);
            // 
            // listnerTimer
            // 
            this.listnerTimer.Interval = 2000;
            this.listnerTimer.Tick += new System.EventHandler(this.listnerTimer_Tick);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.btnExit);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(1182, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(136, 715);
            this.panelRight.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(107, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(26, 27);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // videoFeed
            // 
            this.videoFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.videoFeed.Location = new System.Drawing.Point(184, 395);
            this.videoFeed.Name = "videoFeed";
            this.videoFeed.Size = new System.Drawing.Size(320, 320);
            this.videoFeed.TabIndex = 2;
            this.videoFeed.TabStop = false;
            // 
            // faceDetected
            // 
            this.faceDetected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.faceDetected.Location = new System.Drawing.Point(520, 395);
            this.faceDetected.Name = "faceDetected";
            this.faceDetected.Size = new System.Drawing.Size(320, 320);
            this.faceDetected.TabIndex = 3;
            this.faceDetected.TabStop = false;
            this.faceDetected.Click += new System.EventHandler(this.faceDetected_Click);
            // 
            // picDetected
            // 
            this.picDetected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picDetected.Location = new System.Drawing.Point(856, 395);
            this.picDetected.Name = "picDetected";
            this.picDetected.Size = new System.Drawing.Size(320, 320);
            this.picDetected.TabIndex = 4;
            this.picDetected.TabStop = false;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddPerson.Location = new System.Drawing.Point(352, 366);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(75, 23);
            this.btnAddPerson.TabIndex = 5;
            this.btnAddPerson.Text = "AddPerson";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTrain.Location = new System.Drawing.Point(684, 366);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(75, 23);
            this.btnTrain.TabIndex = 6;
            this.btnTrain.Text = "Train Model";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.Location = new System.Drawing.Point(433, 366);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EMS_ServerMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1318, 715);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.btnCaptureFace);
            this.Controls.Add(this.picDetected);
            this.Controls.Add(this.faceDetected);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.videoFeed);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayFaceBox)).EndInit();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.videoFeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faceDetected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelLeft;
        private Panel panel1;
        private TextBox txtServerConsole;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer listnerTimer;
        private Button btnCapture;
        private Button btnCaptureFace;
        private Panel panelRight;
        private PictureBox videoFeed;
        private Button btnExit;
        private PictureBox faceDetected;
        private PictureBox picDetected;
        private Button btnAddPerson;
        private Button btnTrain;
        private Button btnSave;
        private PictureBox grayFaceBox;
        private PictureBox boxTest;
    }
}