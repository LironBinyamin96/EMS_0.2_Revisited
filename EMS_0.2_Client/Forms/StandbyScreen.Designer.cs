namespace EMS_Client.Forms
{
    partial class StandbyScreen
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
            this.lblStandby = new System.Windows.Forms.Label();
            this.picStandbySphere = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picStandbySphere)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStandby
            // 
            this.lblStandby.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStandby.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblStandby.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblStandby.Location = new System.Drawing.Point(0, 0);
            this.lblStandby.Name = "lblStandby";
            this.lblStandby.Size = new System.Drawing.Size(145, 36);
            this.lblStandby.TabIndex = 0;
            this.lblStandby.Text = "Stand by";
            this.lblStandby.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStandby.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblStandby_MouseDown);
            // 
            // picStandbySphere
            // 
            this.picStandbySphere.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picStandbySphere.Image = global::EMS_Client.Properties.Resources.AntiMatterSphere;
            this.picStandbySphere.Location = new System.Drawing.Point(0, 0);
            this.picStandbySphere.Name = "picStandbySphere";
            this.picStandbySphere.Size = new System.Drawing.Size(145, 139);
            this.picStandbySphere.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStandbySphere.TabIndex = 1;
            this.picStandbySphere.TabStop = false;
            this.picStandbySphere.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picStandbySphere_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblStandby);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 36);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picStandbySphere);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 139);
            this.panel2.TabIndex = 0;
            // 
            // StandbyScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(145, 181);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StandbyScreen";
            this.Text = "StandbyScreen";
            this.Load += new System.EventHandler(this.StandbyScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picStandbySphere)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblStandby;
        private PictureBox picStandbySphere;
        private Panel panel1;
        private Panel panel2;
    }
}