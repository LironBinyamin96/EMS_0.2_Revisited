namespace EMS_Client
{
    partial class EMS_ClientMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMS_ClientMainScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.panelStyle = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAttendence = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.btnMail = new System.Windows.Forms.Button();
            this.btnEditingEmployee = new System.Windows.Forms.Button();
            this.panelForUser = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.btnViewOnSite = new System.Windows.Forms.Button();
            this.lblCurrentOnShift = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.userPicture);
            this.panel1.Controls.Add(this.panelStyle);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnAttendence);
            this.panel1.Controls.Add(this.btnData);
            this.panel1.Controls.Add(this.btnMail);
            this.panel1.Controls.Add(this.btnEditingEmployee);
            this.panel1.Controls.Add(this.panelForUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 594);
            this.panel1.TabIndex = 0;
            // 
            // userPicture
            // 
            this.userPicture.Location = new System.Drawing.Point(12, 364);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(149, 165);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPicture.TabIndex = 6;
            this.userPicture.TabStop = false;
            // 
            // panelStyle
            // 
            this.panelStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panelStyle.Location = new System.Drawing.Point(0, 167);
            this.panelStyle.Name = "panelStyle";
            this.panelStyle.Size = new System.Drawing.Size(3, 112);
            this.panelStyle.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(0, 535);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(178, 59);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnAttendence
            // 
            this.btnAttendence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAttendence.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAttendence.FlatAppearance.BorderSize = 0;
            this.btnAttendence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendence.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAttendence.Image = global::EMS_Client.Properties.Resources.schedule;
            this.btnAttendence.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAttendence.Location = new System.Drawing.Point(0, 299);
            this.btnAttendence.Name = "btnAttendence";
            this.btnAttendence.Size = new System.Drawing.Size(178, 59);
            this.btnAttendence.TabIndex = 4;
            this.btnAttendence.Text = "  Attendance table      ";
            this.btnAttendence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendence.UseVisualStyleBackColor = true;
            this.btnAttendence.Click += new System.EventHandler(this.btnAttendence_Click);
            this.btnAttendence.Leave += new System.EventHandler(this.btnAttendence_Leave);
            // 
            // btnData
            // 
            this.btnData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnData.FlatAppearance.BorderSize = 0;
            this.btnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnData.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnData.Image = global::EMS_Client.Properties.Resources.statistic;
            this.btnData.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnData.Location = new System.Drawing.Point(0, 240);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(178, 59);
            this.btnData.TabIndex = 3;
            this.btnData.Text = "  General Data      ";
            this.btnData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            this.btnData.Leave += new System.EventHandler(this.btnData_Leave);
            // 
            // btnMail
            // 
            this.btnMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMail.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMail.FlatAppearance.BorderSize = 0;
            this.btnMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMail.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMail.Image = global::EMS_Client.Properties.Resources.gmail_logo;
            this.btnMail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMail.Location = new System.Drawing.Point(0, 181);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(178, 59);
            this.btnMail.TabIndex = 2;
            this.btnMail.Text = "  Email";
            this.btnMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMail.UseVisualStyleBackColor = true;
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            this.btnMail.Leave += new System.EventHandler(this.btnMail_Leave);
            // 
            // btnEditingEmployee
            // 
            this.btnEditingEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditingEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditingEmployee.FlatAppearance.BorderSize = 0;
            this.btnEditingEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditingEmployee.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditingEmployee.Image = global::EMS_Client.Properties.Resources.imgEdit;
            this.btnEditingEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditingEmployee.Location = new System.Drawing.Point(0, 122);
            this.btnEditingEmployee.Name = "btnEditingEmployee";
            this.btnEditingEmployee.Size = new System.Drawing.Size(178, 59);
            this.btnEditingEmployee.TabIndex = 1;
            this.btnEditingEmployee.Text = "  Editing Employee  ";
            this.btnEditingEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditingEmployee.UseVisualStyleBackColor = true;
            this.btnEditingEmployee.Click += new System.EventHandler(this.btnEditingEmployee_Click);
            this.btnEditingEmployee.Leave += new System.EventHandler(this.btnEditingEmployee_Leave);
            // 
            // panelForUser
            // 
            this.panelForUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelForUser.BackgroundImage")));
            this.panelForUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelForUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForUser.Location = new System.Drawing.Point(0, 0);
            this.panelForUser.Name = "panelForUser";
            this.panelForUser.Size = new System.Drawing.Size(178, 122);
            this.panelForUser.TabIndex = 1;
            this.panelForUser.Paint += new System.Windows.Forms.PaintEventHandler(this.panelForUser_Paint);
            this.panelForUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelForUser_MouseDown);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackgroundImage = global::EMS_Client.Properties.Resources.HR11;
            this.panelDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDesktop.Controls.Add(this.btnViewOnSite);
            this.panelDesktop.Controls.Add(this.lblCurrentOnShift);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(178, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(759, 594);
            this.panelDesktop.TabIndex = 1;
            this.panelDesktop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDesktop_MouseDown);
            // 
            // btnViewOnSite
            // 
            this.btnViewOnSite.BackColor = System.Drawing.Color.Transparent;
            this.btnViewOnSite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnViewOnSite.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnViewOnSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewOnSite.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewOnSite.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewOnSite.Location = new System.Drawing.Point(6, 94);
            this.btnViewOnSite.Name = "btnViewOnSite";
            this.btnViewOnSite.Size = new System.Drawing.Size(70, 28);
            this.btnViewOnSite.TabIndex = 7;
            this.btnViewOnSite.Text = "View";
            this.btnViewOnSite.UseVisualStyleBackColor = false;
            this.btnViewOnSite.Click += new System.EventHandler(this.btnViewOnSite_Click);
            // 
            // lblCurrentOnShift
            // 
            this.lblCurrentOnShift.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentOnShift.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentOnShift.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCurrentOnShift.Location = new System.Drawing.Point(6, 38);
            this.lblCurrentOnShift.Name = "lblCurrentOnShift";
            this.lblCurrentOnShift.Size = new System.Drawing.Size(228, 53);
            this.lblCurrentOnShift.TabIndex = 24;
            this.lblCurrentOnShift.Text = "Current employees on site:";
            // 
            // EMS_ClientMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(937, 594);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EMS_ClientMainScreen";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EMS_ClientMainScreen_FormClosing);
            this.Load += new System.EventHandler(this.EMS_ClientMainScreen_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnAttendence;
        private Button btnData;
        private Button btnMail;
        private Button btnEditingEmployee;
        private Panel panelForUser;
        private Panel panelDesktop;
        private Button btnExit;
        private Panel panelStyle;
        private PictureBox userPicture;
        private Button btnViewOnSite;
        private Label lblCurrentOnShift;
    }
}