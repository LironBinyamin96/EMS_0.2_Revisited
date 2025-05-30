﻿namespace EMS_Client.Forms
{
    partial class UpdatePersonalDetails
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
            this.panelUpdatePersonalDetails = new System.Windows.Forms.Panel();
            this.btnX = new System.Windows.Forms.Button();
            this.lblUpdatePersonalDetails = new System.Windows.Forms.Label();
            this.gUpdatePersonalDetails = new System.Windows.Forms.GroupBox();
            this.btnCamera = new RJCodeAdvance.RJControls.RJButton();
            this.btnUpload = new RJCodeAdvance.RJControls.RJButton();
            this.positionBox = new System.Windows.Forms.ComboBox();
            this.btnTakePicture = new RJCodeAdvance.RJControls.RJButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUploading = new System.Windows.Forms.Label();
            this.txtSalaryModifire = new System.Windows.Forms.TextBox();
            this.panelSalaryModifire = new System.Windows.Forms.Panel();
            this.lblSalaryModifire = new System.Windows.Forms.Label();
            this.txtBaseSalary = new System.Windows.Forms.TextBox();
            this.panelBaseSalary = new System.Windows.Forms.Panel();
            this.lblBaseSalary = new System.Windows.Forms.Label();
            this.panelPosition = new System.Windows.Forms.Panel();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.panelPhone = new System.Windows.Forms.Panel();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtAddres = new System.Windows.Forms.TextBox();
            this.panelAddres = new System.Windows.Forms.Panel();
            this.lblAddres = new System.Windows.Forms.Label();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.panelDate = new System.Windows.Forms.Panel();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.panelGender = new System.Windows.Forms.Panel();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.panelMname = new System.Windows.Forms.Panel();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.panelLname = new System.Windows.Forms.Panel();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.panelFname = new System.Windows.Forms.Panel();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panelID = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSelect = new RJCodeAdvance.RJControls.RJButton();
            this.btnUnemploy = new RJCodeAdvance.RJControls.RJButton();
            this.btnDelete = new RJCodeAdvance.RJControls.RJButton();
            this.btnSave = new RJCodeAdvance.RJControls.RJButton();
            this.btnCancel = new RJCodeAdvance.RJControls.RJButton();
            this.btnEmploy = new RJCodeAdvance.RJControls.RJButton();
            this.panelUpdatePersonalDetails.SuspendLayout();
            this.gUpdatePersonalDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUpdatePersonalDetails
            // 
            this.panelUpdatePersonalDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelUpdatePersonalDetails.Controls.Add(this.btnX);
            this.panelUpdatePersonalDetails.Controls.Add(this.lblUpdatePersonalDetails);
            this.panelUpdatePersonalDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpdatePersonalDetails.Location = new System.Drawing.Point(0, 0);
            this.panelUpdatePersonalDetails.Name = "panelUpdatePersonalDetails";
            this.panelUpdatePersonalDetails.Size = new System.Drawing.Size(708, 85);
            this.panelUpdatePersonalDetails.TabIndex = 4;
            this.panelUpdatePersonalDetails.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelUpdatePersonalDetails_MouseDown);
            // 
            // btnX
            // 
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnX.Location = new System.Drawing.Point(682, 3);
            this.btnX.Name = "btnX";
            this.btnX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnX.Size = new System.Drawing.Size(23, 27);
            this.btnX.TabIndex = 40;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // lblUpdatePersonalDetails
            // 
            this.lblUpdatePersonalDetails.AutoSize = true;
            this.lblUpdatePersonalDetails.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUpdatePersonalDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblUpdatePersonalDetails.Location = new System.Drawing.Point(247, 23);
            this.lblUpdatePersonalDetails.Name = "lblUpdatePersonalDetails";
            this.lblUpdatePersonalDetails.Size = new System.Drawing.Size(326, 35);
            this.lblUpdatePersonalDetails.TabIndex = 0;
            this.lblUpdatePersonalDetails.Text = "Update Personal Details";
            this.lblUpdatePersonalDetails.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblUpdatePersonalDetails_MouseDown);
            // 
            // gUpdatePersonalDetails
            // 
            this.gUpdatePersonalDetails.Controls.Add(this.btnCamera);
            this.gUpdatePersonalDetails.Controls.Add(this.btnUpload);
            this.gUpdatePersonalDetails.Controls.Add(this.positionBox);
            this.gUpdatePersonalDetails.Controls.Add(this.btnTakePicture);
            this.gUpdatePersonalDetails.Controls.Add(this.pictureBox1);
            this.gUpdatePersonalDetails.Controls.Add(this.lblUploading);
            this.gUpdatePersonalDetails.Controls.Add(this.txtSalaryModifire);
            this.gUpdatePersonalDetails.Controls.Add(this.panelSalaryModifire);
            this.gUpdatePersonalDetails.Controls.Add(this.lblSalaryModifire);
            this.gUpdatePersonalDetails.Controls.Add(this.txtBaseSalary);
            this.gUpdatePersonalDetails.Controls.Add(this.panelBaseSalary);
            this.gUpdatePersonalDetails.Controls.Add(this.lblBaseSalary);
            this.gUpdatePersonalDetails.Controls.Add(this.panelPosition);
            this.gUpdatePersonalDetails.Controls.Add(this.lblPosition);
            this.gUpdatePersonalDetails.Controls.Add(this.txtPhone);
            this.gUpdatePersonalDetails.Controls.Add(this.panelPhone);
            this.gUpdatePersonalDetails.Controls.Add(this.lblPhone);
            this.gUpdatePersonalDetails.Controls.Add(this.txtAddres);
            this.gUpdatePersonalDetails.Controls.Add(this.panelAddres);
            this.gUpdatePersonalDetails.Controls.Add(this.lblAddres);
            this.gUpdatePersonalDetails.Controls.Add(this.txtDateOfBirth);
            this.gUpdatePersonalDetails.Controls.Add(this.panelDate);
            this.gUpdatePersonalDetails.Controls.Add(this.lblDateOfBirth);
            this.gUpdatePersonalDetails.Controls.Add(this.txtGender);
            this.gUpdatePersonalDetails.Controls.Add(this.panelGender);
            this.gUpdatePersonalDetails.Controls.Add(this.lblGender);
            this.gUpdatePersonalDetails.Controls.Add(this.txtEmail);
            this.gUpdatePersonalDetails.Controls.Add(this.panelEmail);
            this.gUpdatePersonalDetails.Controls.Add(this.lblEmail);
            this.gUpdatePersonalDetails.Controls.Add(this.txtMiddleName);
            this.gUpdatePersonalDetails.Controls.Add(this.panelMname);
            this.gUpdatePersonalDetails.Controls.Add(this.lblMiddleName);
            this.gUpdatePersonalDetails.Controls.Add(this.txtLastName);
            this.gUpdatePersonalDetails.Controls.Add(this.panelLname);
            this.gUpdatePersonalDetails.Controls.Add(this.lblLName);
            this.gUpdatePersonalDetails.Controls.Add(this.txtFirstName);
            this.gUpdatePersonalDetails.Controls.Add(this.panelFname);
            this.gUpdatePersonalDetails.Controls.Add(this.lblFirstName);
            this.gUpdatePersonalDetails.Controls.Add(this.txtID);
            this.gUpdatePersonalDetails.Controls.Add(this.panelID);
            this.gUpdatePersonalDetails.Controls.Add(this.lblID);
            this.gUpdatePersonalDetails.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gUpdatePersonalDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.gUpdatePersonalDetails.Location = new System.Drawing.Point(12, 127);
            this.gUpdatePersonalDetails.Name = "gUpdatePersonalDetails";
            this.gUpdatePersonalDetails.Size = new System.Drawing.Size(657, 266);
            this.gUpdatePersonalDetails.TabIndex = 5;
            this.gUpdatePersonalDetails.TabStop = false;
            // 
            // btnCamera
            // 
            this.btnCamera.BackColor = System.Drawing.Color.Transparent;
            this.btnCamera.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCamera.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCamera.BorderRadius = 15;
            this.btnCamera.BorderSize = 1;
            this.btnCamera.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCamera.FlatAppearance.BorderSize = 2;
            this.btnCamera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnCamera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCamera.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCamera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCamera.Location = new System.Drawing.Point(535, 40);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(94, 29);
            this.btnCamera.TabIndex = 56;
            this.btnCamera.Text = "Camera";
            this.btnCamera.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCamera.UseVisualStyleBackColor = false;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.Transparent;
            this.btnUpload.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnUpload.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnUpload.BorderRadius = 15;
            this.btnUpload.BorderSize = 1;
            this.btnUpload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnUpload.FlatAppearance.BorderSize = 2;
            this.btnUpload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnUpload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnUpload.Location = new System.Drawing.Point(440, 39);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(90, 29);
            this.btnUpload.TabIndex = 55;
            this.btnUpload.Text = "Upload";
            this.btnUpload.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // positionBox
            // 
            this.positionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.positionBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.positionBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.positionBox.FormattingEnabled = true;
            this.positionBox.Items.AddRange(new object[] {
            "HR_Boss",
            "HR_Grunt",
            "IT_Boss",
            "IT_Grunt",
            "Maintenance_Boss",
            "Mechanic",
            "Worker"});
            this.positionBox.Location = new System.Drawing.Point(267, 129);
            this.positionBox.Name = "positionBox";
            this.positionBox.Size = new System.Drawing.Size(102, 24);
            this.positionBox.TabIndex = 42;
            // 
            // btnTakePicture
            // 
            this.btnTakePicture.BackColor = System.Drawing.Color.Transparent;
            this.btnTakePicture.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnTakePicture.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnTakePicture.BorderRadius = 15;
            this.btnTakePicture.BorderSize = 1;
            this.btnTakePicture.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnTakePicture.FlatAppearance.BorderSize = 2;
            this.btnTakePicture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnTakePicture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTakePicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakePicture.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTakePicture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnTakePicture.Location = new System.Drawing.Point(534, 40);
            this.btnTakePicture.Name = "btnTakePicture";
            this.btnTakePicture.Size = new System.Drawing.Size(93, 29);
            this.btnTakePicture.TabIndex = 57;
            this.btnTakePicture.Text = "Take picture";
            this.btnTakePicture.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnTakePicture.UseVisualStyleBackColor = false;
            this.btnTakePicture.Click += new System.EventHandler(this.btnPictureTakingImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(459, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // lblUploading
            // 
            this.lblUploading.AutoSize = true;
            this.lblUploading.Location = new System.Drawing.Point(462, 20);
            this.lblUploading.Name = "lblUploading";
            this.lblUploading.Size = new System.Drawing.Size(134, 17);
            this.lblUploading.TabIndex = 36;
            this.lblUploading.Text = "Uploading an image";
            // 
            // txtSalaryModifire
            // 
            this.txtSalaryModifire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtSalaryModifire.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSalaryModifire.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtSalaryModifire.Location = new System.Drawing.Point(312, 210);
            this.txtSalaryModifire.Name = "txtSalaryModifire";
            this.txtSalaryModifire.Size = new System.Drawing.Size(57, 17);
            this.txtSalaryModifire.TabIndex = 35;
            // 
            // panelSalaryModifire
            // 
            this.panelSalaryModifire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panelSalaryModifire.Location = new System.Drawing.Point(202, 229);
            this.panelSalaryModifire.Name = "panelSalaryModifire";
            this.panelSalaryModifire.Size = new System.Drawing.Size(170, 1);
            this.panelSalaryModifire.TabIndex = 34;
            // 
            // lblSalaryModifire
            // 
            this.lblSalaryModifire.AutoSize = true;
            this.lblSalaryModifire.Location = new System.Drawing.Point(202, 213);
            this.lblSalaryModifire.Name = "lblSalaryModifire";
            this.lblSalaryModifire.Size = new System.Drawing.Size(112, 17);
            this.lblSalaryModifire.TabIndex = 33;
            this.lblSalaryModifire.Text = "Salary Modifire :";
            // 
            // txtBaseSalary
            // 
            this.txtBaseSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtBaseSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBaseSalary.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtBaseSalary.Location = new System.Drawing.Point(289, 172);
            this.txtBaseSalary.Name = "txtBaseSalary";
            this.txtBaseSalary.Size = new System.Drawing.Size(80, 17);
            this.txtBaseSalary.TabIndex = 32;
            // 
            // panelBaseSalary
            // 
            this.panelBaseSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panelBaseSalary.Location = new System.Drawing.Point(202, 191);
            this.panelBaseSalary.Name = "panelBaseSalary";
            this.panelBaseSalary.Size = new System.Drawing.Size(170, 1);
            this.panelBaseSalary.TabIndex = 31;
            // 
            // lblBaseSalary
            // 
            this.lblBaseSalary.AutoSize = true;
            this.lblBaseSalary.Location = new System.Drawing.Point(202, 175);
            this.lblBaseSalary.Name = "lblBaseSalary";
            this.lblBaseSalary.Size = new System.Drawing.Size(88, 17);
            this.lblBaseSalary.TabIndex = 30;
            this.lblBaseSalary.Text = "Base salary :";
            // 
            // panelPosition
            // 
            this.panelPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panelPosition.Location = new System.Drawing.Point(202, 155);
            this.panelPosition.Name = "panelPosition";
            this.panelPosition.Size = new System.Drawing.Size(170, 1);
            this.panelPosition.TabIndex = 28;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(202, 139);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(67, 17);
            this.lblPosition.TabIndex = 27;
            this.lblPosition.Text = "Position :";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtPhone.Location = new System.Drawing.Point(257, 103);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(120, 17);
            this.txtPhone.TabIndex = 26;
            // 
            // panelPhone
            // 
            this.panelPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panelPhone.Location = new System.Drawing.Point(202, 122);
            this.panelPhone.Name = "panelPhone";
            this.panelPhone.Size = new System.Drawing.Size(170, 1);
            this.panelPhone.TabIndex = 25;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(202, 106);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(56, 17);
            this.lblPhone.TabIndex = 24;
            this.lblPhone.Text = "Phone :";
            // 
            // txtAddres
            // 
            this.txtAddres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtAddres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddres.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtAddres.Location = new System.Drawing.Point(262, 65);
            this.txtAddres.Name = "txtAddres";
            this.txtAddres.Size = new System.Drawing.Size(110, 17);
            this.txtAddres.TabIndex = 23;
            // 
            // panelAddres
            // 
            this.panelAddres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panelAddres.Location = new System.Drawing.Point(202, 84);
            this.panelAddres.Name = "panelAddres";
            this.panelAddres.Size = new System.Drawing.Size(170, 1);
            this.panelAddres.TabIndex = 22;
            // 
            // lblAddres
            // 
            this.lblAddres.AutoSize = true;
            this.lblAddres.Location = new System.Drawing.Point(202, 68);
            this.lblAddres.Name = "lblAddres";
            this.lblAddres.Size = new System.Drawing.Size(61, 17);
            this.lblAddres.TabIndex = 21;
            this.lblAddres.Text = "Addres :";
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtDateOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDateOfBirth.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtDateOfBirth.Location = new System.Drawing.Point(293, 29);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(80, 17);
            this.txtDateOfBirth.TabIndex = 20;
            // 
            // panelDate
            // 
            this.panelDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panelDate.Location = new System.Drawing.Point(202, 48);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(170, 1);
            this.panelDate.TabIndex = 19;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(202, 32);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(95, 17);
            this.lblDateOfBirth.TabIndex = 18;
            this.lblDateOfBirth.Text = "Date of birth :";
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGender.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtGender.Location = new System.Drawing.Point(76, 210);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(115, 17);
            this.txtGender.TabIndex = 17;
            // 
            // panelGender
            // 
            this.panelGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panelGender.Location = new System.Drawing.Point(15, 229);
            this.panelGender.Name = "panelGender";
            this.panelGender.Size = new System.Drawing.Size(170, 1);
            this.panelGender.TabIndex = 16;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(15, 213);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(62, 17);
            this.lblGender.TabIndex = 15;
            this.lblGender.Text = "Gender :";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtEmail.Location = new System.Drawing.Point(62, 172);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(120, 17);
            this.txtEmail.TabIndex = 14;
            // 
            // panelEmail
            // 
            this.panelEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panelEmail.Location = new System.Drawing.Point(15, 191);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(170, 1);
            this.panelEmail.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(15, 175);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 17);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email :";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMiddleName.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtMiddleName.Location = new System.Drawing.Point(107, 136);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(80, 17);
            this.txtMiddleName.TabIndex = 11;
            // 
            // panelMname
            // 
            this.panelMname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panelMname.Location = new System.Drawing.Point(15, 155);
            this.panelMname.Name = "panelMname";
            this.panelMname.Size = new System.Drawing.Size(170, 1);
            this.panelMname.TabIndex = 10;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(15, 139);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(95, 17);
            this.lblMiddleName.TabIndex = 9;
            this.lblMiddleName.Text = "Middle Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtLastName.Location = new System.Drawing.Point(96, 103);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 17);
            this.txtLastName.TabIndex = 8;
            // 
            // panelLname
            // 
            this.panelLname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panelLname.Location = new System.Drawing.Point(15, 122);
            this.panelLname.Name = "panelLname";
            this.panelLname.Size = new System.Drawing.Size(170, 1);
            this.panelLname.TabIndex = 7;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(15, 106);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(81, 17);
            this.lblLName.TabIndex = 6;
            this.lblLName.Text = "Last name :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtFirstName.Location = new System.Drawing.Point(96, 65);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 17);
            this.txtFirstName.TabIndex = 5;
            // 
            // panelFname
            // 
            this.panelFname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panelFname.Location = new System.Drawing.Point(15, 84);
            this.panelFname.Name = "panelFname";
            this.panelFname.Size = new System.Drawing.Size(170, 1);
            this.panelFname.TabIndex = 4;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(15, 68);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(84, 17);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First name :";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtID.Location = new System.Drawing.Point(36, 29);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(150, 17);
            this.txtID.TabIndex = 2;
            // 
            // panelID
            // 
            this.panelID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panelID.Location = new System.Drawing.Point(15, 48);
            this.panelID.Name = "panelID";
            this.panelID.Size = new System.Drawing.Size(170, 1);
            this.panelID.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(15, 32);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 17);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSelect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSelect.BorderRadius = 15;
            this.btnSelect.BorderSize = 2;
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSelect.FlatAppearance.BorderSize = 2;
            this.btnSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSelect.Location = new System.Drawing.Point(18, 91);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(185, 37);
            this.btnSelect.TabIndex = 50;
            this.btnSelect.Text = "Select an employee";
            this.btnSelect.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnUnemploy
            // 
            this.btnUnemploy.BackColor = System.Drawing.Color.Transparent;
            this.btnUnemploy.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnUnemploy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnUnemploy.BorderRadius = 15;
            this.btnUnemploy.BorderSize = 1;
            this.btnUnemploy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnUnemploy.FlatAppearance.BorderSize = 2;
            this.btnUnemploy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnUnemploy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUnemploy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnemploy.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUnemploy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnUnemploy.Location = new System.Drawing.Point(9, 409);
            this.btnUnemploy.Name = "btnUnemploy";
            this.btnUnemploy.Size = new System.Drawing.Size(89, 29);
            this.btnUnemploy.TabIndex = 51;
            this.btnUnemploy.Text = "Unemploy";
            this.btnUnemploy.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnUnemploy.UseVisualStyleBackColor = false;
            this.btnUnemploy.Visible = false;
            this.btnUnemploy.Click += new System.EventHandler(this.btnUnemploy_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDelete.BorderRadius = 15;
            this.btnDelete.BorderSize = 1;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDelete.Location = new System.Drawing.Point(104, 409);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 29);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "Delete Employee";
            this.btnDelete.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSave.BorderRadius = 15;
            this.btnSave.BorderSize = 1;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSave.Location = new System.Drawing.Point(247, 409);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 29);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.BorderSize = 1;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCancel.Location = new System.Drawing.Point(356, 409);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 29);
            this.btnCancel.TabIndex = 54;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEmploy
            // 
            this.btnEmploy.BackColor = System.Drawing.Color.Transparent;
            this.btnEmploy.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnEmploy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnEmploy.BorderRadius = 15;
            this.btnEmploy.BorderSize = 1;
            this.btnEmploy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnEmploy.FlatAppearance.BorderSize = 2;
            this.btnEmploy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnEmploy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEmploy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmploy.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmploy.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnEmploy.Location = new System.Drawing.Point(9, 409);
            this.btnEmploy.Name = "btnEmploy";
            this.btnEmploy.Size = new System.Drawing.Size(89, 29);
            this.btnEmploy.TabIndex = 55;
            this.btnEmploy.Text = "Employ";
            this.btnEmploy.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnEmploy.UseVisualStyleBackColor = false;
            this.btnEmploy.Visible = false;
            this.btnEmploy.Click += new System.EventHandler(this.btnEmploy_Click);
            // 
            // UpdatePersonalDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.btnEmploy);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUnemploy);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.gUpdatePersonalDetails);
            this.Controls.Add(this.panelUpdatePersonalDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdatePersonalDetails";
            this.Text = "UpdatePersonalDetails";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdatePersonalDetails_FormClosing);
            this.panelUpdatePersonalDetails.ResumeLayout(false);
            this.panelUpdatePersonalDetails.PerformLayout();
            this.gUpdatePersonalDetails.ResumeLayout(false);
            this.gUpdatePersonalDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelUpdatePersonalDetails;
        private Button btnX;
        private Label lblUpdatePersonalDetails;
        private GroupBox gUpdatePersonalDetails;
        private PictureBox pictureBox1;
        private Label lblUploading;
        private TextBox txtSalaryModifire;
        private Panel panelSalaryModifire;
        private Label lblSalaryModifire;
        private TextBox txtBaseSalary;
        private Panel panelBaseSalary;
        private Label lblBaseSalary;
        private Panel panelPosition;
        private Label lblPosition;
        private TextBox txtPhone;
        private Panel panelPhone;
        private Label lblPhone;
        private TextBox txtAddres;
        private Panel panelAddres;
        private Label lblAddres;
        private TextBox txtDateOfBirth;
        private Panel panelDate;
        private Label lblDateOfBirth;
        private TextBox txtGender;
        private Panel panelGender;
        private Label lblGender;
        private TextBox txtEmail;
        private Panel panelEmail;
        private Label lblEmail;
        private TextBox txtMiddleName;
        private Panel panelMname;
        private Label lblMiddleName;
        private TextBox txtLastName;
        private Panel panelLname;
        private Label lblLName;
        private TextBox txtFirstName;
        private Panel panelFname;
        private Label lblFirstName;
        private TextBox txtID;
        private Panel panelID;
        private Label lblID;
        private OpenFileDialog openFileDialog1;
        private ComboBox positionBox;
        private RJCodeAdvance.RJControls.RJButton btnSelect;
        private RJCodeAdvance.RJControls.RJButton btnUnemploy;
        private RJCodeAdvance.RJControls.RJButton btnDelete;
        private RJCodeAdvance.RJControls.RJButton btnSave;
        private RJCodeAdvance.RJControls.RJButton btnCancel;
        private RJCodeAdvance.RJControls.RJButton btnUpload;
        private RJCodeAdvance.RJControls.RJButton btnCamera;
        private RJCodeAdvance.RJControls.RJButton btnTakePicture;
        private RJCodeAdvance.RJControls.RJButton btnEmploy;
    }
}