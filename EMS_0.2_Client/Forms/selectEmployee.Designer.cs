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
            this.components = new System.ComponentModel.Container();
            this.panelSelectEmployee = new System.Windows.Forms.Panel();
            this.btnX = new System.Windows.Forms.Button();
            this.lblSelectEmployee = new System.Windows.Forms.Label();
            this.btnSaerch = new System.Windows.Forms.Button();
            this.txtSaerch = new System.Windows.Forms.TextBox();
            this.lblUpload = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataPacketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelSelectEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPacketBindingSource)).BeginInit();
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
            this.panelSelectEmployee.Size = new System.Drawing.Size(800, 85);
            this.panelSelectEmployee.TabIndex = 2;
            // 
            // btnX
            // 
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnX.Location = new System.Drawing.Point(774, 3);
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
            // 
            // btnSaerch
            // 
            this.btnSaerch.BackgroundImage = global::EMS_Client.Properties.Resources.icon_search;
            this.btnSaerch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaerch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaerch.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaerch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSaerch.Location = new System.Drawing.Point(449, 91);
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
            this.txtSaerch.Location = new System.Drawing.Point(312, 91);
            this.txtSaerch.Multiline = true;
            this.txtSaerch.Name = "txtSaerch";
            this.txtSaerch.Size = new System.Drawing.Size(136, 25);
            this.txtSaerch.TabIndex = 21;
            // 
            // lblUpload
            // 
            this.lblUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblUpload.Location = new System.Drawing.Point(310, 115);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(170, 1);
            this.lblUpload.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel1.Location = new System.Drawing.Point(310, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 1);
            this.panel1.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel2.Location = new System.Drawing.Point(309, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 25);
            this.panel2.TabIndex = 42;
            // 
            // dataPacketBindingSource
            // 
            this.dataPacketBindingSource.DataSource = typeof(EMS_Library.Network.DataPacket);
            // 
            // selectEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUpload);
            this.Controls.Add(this.txtSaerch);
            this.Controls.Add(this.btnSaerch);
            this.Controls.Add(this.panelSelectEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "selectEmployee";
            this.Text = "selectEmployee";
            this.panelSelectEmployee.ResumeLayout(false);
            this.panelSelectEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPacketBindingSource)).EndInit();
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
        private BindingSource dataPacketBindingSource;
    }
}