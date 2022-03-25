namespace EMS_Client.Forms
{
    partial class GeneralData
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
            this.panelGeneralData = new System.Windows.Forms.Panel();
            this.lblGeneralData = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.panelWorkerData = new System.Windows.Forms.Panel();
            this.panelData = new System.Windows.Forms.Panel();
            this.lblgraph = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.panelGeneralData.SuspendLayout();
            this.panelWorkerData.SuspendLayout();
            this.panelData.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGeneralData
            // 
            this.panelGeneralData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelGeneralData.Controls.Add(this.lblGeneralData);
            this.panelGeneralData.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGeneralData.Location = new System.Drawing.Point(0, 0);
            this.panelGeneralData.Name = "panelGeneralData";
            this.panelGeneralData.Size = new System.Drawing.Size(844, 85);
            this.panelGeneralData.TabIndex = 2;
            // 
            // lblGeneralData
            // 
            this.lblGeneralData.AutoSize = true;
            this.lblGeneralData.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGeneralData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblGeneralData.Location = new System.Drawing.Point(291, 24);
            this.lblGeneralData.Name = "lblGeneralData";
            this.lblGeneralData.Size = new System.Drawing.Size(183, 35);
            this.lblGeneralData.TabIndex = 0;
            this.lblGeneralData.Text = "General Data";
            // 
            // btnSelect
            // 
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSelect.Location = new System.Drawing.Point(291, 91);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSelect.Size = new System.Drawing.Size(193, 40);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Select an employee";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // panelWorkerData
            // 
            this.panelWorkerData.Controls.Add(this.panelData);
            this.panelWorkerData.Controls.Add(this.lblAvg);
            this.panelWorkerData.Controls.Add(this.lblHours);
            this.panelWorkerData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelWorkerData.Location = new System.Drawing.Point(0, 186);
            this.panelWorkerData.Name = "panelWorkerData";
            this.panelWorkerData.Size = new System.Drawing.Size(844, 451);
            this.panelWorkerData.TabIndex = 4;
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelData.Controls.Add(this.lblgraph);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelData.Location = new System.Drawing.Point(0, 185);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(844, 266);
            this.panelData.TabIndex = 3;
            // 
            // lblgraph
            // 
            this.lblgraph.AutoSize = true;
            this.lblgraph.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblgraph.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblgraph.Location = new System.Drawing.Point(3, 9);
            this.lblgraph.Name = "lblgraph";
            this.lblgraph.Size = new System.Drawing.Size(163, 19);
            this.lblgraph.TabIndex = 2;
            this.lblgraph.Text = "Monthly hours graph:";
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAvg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblAvg.Location = new System.Drawing.Point(36, 61);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(74, 19);
            this.lblAvg.TabIndex = 2;
            this.lblAvg.Text = "Average:";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblHours.Location = new System.Drawing.Point(36, 26);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(158, 19);
            this.lblHours.TabIndex = 1;
            this.lblHours.Text = "Curent month hours:";
            // 
            // GeneralData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(844, 637);
            this.Controls.Add(this.panelWorkerData);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.panelGeneralData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GeneralData";
            this.Text = "GeneralData";
            this.panelGeneralData.ResumeLayout(false);
            this.panelGeneralData.PerformLayout();
            this.panelWorkerData.ResumeLayout(false);
            this.panelWorkerData.PerformLayout();
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelGeneralData;
        private Label lblGeneralData;
        private Button btnSelect;
        private Panel panelWorkerData;
        private Label lblAvg;
        private Label lblHours;
        private Panel panelData;
        private Label lblgraph;
    }
}