namespace EMS_Client.Forms
{
    partial class selectEmployee
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
            this.panelSelectEmployee = new System.Windows.Forms.Panel();
            this.btnX = new System.Windows.Forms.Button();
            this.lblSelectEmployee = new System.Windows.Forms.Label();
            this.btnSaerch = new System.Windows.Forms.Button();
            this.txtSaerch = new System.Windows.Forms.TextBox();
            this.lblUpload = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.employeesTable = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaryModifire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxSelect = new System.Windows.Forms.ComboBox();
            this.panelSelectEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSelectEmployee
            // 
            this.panelSelectEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelSelectEmployee.Controls.Add(this.btnX);
            this.panelSelectEmployee.Controls.Add(this.lblSelectEmployee);
            this.panelSelectEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSelectEmployee.Location = new System.Drawing.Point(0, 0);
            this.panelSelectEmployee.Name = "panelSelectEmployee";
            this.panelSelectEmployee.Size = new System.Drawing.Size(876, 85);
            this.panelSelectEmployee.TabIndex = 2;
            this.panelSelectEmployee.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSelectEmployee_MouseDown);
            // 
            // btnX
            // 
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnX.Location = new System.Drawing.Point(838, 4);
            this.btnX.Name = "btnX";
            this.btnX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnX.Size = new System.Drawing.Size(23, 27);
            this.btnX.TabIndex = 42;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // lblSelectEmployee
            // 
            this.lblSelectEmployee.AutoSize = true;
            this.lblSelectEmployee.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblSelectEmployee.Location = new System.Drawing.Point(272, 22);
            this.lblSelectEmployee.Name = "lblSelectEmployee";
            this.lblSelectEmployee.Size = new System.Drawing.Size(231, 35);
            this.lblSelectEmployee.TabIndex = 0;
            this.lblSelectEmployee.Text = "Select Employee";
            this.lblSelectEmployee.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblSelectEmployee_MouseDown);
            // 
            // btnSaerch
            // 
            this.btnSaerch.BackgroundImage = global::EMS_Client.Properties.Resources.icon_search;
            this.btnSaerch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaerch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaerch.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaerch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSaerch.Location = new System.Drawing.Point(548, 91);
            this.btnSaerch.Name = "btnSaerch";
            this.btnSaerch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSaerch.Size = new System.Drawing.Size(31, 25);
            this.btnSaerch.TabIndex = 3;
            this.btnSaerch.UseVisualStyleBackColor = true;
            this.btnSaerch.Click += new System.EventHandler(this.btnSaerch_Click);
            // 
            // txtSaerch
            // 
            this.txtSaerch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtSaerch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSaerch.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtSaerch.Location = new System.Drawing.Point(411, 96);
            this.txtSaerch.Name = "txtSaerch";
            this.txtSaerch.Size = new System.Drawing.Size(136, 16);
            this.txtSaerch.TabIndex = 21;
            // 
            // lblUpload
            // 
            this.lblUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblUpload.Location = new System.Drawing.Point(409, 115);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(170, 1);
            this.lblUpload.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel1.Location = new System.Drawing.Point(409, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 1);
            this.panel1.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel2.Location = new System.Drawing.Point(408, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 25);
            this.panel2.TabIndex = 42;
            // 
            // employeesTable
            // 
            this.employeesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.intID,
            this.StateID,
            this.FirstName,
            this.LastName,
            this.MiddelName,
            this.Email,
            this.Gender,
            this.Birthday,
            this.Position,
            this.BaseSalary,
            this.SalaryModifire,
            this.Phone,
            this.Address});
            this.employeesTable.Location = new System.Drawing.Point(9, 122);
            this.employeesTable.Name = "employeesTable";
            this.employeesTable.ReadOnly = true;
            this.employeesTable.RowTemplate.Height = 25;
            this.employeesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeesTable.Size = new System.Drawing.Size(855, 402);
            this.employeesTable.TabIndex = 43;
            this.employeesTable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.employeesTable_CellMouseDoubleClick);
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // intID
            // 
            this.intID.HeaderText = "int ID";
            this.intID.Name = "intID";
            this.intID.ReadOnly = true;
            // 
            // StateID
            // 
            this.StateID.HeaderText = "ID";
            this.StateID.Name = "StateID";
            this.StateID.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // MiddelName
            // 
            this.MiddelName.HeaderText = "Middel Name";
            this.MiddelName.Name = "MiddelName";
            this.MiddelName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Birthday
            // 
            this.Birthday.HeaderText = "Birthday";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            // 
            // Position
            // 
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // BaseSalary
            // 
            this.BaseSalary.HeaderText = "Base Salary";
            this.BaseSalary.Name = "BaseSalary";
            this.BaseSalary.ReadOnly = true;
            // 
            // SalaryModifire
            // 
            this.SalaryModifire.HeaderText = "Salary Modifire";
            this.SalaryModifire.Name = "SalaryModifire";
            this.SalaryModifire.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone Number";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // comboBoxSelect
            // 
            this.comboBoxSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.comboBoxSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSelect.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.comboBoxSelect.FormattingEnabled = true;
            this.comboBoxSelect.Items.AddRange(new object[] {
            "All",
            "ID",
            "First Name",
            "Last Name",
            "Type"});
            this.comboBoxSelect.Location = new System.Drawing.Point(241, 92);
            this.comboBoxSelect.Name = "comboBoxSelect";
            this.comboBoxSelect.Size = new System.Drawing.Size(147, 24);
            this.comboBoxSelect.TabIndex = 44;
            this.comboBoxSelect.Text = "Selection by details";
            // 
            // selectEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(876, 536);
            this.Controls.Add(this.comboBoxSelect);
            this.Controls.Add(this.employeesTable);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUpload);
            this.Controls.Add(this.txtSaerch);
            this.Controls.Add(this.btnSaerch);
            this.Controls.Add(this.panelSelectEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "selectEmployee";
            this.Text = "selectEmployee";
            this.Load += new System.EventHandler(this.selectEmployee_Load);
            this.panelSelectEmployee.ResumeLayout(false);
            this.panelSelectEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelSelectEmployee;
        private Label lblSelectEmployee;
        private Button btnSaerch;
        private TextBox txtSaerch;
        private Panel lblUpload;
        private Panel panel1;
        private Panel panel2;
        private Button btnX;
        private DataGridView employeesTable;
        private ComboBox comboBoxSelect;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn intID;
        private DataGridViewTextBoxColumn StateID;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn MiddelName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Birthday;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn BaseSalary;
        private DataGridViewTextBoxColumn SalaryModifire;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Address;
    }
}