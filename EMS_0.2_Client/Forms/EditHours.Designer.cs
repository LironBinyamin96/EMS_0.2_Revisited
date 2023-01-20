namespace EMS_Client.Forms
{
    partial class EditHours
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
            this.panelEditHours = new System.Windows.Forms.Panel();
            this.btnX = new System.Windows.Forms.Button();
            this.lblEditHours = new System.Windows.Forms.Label();
            this.dateTimeEntey = new System.Windows.Forms.DateTimePicker();
            this.dateTimeExit = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new RJCodeAdvance.RJControls.RJButton();
            this.radioEntry = new RJCodeAdvance.RJControls.RJRadioButton();
            this.radioExit = new RJCodeAdvance.RJControls.RJRadioButton();
            this.panelEditHours.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEditHours
            // 
            this.panelEditHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelEditHours.Controls.Add(this.btnX);
            this.panelEditHours.Controls.Add(this.lblEditHours);
            this.panelEditHours.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEditHours.Location = new System.Drawing.Point(0, 0);
            this.panelEditHours.Name = "panelEditHours";
            this.panelEditHours.Size = new System.Drawing.Size(515, 96);
            this.panelEditHours.TabIndex = 3;
            this.panelEditHours.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelEditHours_MouseDown);
            // 
            // btnX
            // 
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnX.Location = new System.Drawing.Point(486, 3);
            this.btnX.Name = "btnX";
            this.btnX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnX.Size = new System.Drawing.Size(23, 27);
            this.btnX.TabIndex = 42;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // lblEditHours
            // 
            this.lblEditHours.AutoSize = true;
            this.lblEditHours.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEditHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblEditHours.Location = new System.Drawing.Point(191, 30);
            this.lblEditHours.Name = "lblEditHours";
            this.lblEditHours.Size = new System.Drawing.Size(151, 35);
            this.lblEditHours.TabIndex = 0;
            this.lblEditHours.Text = "Edit Hours";
            // 
            // dateTimeEntey
            // 
            this.dateTimeEntey.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimeEntey.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimeEntey.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimeEntey.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEntey.Location = new System.Drawing.Point(198, 145);
            this.dateTimeEntey.MaxDate = new System.DateTime(2023, 1, 9, 20, 24, 7, 449);
            this.dateTimeEntey.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimeEntey.Name = "dateTimeEntey";
            this.dateTimeEntey.ShowUpDown = true;
            this.dateTimeEntey.Size = new System.Drawing.Size(158, 23);
            this.dateTimeEntey.TabIndex = 42;
            this.dateTimeEntey.Value = new System.DateTime(2023, 1, 9, 20, 24, 7, 449);
            // 
            // dateTimeExit
            // 
            this.dateTimeExit.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimeExit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeExit.Location = new System.Drawing.Point(198, 187);
            this.dateTimeExit.Name = "dateTimeExit";
            this.dateTimeExit.ShowUpDown = true;
            this.dateTimeExit.Size = new System.Drawing.Size(158, 23);
            this.dateTimeExit.TabIndex = 43;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSave.BorderRadius = 17;
            this.btnSave.BorderSize = 2;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSave.Location = new System.Drawing.Point(210, 268);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 38);
            this.btnSave.TabIndex = 52;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // radioEntry
            // 
            this.radioEntry.AutoSize = true;
            this.radioEntry.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.radioEntry.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioEntry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.radioEntry.Location = new System.Drawing.Point(126, 148);
            this.radioEntry.MinimumSize = new System.Drawing.Size(0, 21);
            this.radioEntry.Name = "radioEntry";
            this.radioEntry.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioEntry.Size = new System.Drawing.Size(70, 21);
            this.radioEntry.TabIndex = 53;
            this.radioEntry.TabStop = true;
            this.radioEntry.Text = "Entry";
            this.radioEntry.UnCheckedColor = System.Drawing.Color.Gray;
            this.radioEntry.UseVisualStyleBackColor = true;
            this.radioEntry.CheckedChanged += new System.EventHandler(this.radioEntry_CheckedChanged);
            // 
            // radioExit
            // 
            this.radioExit.AutoSize = true;
            this.radioExit.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.radioExit.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.radioExit.Location = new System.Drawing.Point(126, 187);
            this.radioExit.MinimumSize = new System.Drawing.Size(0, 21);
            this.radioExit.Name = "radioExit";
            this.radioExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioExit.Size = new System.Drawing.Size(60, 21);
            this.radioExit.TabIndex = 54;
            this.radioExit.TabStop = true;
            this.radioExit.Text = "Exit";
            this.radioExit.UnCheckedColor = System.Drawing.Color.Gray;
            this.radioExit.UseVisualStyleBackColor = true;
            // 
            // EditHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(515, 369);
            this.Controls.Add(this.radioExit);
            this.Controls.Add(this.radioEntry);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dateTimeExit);
            this.Controls.Add(this.dateTimeEntey);
            this.Controls.Add(this.panelEditHours);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditHours";
            this.Text = "Form1";
            this.panelEditHours.ResumeLayout(false);
            this.panelEditHours.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelEditHours;
        private Label lblEditHours;
        private Button btnX;
        private DateTimePicker dateTimeEntey;
        private DateTimePicker dateTimeExit;
        private RJCodeAdvance.RJControls.RJButton btnSave;
        private RJCodeAdvance.RJControls.RJRadioButton radioEntry;
        private RJCodeAdvance.RJControls.RJRadioButton radioExit;
    }
}