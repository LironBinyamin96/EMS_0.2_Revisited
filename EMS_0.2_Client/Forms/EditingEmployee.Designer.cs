namespace EMS_Client.Forms
{
    partial class EditingEmployee
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
            this.panelEditingEmployee = new System.Windows.Forms.Panel();
            this.lblEditingEmployee = new System.Windows.Forms.Label();
            this.btnNewWorker = new RJCodeAdvance.RJControls.RJButton();
            this.rjbtnUpdatePersonalDetails = new RJCodeAdvance.RJControls.RJButton();
            this.panelEditingEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEditingEmployee
            // 
            this.panelEditingEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelEditingEmployee.Controls.Add(this.lblEditingEmployee);
            this.panelEditingEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEditingEmployee.Location = new System.Drawing.Point(0, 0);
            this.panelEditingEmployee.Name = "panelEditingEmployee";
            this.panelEditingEmployee.Size = new System.Drawing.Size(800, 85);
            this.panelEditingEmployee.TabIndex = 0;
            // 
            // lblEditingEmployee
            // 
            this.lblEditingEmployee.AutoSize = true;
            this.lblEditingEmployee.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEditingEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblEditingEmployee.Location = new System.Drawing.Point(254, 26);
            this.lblEditingEmployee.Name = "lblEditingEmployee";
            this.lblEditingEmployee.Size = new System.Drawing.Size(238, 35);
            this.lblEditingEmployee.TabIndex = 0;
            this.lblEditingEmployee.Text = "Editing Employee";
            // 
            // btnNewWorker
            // 
            this.btnNewWorker.BackColor = System.Drawing.Color.Transparent;
            this.btnNewWorker.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnNewWorker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnNewWorker.BorderRadius = 20;
            this.btnNewWorker.BorderSize = 2;
            this.btnNewWorker.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnNewWorker.FlatAppearance.BorderSize = 2;
            this.btnNewWorker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnNewWorker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNewWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewWorker.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewWorker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnNewWorker.Location = new System.Drawing.Point(235, 161);
            this.btnNewWorker.Name = "btnNewWorker";
            this.btnNewWorker.Size = new System.Drawing.Size(266, 46);
            this.btnNewWorker.TabIndex = 3;
            this.btnNewWorker.Text = "Add New Worker";
            this.btnNewWorker.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnNewWorker.UseVisualStyleBackColor = false;
            this.btnNewWorker.Click += new System.EventHandler(this.btnNewWorker_Click);
            // 
            // rjbtnUpdatePersonalDetails
            // 
            this.rjbtnUpdatePersonalDetails.BackColor = System.Drawing.Color.Transparent;
            this.rjbtnUpdatePersonalDetails.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjbtnUpdatePersonalDetails.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.rjbtnUpdatePersonalDetails.BorderRadius = 20;
            this.rjbtnUpdatePersonalDetails.BorderSize = 2;
            this.rjbtnUpdatePersonalDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.rjbtnUpdatePersonalDetails.FlatAppearance.BorderSize = 2;
            this.rjbtnUpdatePersonalDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.rjbtnUpdatePersonalDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rjbtnUpdatePersonalDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnUpdatePersonalDetails.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjbtnUpdatePersonalDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.rjbtnUpdatePersonalDetails.Location = new System.Drawing.Point(235, 266);
            this.rjbtnUpdatePersonalDetails.Name = "rjbtnUpdatePersonalDetails";
            this.rjbtnUpdatePersonalDetails.Size = new System.Drawing.Size(266, 46);
            this.rjbtnUpdatePersonalDetails.TabIndex = 4;
            this.rjbtnUpdatePersonalDetails.Text = "Update Personal Details";
            this.rjbtnUpdatePersonalDetails.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.rjbtnUpdatePersonalDetails.UseVisualStyleBackColor = false;
            this.rjbtnUpdatePersonalDetails.Click += new System.EventHandler(this.rjbtnUpdatePersonalDetails_Click);
            // 
            // EditingEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rjbtnUpdatePersonalDetails);
            this.Controls.Add(this.btnNewWorker);
            this.Controls.Add(this.panelEditingEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditingEmployee";
            this.Text = "EditingEmployee";
            this.panelEditingEmployee.ResumeLayout(false);
            this.panelEditingEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelEditingEmployee;
        private Label lblEditingEmployee;
        private RJCodeAdvance.RJControls.RJButton btnNewWorker;
        private RJCodeAdvance.RJControls.RJButton rjbtnUpdatePersonalDetails;
    }
}