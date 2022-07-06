namespace EMS_Client.Forms
{
    partial class addEmployee
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
            this.panelAddEmployee = new System.Windows.Forms.Panel();
            this.btnX = new System.Windows.Forms.Button();
            this.lblAddEmployee = new System.Windows.Forms.Label();
            this.gBoxRegistration = new System.Windows.Forms.GroupBox();
            this.positionBox = new System.Windows.Forms.ComboBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.lblUpload = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblUploading = new System.Windows.Forms.Label();
            this.txtSalaryModifire = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblSalaryModifire = new System.Windows.Forms.Label();
            this.txtBaseSalary = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblBaseSalary = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtAddres = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lblAddres = new System.Windows.Forms.Label();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelAddEmployee.SuspendLayout();
            this.gBoxRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAddEmployee
            // 
            this.panelAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelAddEmployee.Controls.Add(this.btnX);
            this.panelAddEmployee.Controls.Add(this.lblAddEmployee);
            this.panelAddEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddEmployee.Location = new System.Drawing.Point(0, 0);
            this.panelAddEmployee.Name = "panelAddEmployee";
            this.panelAddEmployee.Size = new System.Drawing.Size(708, 85);
            this.panelAddEmployee.TabIndex = 3;
            this.panelAddEmployee.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAddEmployee_MouseDown);
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
            // lblAddEmployee
            // 
            this.lblAddEmployee.AutoSize = true;
            this.lblAddEmployee.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblAddEmployee.Location = new System.Drawing.Point(247, 23);
            this.lblAddEmployee.Name = "lblAddEmployee";
            this.lblAddEmployee.Size = new System.Drawing.Size(266, 35);
            this.lblAddEmployee.TabIndex = 0;
            this.lblAddEmployee.Text = "Add New Employee";
            this.lblAddEmployee.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblAddEmployee_MouseDown);
            // 
            // gBoxRegistration
            // 
            this.gBoxRegistration.Controls.Add(this.positionBox);
            this.gBoxRegistration.Controls.Add(this.txtFile);
            this.gBoxRegistration.Controls.Add(this.lblUpload);
            this.gBoxRegistration.Controls.Add(this.pictureBox1);
            this.gBoxRegistration.Controls.Add(this.btnUpload);
            this.gBoxRegistration.Controls.Add(this.lblUploading);
            this.gBoxRegistration.Controls.Add(this.txtSalaryModifire);
            this.gBoxRegistration.Controls.Add(this.panel7);
            this.gBoxRegistration.Controls.Add(this.lblSalaryModifire);
            this.gBoxRegistration.Controls.Add(this.txtBaseSalary);
            this.gBoxRegistration.Controls.Add(this.panel8);
            this.gBoxRegistration.Controls.Add(this.lblBaseSalary);
            this.gBoxRegistration.Controls.Add(this.panel9);
            this.gBoxRegistration.Controls.Add(this.lblPosition);
            this.gBoxRegistration.Controls.Add(this.txtPhone);
            this.gBoxRegistration.Controls.Add(this.panel10);
            this.gBoxRegistration.Controls.Add(this.lblPhone);
            this.gBoxRegistration.Controls.Add(this.txtAddres);
            this.gBoxRegistration.Controls.Add(this.panel11);
            this.gBoxRegistration.Controls.Add(this.lblAddres);
            this.gBoxRegistration.Controls.Add(this.txtDateOfBirth);
            this.gBoxRegistration.Controls.Add(this.panel12);
            this.gBoxRegistration.Controls.Add(this.lblDateOfBirth);
            this.gBoxRegistration.Controls.Add(this.txtGender);
            this.gBoxRegistration.Controls.Add(this.panel4);
            this.gBoxRegistration.Controls.Add(this.lblGender);
            this.gBoxRegistration.Controls.Add(this.txtEmail);
            this.gBoxRegistration.Controls.Add(this.panel5);
            this.gBoxRegistration.Controls.Add(this.lblEmail);
            this.gBoxRegistration.Controls.Add(this.txtMiddleName);
            this.gBoxRegistration.Controls.Add(this.panel6);
            this.gBoxRegistration.Controls.Add(this.lblMiddleName);
            this.gBoxRegistration.Controls.Add(this.txtLastName);
            this.gBoxRegistration.Controls.Add(this.panel3);
            this.gBoxRegistration.Controls.Add(this.lblLName);
            this.gBoxRegistration.Controls.Add(this.txtFirstName);
            this.gBoxRegistration.Controls.Add(this.panel2);
            this.gBoxRegistration.Controls.Add(this.lblFirstName);
            this.gBoxRegistration.Controls.Add(this.txtID);
            this.gBoxRegistration.Controls.Add(this.panel1);
            this.gBoxRegistration.Controls.Add(this.lblID);
            this.gBoxRegistration.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gBoxRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.gBoxRegistration.Location = new System.Drawing.Point(12, 91);
            this.gBoxRegistration.Name = "gBoxRegistration";
            this.gBoxRegistration.Size = new System.Drawing.Size(657, 266);
            this.gBoxRegistration.TabIndex = 4;
            this.gBoxRegistration.TabStop = false;
            this.gBoxRegistration.Text = "Registration";
            // 
            // positionBox
            // 
            this.positionBox.FormattingEnabled = true;
            this.positionBox.Items.AddRange(new object[] {
            "HR_Boss",
            "HR_Grunt",
            "IT_Boss",
            "IT_Grunt",
            "Maintenance_Boss",
            "Mechanic",
            "Worker",
            "Suplementary"});
            this.positionBox.Location = new System.Drawing.Point(275, 133);
            this.positionBox.Name = "positionBox";
            this.positionBox.Size = new System.Drawing.Size(102, 24);
            this.positionBox.TabIndex = 41;
            // 
            // txtFile
            // 
            this.txtFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFile.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtFile.Location = new System.Drawing.Point(452, 69);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(155, 17);
            this.txtFile.TabIndex = 40;
            // 
            // lblUpload
            // 
            this.lblUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblUpload.Location = new System.Drawing.Point(446, 88);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(170, 1);
            this.lblUpload.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(452, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnUpload.Location = new System.Drawing.Point(482, 40);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpload.Size = new System.Drawing.Size(98, 26);
            this.btnUpload.TabIndex = 37;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
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
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel7.Location = new System.Drawing.Point(202, 229);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(170, 1);
            this.panel7.TabIndex = 34;
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
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel8.Location = new System.Drawing.Point(202, 191);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(170, 1);
            this.panel8.TabIndex = 31;
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
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel9.Location = new System.Drawing.Point(202, 155);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(170, 1);
            this.panel9.TabIndex = 28;
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
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel10.Location = new System.Drawing.Point(202, 122);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(170, 1);
            this.panel10.TabIndex = 25;
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
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel11.Location = new System.Drawing.Point(202, 84);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(170, 1);
            this.panel11.TabIndex = 22;
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
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel12.Location = new System.Drawing.Point(202, 48);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(170, 1);
            this.panel12.TabIndex = 19;
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel4.Location = new System.Drawing.Point(15, 229);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(170, 1);
            this.panel4.TabIndex = 16;
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel5.Location = new System.Drawing.Point(15, 191);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(170, 1);
            this.panel5.TabIndex = 13;
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
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel6.Location = new System.Drawing.Point(15, 155);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(170, 1);
            this.panel6.TabIndex = 10;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel3.Location = new System.Drawing.Point(15, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 1);
            this.panel3.TabIndex = 7;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel2.Location = new System.Drawing.Point(15, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 1);
            this.panel2.TabIndex = 4;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel1.Location = new System.Drawing.Point(15, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 1);
            this.panel1.TabIndex = 1;
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
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSave.Location = new System.Drawing.Point(247, 387);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSave.Size = new System.Drawing.Size(98, 26);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnClear.Location = new System.Drawing.Point(382, 387);
            this.btnClear.Name = "btnClear";
            this.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClear.Size = new System.Drawing.Size(98, 26);
            this.btnClear.TabIndex = 39;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // addEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gBoxRegistration);
            this.Controls.Add(this.panelAddEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addEmployee";
            this.Text = "addEmployee";
            this.panelAddEmployee.ResumeLayout(false);
            this.panelAddEmployee.PerformLayout();
            this.gBoxRegistration.ResumeLayout(false);
            this.gBoxRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelAddEmployee;
        private Label lblAddEmployee;
        private GroupBox gBoxRegistration;
        private TextBox txtID;
        private Panel panel1;
        private Label lblID;
        private TextBox txtGender;
        private Panel panel4;
        private Label lblGender;
        private TextBox txtEmail;
        private Panel panel5;
        private Label lblEmail;
        private TextBox txtMiddleName;
        private Panel panel6;
        private Label lblMiddleName;
        private TextBox txtLastName;
        private Panel panel3;
        private Label lblLName;
        private TextBox txtFirstName;
        private Panel panel2;
        private Label lblFirstName;
        private Label lblUploading;
        private TextBox txtSalaryModifire;
        private Panel panel7;
        private Label lblSalaryModifire;
        private TextBox txtBaseSalary;
        private Panel panel8;
        private Label lblBaseSalary;
        private Panel panel9;
        private Label lblPosition;
        private TextBox txtPhone;
        private Panel panel10;
        private Label lblPhone;
        private TextBox txtAddres;
        private Panel panel11;
        private Label lblAddres;
        private TextBox txtDateOfBirth;
        private Panel panel12;
        private Label lblDateOfBirth;
        private Button btnX;
        private TextBox txtFile;
        private Panel lblUpload;
        private PictureBox pictureBox1;
        private Button btnUpload;
        private Button btnSave;
        private Button btnClear;
        private ComboBox positionBox;
    }
}