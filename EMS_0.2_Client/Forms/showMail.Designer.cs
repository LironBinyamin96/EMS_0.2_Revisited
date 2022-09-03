namespace EMS_Client.Forms
{
    partial class showMail
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
            this.panelMail = new System.Windows.Forms.Panel();
            this.btnX = new System.Windows.Forms.Button();
            this.lblMail = new System.Windows.Forms.Label();
            this.btnReply = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBody = new System.Windows.Forms.RichTextBox();
            this.lblBody = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtForm = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblForm = new System.Windows.Forms.Label();
            this.panelMail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMail
            // 
            this.panelMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelMail.Controls.Add(this.btnX);
            this.panelMail.Controls.Add(this.lblMail);
            this.panelMail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMail.Location = new System.Drawing.Point(0, 0);
            this.panelMail.Name = "panelMail";
            this.panelMail.Size = new System.Drawing.Size(676, 85);
            this.panelMail.TabIndex = 2;
            this.panelMail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMail_MouseDown_1);
            // 
            // btnX
            // 
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnX.Location = new System.Drawing.Point(645, 3);
            this.btnX.Name = "btnX";
            this.btnX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnX.Size = new System.Drawing.Size(23, 27);
            this.btnX.TabIndex = 42;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblMail.Location = new System.Drawing.Point(283, 19);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(87, 35);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "Email";
            this.lblMail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblMail_MouseDown_1);
            // 
            // btnReply
            // 
            this.btnReply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReply.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnReply.Location = new System.Drawing.Point(423, 444);
            this.btnReply.Name = "btnReply";
            this.btnReply.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReply.Size = new System.Drawing.Size(122, 32);
            this.btnReply.TabIndex = 27;
            this.btnReply.Text = "Reply";
            this.btnReply.UseVisualStyleBackColor = true;
            this.btnReply.Click += new System.EventHandler(this.btnReply_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel6.Location = new System.Drawing.Point(544, 220);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 190);
            this.panel6.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel5.Location = new System.Drawing.Point(164, 223);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 190);
            this.panel5.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel4.Location = new System.Drawing.Point(164, 412);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(378, 1);
            this.panel4.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel3.Location = new System.Drawing.Point(164, 220);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 1);
            this.panel3.TabIndex = 26;
            // 
            // richTextBody
            // 
            this.richTextBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.richTextBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBody.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBody.ForeColor = System.Drawing.SystemColors.Menu;
            this.richTextBody.Location = new System.Drawing.Point(167, 220);
            this.richTextBody.Name = "richTextBody";
            this.richTextBody.Size = new System.Drawing.Size(378, 193);
            this.richTextBody.TabIndex = 25;
            this.richTextBody.Text = "";
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBody.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblBody.Location = new System.Drawing.Point(122, 220);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(43, 18);
            this.lblBody.TabIndex = 24;
            this.lblBody.Text = "Body :";
            // 
            // txtSubject
            // 
            this.txtSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubject.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSubject.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtSubject.Location = new System.Drawing.Point(167, 165);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(358, 16);
            this.txtSubject.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel2.Location = new System.Drawing.Point(167, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 1);
            this.panel2.TabIndex = 19;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblSubject.Location = new System.Drawing.Point(106, 170);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(59, 18);
            this.lblSubject.TabIndex = 18;
            this.lblSubject.Text = "Subject :";
            // 
            // txtForm
            // 
            this.txtForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtForm.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtForm.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtForm.Location = new System.Drawing.Point(167, 121);
            this.txtForm.Name = "txtForm";
            this.txtForm.Size = new System.Drawing.Size(358, 16);
            this.txtForm.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel1.Location = new System.Drawing.Point(167, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 1);
            this.panel1.TabIndex = 16;
            // 
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblForm.Location = new System.Drawing.Point(122, 119);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(46, 18);
            this.lblForm.TabIndex = 15;
            this.lblForm.Text = "Form :";
            // 
            // showMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(676, 544);
            this.Controls.Add(this.btnReply);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.richTextBody);
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.txtForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblForm);
            this.Controls.Add(this.panelMail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "showMail";
            this.Text = "showMail";
            this.Load += new System.EventHandler(this.showMail_Load);
            this.panelMail.ResumeLayout(false);
            this.panelMail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelMail;
        private Label lblMail;
        private Button btnReply;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private RichTextBox richTextBody;
        private Label lblBody;
        private TextBox txtSubject;
        private Panel panel2;
        private Label lblSubject;
        private TextBox txtForm;
        private Panel panel1;
        private Label lblForm;
        private Button btnX;
    }
}