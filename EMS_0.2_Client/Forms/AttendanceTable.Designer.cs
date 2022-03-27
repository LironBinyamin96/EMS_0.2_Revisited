namespace EMS_Client.Forms
{
    partial class AttendanceTable
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
            this.panelAttendance = new System.Windows.Forms.Panel();
            this.lblAttendance = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.GridViewAttrndance = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clock_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount_of_hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEmployeename = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMonth = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.panelAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewAttrndance)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAttendance
            // 
            this.panelAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelAttendance.Controls.Add(this.lblAttendance);
            this.panelAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAttendance.Location = new System.Drawing.Point(0, 0);
            this.panelAttendance.Name = "panelAttendance";
            this.panelAttendance.Size = new System.Drawing.Size(758, 96);
            this.panelAttendance.TabIndex = 2;
            // 
            // lblAttendance
            // 
            this.lblAttendance.AutoSize = true;
            this.lblAttendance.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAttendance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblAttendance.Location = new System.Drawing.Point(282, 25);
            this.lblAttendance.Name = "lblAttendance";
            this.lblAttendance.Size = new System.Drawing.Size(161, 35);
            this.lblAttendance.TabIndex = 0;
            this.lblAttendance.Text = "Attendance";
            // 
            // btnSelect
            // 
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSelect.Location = new System.Drawing.Point(271, 102);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSelect.Size = new System.Drawing.Size(172, 30);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "Select an employee";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // GridViewAttrndance
            // 
            this.GridViewAttrndance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewAttrndance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.GridViewAttrndance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridViewAttrndance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewAttrndance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Day,
            this.Clock_data,
            this.Amount_of_hours});
            this.GridViewAttrndance.Location = new System.Drawing.Point(12, 185);
            this.GridViewAttrndance.Name = "GridViewAttrndance";
            this.GridViewAttrndance.ReadOnly = true;
            this.GridViewAttrndance.RowTemplate.Height = 25;
            this.GridViewAttrndance.Size = new System.Drawing.Size(734, 378);
            this.GridViewAttrndance.TabIndex = 5;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Day
            // 
            this.Day.HeaderText = "Day";
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            // 
            // Clock_data
            // 
            this.Clock_data.HeaderText = "Clock data";
            this.Clock_data.Name = "Clock_data";
            this.Clock_data.ReadOnly = true;
            // 
            // Amount_of_hours
            // 
            this.Amount_of_hours.HeaderText = "Amount of hours";
            this.Amount_of_hours.Name = "Amount_of_hours";
            this.Amount_of_hours.ReadOnly = true;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtName.Location = new System.Drawing.Point(126, 153);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 16);
            this.txtName.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel1.Location = new System.Drawing.Point(14, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 1);
            this.panel1.TabIndex = 7;
            // 
            // lblEmployeename
            // 
            this.lblEmployeename.AutoSize = true;
            this.lblEmployeename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblEmployeename.Location = new System.Drawing.Point(14, 156);
            this.lblEmployeename.Name = "lblEmployeename";
            this.lblEmployeename.Size = new System.Drawing.Size(106, 15);
            this.lblEmployeename.TabIndex = 6;
            this.lblEmployeename.Text = "Employee\'s name :";
            // 
            // txtMonth
            // 
            this.txtMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtMonth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonth.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtMonth.Location = new System.Drawing.Point(486, 157);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(90, 16);
            this.txtMonth.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel2.Location = new System.Drawing.Point(440, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(124, 1);
            this.panel2.TabIndex = 10;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblMonth.Location = new System.Drawing.Point(440, 159);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(49, 15);
            this.lblMonth.TabIndex = 9;
            this.lblMonth.Text = "Month :";
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYear.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtYear.Location = new System.Drawing.Point(651, 156);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(90, 16);
            this.txtYear.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel3.Location = new System.Drawing.Point(610, 174);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(124, 1);
            this.panel3.TabIndex = 13;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblYear.Location = new System.Drawing.Point(610, 158);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(35, 15);
            this.lblYear.TabIndex = 12;
            this.lblYear.Text = "Year :";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtID.Location = new System.Drawing.Point(305, 157);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(94, 16);
            this.txtID.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel4.Location = new System.Drawing.Point(275, 174);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(124, 1);
            this.panel4.TabIndex = 16;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblID.Location = new System.Drawing.Point(275, 158);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 15);
            this.lblID.TabIndex = 15;
            this.lblID.Text = "ID :";
            // 
            // AttendanceTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(758, 575);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEmployeename);
            this.Controls.Add(this.GridViewAttrndance);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.panelAttendance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AttendanceTable";
            this.Text = "AttendanceTable";
            this.Activated += new System.EventHandler(this.AttendanceTable_Activated);
            this.panelAttendance.ResumeLayout(false);
            this.panelAttendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewAttrndance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelAttendance;
        private Label lblAttendance;
        private Button btnSelect;
        private DataGridView GridViewAttrndance;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Day;
        private DataGridViewTextBoxColumn Clock_data;
        private DataGridViewTextBoxColumn Amount_of_hours;
        private TextBox txtName;
        private Panel panel1;
        private Label lblEmployeename;
        private TextBox txtMonth;
        private Panel panel2;
        private Label lblMonth;
        private TextBox txtYear;
        private Panel panel3;
        private Label lblYear;
        private TextBox txtID;
        private Panel panel4;
        private Label lblID;
    }
}