namespace EMS_Client.Forms
{
    partial class Mail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMail = new System.Windows.Forms.Panel();
            this.lblMail = new System.Windows.Forms.Label();
            this.inbox = new System.Windows.Forms.DataGridView();
            this.Form = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Body = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNewEmail = new RJCodeAdvance.RJControls.RJButton();
            this.panelMail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inbox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMail
            // 
            this.panelMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelMail.Controls.Add(this.lblMail);
            this.panelMail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMail.Location = new System.Drawing.Point(0, 0);
            this.panelMail.Name = "panelMail";
            this.panelMail.Size = new System.Drawing.Size(800, 85);
            this.panelMail.TabIndex = 1;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblMail.Location = new System.Drawing.Point(337, 24);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(87, 35);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "Email";
            // 
            // inbox
            // 
            this.inbox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.inbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inbox.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inbox.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.inbox.ColumnHeadersHeight = 30;
            this.inbox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Form,
            this.Subject,
            this.Body});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.inbox.DefaultCellStyle = dataGridViewCellStyle2;
            this.inbox.EnableHeadersVisualStyles = false;
            this.inbox.GridColor = System.Drawing.SystemColors.Control;
            this.inbox.Location = new System.Drawing.Point(0, 137);
            this.inbox.Name = "inbox";
            this.inbox.ReadOnly = true;
            this.inbox.RowHeadersVisible = false;
            this.inbox.RowTemplate.Height = 25;
            this.inbox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inbox.Size = new System.Drawing.Size(800, 315);
            this.inbox.TabIndex = 5;
            this.inbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.inbox_MouseDoubleClick);
            // 
            // Form
            // 
            this.Form.HeaderText = "Form";
            this.Form.Name = "Form";
            this.Form.ReadOnly = true;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            // 
            // Body
            // 
            this.Body.HeaderText = "Body";
            this.Body.Name = "Body";
            this.Body.ReadOnly = true;
            // 
            // btnNewEmail
            // 
            this.btnNewEmail.BackColor = System.Drawing.Color.Transparent;
            this.btnNewEmail.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnNewEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnNewEmail.BorderRadius = 15;
            this.btnNewEmail.BorderSize = 2;
            this.btnNewEmail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnNewEmail.FlatAppearance.BorderSize = 2;
            this.btnNewEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnNewEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnNewEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewEmail.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnNewEmail.Location = new System.Drawing.Point(278, 91);
            this.btnNewEmail.Name = "btnNewEmail";
            this.btnNewEmail.Size = new System.Drawing.Size(205, 40);
            this.btnNewEmail.TabIndex = 51;
            this.btnNewEmail.Text = "New Email";
            this.btnNewEmail.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnNewEmail.UseVisualStyleBackColor = false;
            this.btnNewEmail.Click += new System.EventHandler(this.btnNewEmail_Click);
            // 
            // Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewEmail);
            this.Controls.Add(this.inbox);
            this.Controls.Add(this.panelMail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mail";
            this.Text = "Mail";
            this.Load += new System.EventHandler(this.Mail_Load);
            this.panelMail.ResumeLayout(false);
            this.panelMail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMail;
        private Label lblMail;
        private DataGridView inbox;
        private DataGridViewTextBoxColumn Form;
        private DataGridViewTextBoxColumn Subject;
        private DataGridViewTextBoxColumn Body;
        private RJCodeAdvance.RJControls.RJButton btnNewEmail;
    }
}