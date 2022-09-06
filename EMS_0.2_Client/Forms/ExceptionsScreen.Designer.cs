namespace EMS_Client.Forms
{
    partial class ExceptionsScreen
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
            this.lblExceptions = new System.Windows.Forms.Label();
            this.exceptionsTable = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Divison = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._intId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._entry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._exit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.exceptionsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExceptions
            // 
            this.lblExceptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExceptions.AutoSize = true;
            this.lblExceptions.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExceptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblExceptions.Location = new System.Drawing.Point(200, 9);
            this.lblExceptions.Name = "lblExceptions";
            this.lblExceptions.Size = new System.Drawing.Size(156, 35);
            this.lblExceptions.TabIndex = 0;
            this.lblExceptions.Text = "Exceptions";
            // 
            // exceptionsTable
            // 
            this.exceptionsTable.AllowUserToAddRows = false;
            this.exceptionsTable.AllowUserToDeleteRows = false;
            this.exceptionsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exceptionsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LastName,
            this.FirstName,
            this.Divison,
            this._intId,
            this._entry,
            this._exit});
            this.exceptionsTable.Location = new System.Drawing.Point(12, 47);
            this.exceptionsTable.MultiSelect = false;
            this.exceptionsTable.Name = "exceptionsTable";
            this.exceptionsTable.ReadOnly = true;
            this.exceptionsTable.RowTemplate.Height = 25;
            this.exceptionsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.exceptionsTable.Size = new System.Drawing.Size(570, 743);
            this.exceptionsTable.TabIndex = 44;
            this.exceptionsTable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.exceptionsTable_CellMouseDoubleClick);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnClose.Location = new System.Drawing.Point(558, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 23);
            this.btnClose.TabIndex = 45;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 90;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 90;
            // 
            // Divison
            // 
            this.Divison.HeaderText = "Division";
            this.Divison.Name = "Divison";
            this.Divison.ReadOnly = true;
            this.Divison.Width = 90;
            // 
            // _intId
            // 
            this._intId.HeaderText = "Internal ID";
            this._intId.Name = "_intId";
            this._intId.ReadOnly = true;
            this._intId.Width = 90;
            // 
            // _entry
            // 
            this._entry.HeaderText = "Entry";
            this._entry.Name = "_entry";
            this._entry.ReadOnly = true;
            this._entry.Width = 90;
            // 
            // _exit
            // 
            this._exit.HeaderText = "Exit";
            this._exit.Name = "_exit";
            this._exit.ReadOnly = true;
            this._exit.Width = 90;
            // 
            // ExceptionsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(593, 802);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.exceptionsTable);
            this.Controls.Add(this.lblExceptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExceptionsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ExceptionsScreen";
            this.Load += new System.EventHandler(this.ExceptionsScreen_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExceptionsScreen_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.exceptionsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblExceptions;
        private DataGridView exceptionsTable;
        private Button btnClose;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn Divison;
        private DataGridViewTextBoxColumn _intId;
        private DataGridViewTextBoxColumn _entry;
        private DataGridViewTextBoxColumn _exit;
    }
}