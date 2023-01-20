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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelAttendance = new System.Windows.Forms.Panel();
            this.lblAttendance = new System.Windows.Forms.Label();
            this.GridViewAttrndance = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getDaysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEmployeename = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMonth = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.hoursLogMonthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.hoursLogMonthBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hoursLogMonthBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hoursLogMonthBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.lblNoData = new System.Windows.Forms.Label();
            this.btnSelect = new RJCodeAdvance.RJControls.RJButton();
            this.btnHoursReport = new RJCodeAdvance.RJControls.RJButton();
            this.btnExceptions = new RJCodeAdvance.RJControls.RJButton();
            this.btnShowHours = new RJCodeAdvance.RJControls.RJButton();
            this.panelAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewAttrndance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDaysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursLogMonthBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursLogMonthBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursLogMonthBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursLogMonthBindingSource3)).BeginInit();
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
            // GridViewAttrndance
            // 
            this.GridViewAttrndance.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.GridViewAttrndance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridViewAttrndance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewAttrndance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.GridViewAttrndance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridViewAttrndance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewAttrndance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridViewAttrndance.ColumnHeadersHeight = 30;
            this.GridViewAttrndance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridViewAttrndance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.Day,
            this.Entry,
            this.Exit,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.total_hours});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewAttrndance.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridViewAttrndance.EnableHeadersVisualStyles = false;
            this.GridViewAttrndance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.GridViewAttrndance.Location = new System.Drawing.Point(12, 185);
            this.GridViewAttrndance.Name = "GridViewAttrndance";
            this.GridViewAttrndance.ReadOnly = true;
            this.GridViewAttrndance.RowHeadersVisible = false;
            this.GridViewAttrndance.RowHeadersWidth = 30;
            this.GridViewAttrndance.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridViewAttrndance.RowTemplate.Height = 25;
            this.GridViewAttrndance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewAttrndance.Size = new System.Drawing.Size(734, 378);
            this.GridViewAttrndance.TabIndex = 5;
            this.GridViewAttrndance.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridViewAttrndance_CellMouseDoubleClick);
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // Day
            // 
            this.Day.HeaderText = "Day";
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            // 
            // Entry
            // 
            this.Entry.HeaderText = "Entry";
            this.Entry.Name = "Entry";
            this.Entry.ReadOnly = true;
            // 
            // Exit
            // 
            this.Exit.HeaderText = "Exit";
            this.Exit.Name = "Exit";
            this.Exit.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Entry";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Exit";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Entry";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Exit";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // total_hours
            // 
            this.total_hours.HeaderText = "Total hours";
            this.total_hours.Name = "total_hours";
            this.total_hours.ReadOnly = true;
            // 
            // getDaysBindingSource
            // 
            this.getDaysBindingSource.DataMember = "GetDays";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel2.Location = new System.Drawing.Point(440, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 1);
            this.panel2.TabIndex = 10;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblMonth.Location = new System.Drawing.Point(440, 159);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(97, 15);
            this.lblMonth.TabIndex = 9;
            this.lblMonth.Text = "Month and year :";
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
            // hoursLogMonthBindingSource
            // 
            this.hoursLogMonthBindingSource.DataSource = typeof(EMS_Library.MyEmployee.HoursLog.HoursLogMonth);
            // 
            // dateTime
            // 
            this.dateTime.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTime.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.dateTime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dateTime.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.dateTime.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.dateTime.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.dateTime.CustomFormat = "MM/yyyy";
            this.dateTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime.Location = new System.Drawing.Point(536, 148);
            this.dateTime.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateTime.MinDate = new System.DateTime(1990, 12, 31, 0, 0, 0, 0);
            this.dateTime.Name = "dateTime";
            this.dateTime.ShowUpDown = true;
            this.dateTime.Size = new System.Drawing.Size(78, 25);
            this.dateTime.TabIndex = 19;
            this.dateTime.Value = new System.DateTime(2023, 1, 13, 23, 36, 49, 128);
            // 
            // hoursLogMonthBindingSource1
            // 
            this.hoursLogMonthBindingSource1.DataSource = typeof(EMS_Library.MyEmployee.HoursLog.HoursLogMonth);
            // 
            // hoursLogMonthBindingSource2
            // 
            this.hoursLogMonthBindingSource2.DataSource = typeof(EMS_Library.MyEmployee.HoursLog.HoursLogMonth);
            // 
            // hoursLogMonthBindingSource3
            // 
            this.hoursLogMonthBindingSource3.DataSource = typeof(EMS_Library.MyEmployee.HoursLog.HoursLogMonth);
            // 
            // lblNoData
            // 
            this.lblNoData.AutoSize = true;
            this.lblNoData.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNoData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblNoData.Location = new System.Drawing.Point(271, 228);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(195, 35);
            this.lblNoData.TabIndex = 22;
            this.lblNoData.Text = "No data found";
            this.lblNoData.Visible = false;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSelect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSelect.BorderRadius = 17;
            this.btnSelect.BorderSize = 2;
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSelect.FlatAppearance.BorderSize = 2;
            this.btnSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSelect.Location = new System.Drawing.Point(271, 99);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(185, 37);
            this.btnSelect.TabIndex = 51;
            this.btnSelect.Text = "Select an employee";
            this.btnSelect.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnHoursReport
            // 
            this.btnHoursReport.BackColor = System.Drawing.Color.Transparent;
            this.btnHoursReport.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnHoursReport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnHoursReport.BorderRadius = 17;
            this.btnHoursReport.BorderSize = 2;
            this.btnHoursReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnHoursReport.FlatAppearance.BorderSize = 2;
            this.btnHoursReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnHoursReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnHoursReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoursReport.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHoursReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnHoursReport.Location = new System.Drawing.Point(561, 99);
            this.btnHoursReport.Name = "btnHoursReport";
            this.btnHoursReport.Size = new System.Drawing.Size(185, 37);
            this.btnHoursReport.TabIndex = 52;
            this.btnHoursReport.Text = "View hours report";
            this.btnHoursReport.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnHoursReport.UseVisualStyleBackColor = false;
            this.btnHoursReport.Click += new System.EventHandler(this.btnHoursReport_Click);
            // 
            // btnExceptions
            // 
            this.btnExceptions.BackColor = System.Drawing.Color.Transparent;
            this.btnExceptions.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnExceptions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnExceptions.BorderRadius = 17;
            this.btnExceptions.BorderSize = 2;
            this.btnExceptions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnExceptions.FlatAppearance.BorderSize = 2;
            this.btnExceptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnExceptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnExceptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExceptions.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExceptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnExceptions.Location = new System.Drawing.Point(8, 100);
            this.btnExceptions.Name = "btnExceptions";
            this.btnExceptions.Size = new System.Drawing.Size(142, 32);
            this.btnExceptions.TabIndex = 53;
            this.btnExceptions.Text = "View exceptions";
            this.btnExceptions.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnExceptions.UseVisualStyleBackColor = false;
            this.btnExceptions.Click += new System.EventHandler(this.btnExceptions_Click);
            // 
            // btnShowHours
            // 
            this.btnShowHours.BackColor = System.Drawing.Color.Transparent;
            this.btnShowHours.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnShowHours.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnShowHours.BorderRadius = 15;
            this.btnShowHours.BorderSize = 2;
            this.btnShowHours.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnShowHours.FlatAppearance.BorderSize = 2;
            this.btnShowHours.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnShowHours.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnShowHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowHours.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShowHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnShowHours.Location = new System.Drawing.Point(632, 147);
            this.btnShowHours.Name = "btnShowHours";
            this.btnShowHours.Size = new System.Drawing.Size(114, 32);
            this.btnShowHours.TabIndex = 54;
            this.btnShowHours.Text = "Show hours";
            this.btnShowHours.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnShowHours.UseVisualStyleBackColor = false;
            this.btnShowHours.Click += new System.EventHandler(this.btnShowHours_Click);
            // 
            // AttendanceTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(758, 575);
            this.Controls.Add(this.btnShowHours);
            this.Controls.Add(this.btnExceptions);
            this.Controls.Add(this.btnHoursReport);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblNoData);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEmployeename);
            this.Controls.Add(this.GridViewAttrndance);
            this.Controls.Add(this.panelAttendance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AttendanceTable";
            this.Text = "AttendanceTable";
            this.Load += new System.EventHandler(this.AttendanceTable_Load);
            this.panelAttendance.ResumeLayout(false);
            this.panelAttendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewAttrndance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDaysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursLogMonthBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursLogMonthBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursLogMonthBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursLogMonthBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelAttendance;
        private Label lblAttendance;
        private DataGridView GridViewAttrndance;
        private TextBox txtName;
        private Panel panel1;
        private Label lblEmployeename;
        private Panel panel2;
        private Label lblMonth;
        private TextBox txtID;
        private Panel panel4;
        private Label lblID;
        private BindingSource getDaysBindingSource;
        private BindingSource hoursLogMonthBindingSource;
        public DateTimePicker dateTime;
        private BindingSource hoursLogMonthBindingSource1;
        private BindingSource hoursLogMonthBindingSource2;
        private BindingSource hoursLogMonthBindingSource3;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn Day;
        private DataGridViewTextBoxColumn Entry;
        private DataGridViewTextBoxColumn Exit;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn total_hours;
        private Label lblNoData;
        private RJCodeAdvance.RJControls.RJButton btnSelect;
        private RJCodeAdvance.RJControls.RJButton btnHoursReport;
        private RJCodeAdvance.RJControls.RJButton btnExceptions;
        private RJCodeAdvance.RJControls.RJButton btnShowHours;
    }
}