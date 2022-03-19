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
            this.panelAttendance.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAttendance
            // 
            this.panelAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelAttendance.Controls.Add(this.lblAttendance);
            this.panelAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAttendance.Location = new System.Drawing.Point(0, 0);
            this.panelAttendance.Name = "panelAttendance";
            this.panelAttendance.Size = new System.Drawing.Size(800, 85);
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
            this.btnSelect.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSelect.Location = new System.Drawing.Point(42, 91);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSelect.Size = new System.Drawing.Size(193, 40);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "Select an employee";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // AttendanceTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.panelAttendance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AttendanceTable";
            this.Text = "AttendanceTable";
            this.panelAttendance.ResumeLayout(false);
            this.panelAttendance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelAttendance;
        private Label lblAttendance;
        private Button btnSelect;
    }
}