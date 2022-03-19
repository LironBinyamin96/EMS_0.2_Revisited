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
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.btnUpdatePersonalDetails = new System.Windows.Forms.Button();
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
            // btnAddWorker
            // 
            this.btnAddWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWorker.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddWorker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddWorker.Location = new System.Drawing.Point(228, 152);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddWorker.Size = new System.Drawing.Size(295, 46);
            this.btnAddWorker.TabIndex = 1;
            this.btnAddWorker.Text = "Add New Worker";
            this.btnAddWorker.UseVisualStyleBackColor = true;
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddWorker_Click);
            // 
            // btnUpdatePersonalDetails
            // 
            this.btnUpdatePersonalDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePersonalDetails.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdatePersonalDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnUpdatePersonalDetails.Location = new System.Drawing.Point(228, 251);
            this.btnUpdatePersonalDetails.Name = "btnUpdatePersonalDetails";
            this.btnUpdatePersonalDetails.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdatePersonalDetails.Size = new System.Drawing.Size(295, 46);
            this.btnUpdatePersonalDetails.TabIndex = 2;
            this.btnUpdatePersonalDetails.Text = "Update Personal Details";
            this.btnUpdatePersonalDetails.UseVisualStyleBackColor = true;
            this.btnUpdatePersonalDetails.Click += new System.EventHandler(this.btnUpdatePersonalDetails_Click);
            // 
            // EditingEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdatePersonalDetails);
            this.Controls.Add(this.btnAddWorker);
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
        private Button btnAddWorker;
        private Button btnUpdatePersonalDetails;
    }
}