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
            this.picStandbySphere = new System.Windows.Forms.PictureBox();
            this.lblStandBy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picStandbySphere)).BeginInit();
            this.SuspendLayout();
            // 
            // picStandbySphere
            // 
            this.picStandbySphere.Image = global::EMS_Client.Properties.Resources.its_not_a_tumor;
            this.picStandbySphere.Location = new System.Drawing.Point(42, 83);
            this.picStandbySphere.Name = "picStandbySphere";
            this.picStandbySphere.Size = new System.Drawing.Size(175, 175);
            this.picStandbySphere.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStandbySphere.TabIndex = 1;
            this.picStandbySphere.TabStop = false;
            this.picStandbySphere.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picStandbySphere_MouseDown);
            // 
            // lblStandBy
            // 
            this.lblStandBy.AutoSize = true;
            this.lblStandBy.BackColor = System.Drawing.Color.Transparent;
            this.lblStandBy.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStandBy.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblStandBy.Location = new System.Drawing.Point(82, 32);
            this.lblStandBy.Name = "lblStandBy";
            this.lblStandBy.Size = new System.Drawing.Size(95, 28);
            this.lblStandBy.TabIndex = 2;
            this.lblStandBy.Text = "Stand by";
            // 
            // StandbyScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::EMS_Client.Properties.Resources.Black_circle;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(263, 270);
            this.Controls.Add(this.lblStandBy);
            this.Controls.Add(this.picStandbySphere);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StandbyScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StandbyScreen";
            this.Load += new System.EventHandler(this.StandbyScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picStandbySphere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picStandbySphere;
        private Label lblStandBy;
    }
}