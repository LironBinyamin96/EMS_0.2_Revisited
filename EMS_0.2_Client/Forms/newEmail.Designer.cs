namespace EMS_Client.Forms
{
    partial class newEmail
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
            this.panelNewMail = new System.Windows.Forms.Panel();
            this.btnX = new System.Windows.Forms.Button();
            this.lblNewMail = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.panelTo = new System.Windows.Forms.Panel();
            this.lblTo = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.panelSubject = new System.Windows.Forms.Panel();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.richTextBody = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblFile = new System.Windows.Forms.Label();
            this.btnSend = new RJCodeAdvance.RJControls.RJButton();
            this.btnSendToAll = new RJCodeAdvance.RJControls.RJButton();
            this.btnSelect = new RJCodeAdvance.RJControls.RJButton();
            this.btnAddFile = new RJCodeAdvance.RJControls.RJButton();
            this.panelNewMail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNewMail
            // 
            this.panelNewMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelNewMail.Controls.Add(this.btnX);
            this.panelNewMail.Controls.Add(this.lblNewMail);
            this.panelNewMail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNewMail.Location = new System.Drawing.Point(0, 0);
            this.panelNewMail.Name = "panelNewMail";
            this.panelNewMail.Size = new System.Drawing.Size(656, 85);
            this.panelNewMail.TabIndex = 2;
            this.panelNewMail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelNewMail_MouseDown);
            // 
            // btnX
            // 
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnX.Location = new System.Drawing.Point(628, 3);
            this.btnX.Name = "btnX";
            this.btnX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnX.Size = new System.Drawing.Size(23, 27);
            this.btnX.TabIndex = 41;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // lblNewMail
            // 
            this.lblNewMail.AutoSize = true;
            this.lblNewMail.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblNewMail.Location = new System.Drawing.Point(258, 23);
            this.lblNewMail.Name = "lblNewMail";
            this.lblNewMail.Size = new System.Drawing.Size(133, 35);
            this.lblNewMail.TabIndex = 0;
            this.lblNewMail.Text = "New Mail";
            this.lblNewMail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblNewMail_MouseDown);
            // 
            // txtTo
            // 
            this.txtTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTo.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTo.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtTo.Location = new System.Drawing.Point(155, 115);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(358, 16);
            this.txtTo.TabIndex = 5;
            // 
            // panelTo
            // 
            this.panelTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panelTo.Location = new System.Drawing.Point(155, 137);
            this.panelTo.Name = "panelTo";
            this.panelTo.Size = new System.Drawing.Size(378, 1);
            this.panelTo.TabIndex = 4;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblTo.Location = new System.Drawing.Point(124, 120);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(29, 18);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "TO :";
            // 
            // txtSubject
            // 
            this.txtSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubject.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSubject.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtSubject.Location = new System.Drawing.Point(155, 165);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(358, 16);
            this.txtSubject.TabIndex = 8;
            // 
            // panelSubject
            // 
            this.panelSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panelSubject.Location = new System.Drawing.Point(155, 187);
            this.panelSubject.Name = "panelSubject";
            this.panelSubject.Size = new System.Drawing.Size(378, 1);
            this.panelSubject.TabIndex = 7;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblSubject.Location = new System.Drawing.Point(94, 170);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(59, 18);
            this.lblSubject.TabIndex = 6;
            this.lblSubject.Text = "Subject :";
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBody.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblBody.Location = new System.Drawing.Point(110, 220);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(43, 18);
            this.lblBody.TabIndex = 9;
            this.lblBody.Text = "Body :";
            // 
            // richTextBody
            // 
            this.richTextBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.richTextBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBody.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBody.ForeColor = System.Drawing.SystemColors.Menu;
            this.richTextBody.Location = new System.Drawing.Point(158, 220);
            this.richTextBody.Name = "richTextBody";
            this.richTextBody.Size = new System.Drawing.Size(378, 193);
            this.richTextBody.TabIndex = 10;
            this.richTextBody.Text = "";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel3.Location = new System.Drawing.Point(155, 220);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 1);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel4.Location = new System.Drawing.Point(155, 412);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(378, 1);
            this.panel4.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel5.Location = new System.Drawing.Point(155, 223);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 190);
            this.panel5.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel6.Location = new System.Drawing.Point(535, 220);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 190);
            this.panel6.TabIndex = 9;
            // 
            // lblFile
            // 
            this.lblFile.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFile.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblFile.Location = new System.Drawing.Point(237, 429);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(59, 18);
            this.lblFile.TabIndex = 14;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSend.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSend.BorderRadius = 17;
            this.btnSend.BorderSize = 2;
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSend.FlatAppearance.BorderSize = 2;
            this.btnSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSend.Location = new System.Drawing.Point(448, 466);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(121, 39);
            this.btnSend.TabIndex = 51;
            this.btnSend.Text = "Send";
            this.btnSend.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnSendToAll
            // 
            this.btnSendToAll.BackColor = System.Drawing.Color.Transparent;
            this.btnSendToAll.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSendToAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSendToAll.BorderRadius = 15;
            this.btnSendToAll.BorderSize = 1;
            this.btnSendToAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSendToAll.FlatAppearance.BorderSize = 2;
            this.btnSendToAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnSendToAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSendToAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendToAll.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSendToAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSendToAll.Location = new System.Drawing.Point(561, 109);
            this.btnSendToAll.Name = "btnSendToAll";
            this.btnSendToAll.Size = new System.Drawing.Size(90, 29);
            this.btnSendToAll.TabIndex = 52;
            this.btnSendToAll.Text = "Send to all";
            this.btnSendToAll.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSendToAll.UseVisualStyleBackColor = false;
            this.btnSendToAll.Click += new System.EventHandler(this.btnSendToAll_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSelect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSelect.BorderRadius = 22;
            this.btnSelect.BorderSize = 1;
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSelect.FlatAppearance.BorderSize = 2;
            this.btnSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSelect.Location = new System.Drawing.Point(561, 144);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(90, 42);
            this.btnSelect.TabIndex = 53;
            this.btnSelect.Text = "Select an employee";
            this.btnSelect.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.BackColor = System.Drawing.Color.Transparent;
            this.btnAddFile.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAddFile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddFile.BorderRadius = 15;
            this.btnAddFile.BorderSize = 1;
            this.btnAddFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddFile.FlatAppearance.BorderSize = 2;
            this.btnAddFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnAddFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFile.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddFile.Location = new System.Drawing.Point(149, 417);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(90, 29);
            this.btnAddFile.TabIndex = 54;
            this.btnAddFile.Text = "Add File";
            this.btnAddFile.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddFile.UseVisualStyleBackColor = false;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // newEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(656, 537);
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSendToAll);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.richTextBody);
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.panelSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.panelTo);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.panelNewMail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "newEmail";
            this.Text = "newEmail";
            this.Load += new System.EventHandler(this.newEmail_Load);
            this.panelNewMail.ResumeLayout(false);
            this.panelNewMail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelNewMail;
        private Label lblNewMail;
        private TextBox txtTo;
        private Panel panelTo;
        private Label lblTo;
        private TextBox txtSubject;
        private Panel panelSubject;
        private Label lblSubject;
        private Label lblBody;
        private RichTextBox richTextBody;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label lblFile;
        private Button btnX;
        private RJCodeAdvance.RJControls.RJButton btnSend;
        private RJCodeAdvance.RJControls.RJButton btnSendToAll;
        private RJCodeAdvance.RJControls.RJButton btnSelect;
        private RJCodeAdvance.RJControls.RJButton btnAddFile;
    }
}