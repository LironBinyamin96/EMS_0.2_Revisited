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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEntry = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateTimeEntey = new System.Windows.Forms.DateTimePicker();
            this.dateTimeExit = new System.Windows.Forms.DateTimePicker();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel2.Location = new System.Drawing.Point(157, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 10;
            // 
            // lblEntry
            // 
            this.lblEntry.AutoSize = true;
            this.lblEntry.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEntry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblEntry.Location = new System.Drawing.Point(157, 130);
            this.lblEntry.Name = "lblEntry";
            this.lblEntry.Size = new System.Drawing.Size(45, 18);
            this.lblEntry.TabIndex = 9;
            this.lblEntry.Text = "Entry :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel3.Location = new System.Drawing.Point(157, 217);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 13;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblExit.Location = new System.Drawing.Point(157, 200);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(36, 18);
            this.lblExit.TabIndex = 12;
            this.lblExit.Text = "Exit :";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSave.Location = new System.Drawing.Point(212, 308);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSave.Size = new System.Drawing.Size(98, 26);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateTimeEntey
            // 
            this.dateTimeEntey.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimeEntey.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEntey.Location = new System.Drawing.Point(199, 125);
            this.dateTimeEntey.Name = "dateTimeEntey";
            this.dateTimeEntey.ShowUpDown = true;
            this.dateTimeEntey.Size = new System.Drawing.Size(158, 23);
            this.dateTimeEntey.TabIndex = 42;
            this.dateTimeEntey.MaxDate = DateTime.Now;
            this.dateTimeEntey.MinDate = EMS_Library.Config.MinDate;
            // 
            // dateTimeExit
            // 
            this.dateTimeExit.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimeExit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeExit.Location = new System.Drawing.Point(199, 194);
            this.dateTimeExit.Name = "dateTimeExit";
            this.dateTimeExit.ShowUpDown = true;
            this.dateTimeExit.Size = new System.Drawing.Size(158, 23);
            this.dateTimeExit.TabIndex = 43;
            this.dateTimeEntey.MaxDate = DateTime.Now;
            this.dateTimeEntey.MinDate = EMS_Library.Config.MinDate;
            // 
            // EditHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(515, 369);
            this.Controls.Add(this.dateTimeExit);
            this.Controls.Add(this.dateTimeEntey);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblEntry);
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
        private Panel panel2;
        private Label lblEntry;
        private Panel panel3;
        private Label lblExit;
        private Button btnSave;
        private DateTimePicker dateTimeEntey;
        private DateTimePicker dateTimeExit;
    }
}