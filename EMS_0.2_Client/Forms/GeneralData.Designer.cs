using System.Data.OleDb;
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
            this.lblJan = new System.Windows.Forms.Label();
            this.lblFeb = new System.Windows.Forms.Label();
            this.lblMar = new System.Windows.Forms.Label();
            this.lblApr = new System.Windows.Forms.Label();
            this.lblMay = new System.Windows.Forms.Label();
            this.lblJun = new System.Windows.Forms.Label();
            this.lblJul = new System.Windows.Forms.Label();
            this.lblAug = new System.Windows.Forms.Label();
            this.lblSep = new System.Windows.Forms.Label();
            this.lblOct = new System.Windows.Forms.Label();
            this.lblNov = new System.Windows.Forms.Label();
            this.lblDec = new System.Windows.Forms.Label();
            this.lblEmpData = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.monthBar11 = new System.Windows.Forms.ProgressBar();
            this.lblMonthData11 = new System.Windows.Forms.Label();
            this.monthBar10 = new System.Windows.Forms.ProgressBar();
            this.monthBar9 = new System.Windows.Forms.ProgressBar();
            this.lblMonthData10 = new System.Windows.Forms.Label();
            this.monthBar8 = new System.Windows.Forms.ProgressBar();
            this.lblMonthData9 = new System.Windows.Forms.Label();
            this.monthBar7 = new System.Windows.Forms.ProgressBar();
            this.monthBar6 = new System.Windows.Forms.ProgressBar();
            this.lblMonthData8 = new System.Windows.Forms.Label();
            this.monthBar5 = new System.Windows.Forms.ProgressBar();
            this.monthBar4 = new System.Windows.Forms.ProgressBar();
            this.monthBar3 = new System.Windows.Forms.ProgressBar();
            this.lblMonthData7 = new System.Windows.Forms.Label();
            this.monthBar2 = new System.Windows.Forms.ProgressBar();
            this.monthBar1 = new System.Windows.Forms.ProgressBar();
            this.lblMonthData6 = new System.Windows.Forms.Label();
            this.monthBar0 = new System.Windows.Forms.ProgressBar();
            this.lblMonthData5 = new System.Windows.Forms.Label();
            this.lblMonthData4 = new System.Windows.Forms.Label();
            this.lblMonthData3 = new System.Windows.Forms.Label();
            this.lblMonthData2 = new System.Windows.Forms.Label();
            this.lblMonthData1 = new System.Windows.Forms.Label();
            this.lblMonthData0 = new System.Windows.Forms.Label();
            this.lblAvgText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.yearPicker = new System.Windows.Forms.ComboBox();
            this.lblDilyAvgHours = new System.Windows.Forms.Label();
            this.panelGeneralData.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGeneralData
            // 
            this.panelGeneralData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelGeneralData.Controls.Add(this.lblGeneralData);
            this.panelGeneralData.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGeneralData.Location = new System.Drawing.Point(0, 0);
            this.panelGeneralData.Name = "panelGeneralData";
            this.panelGeneralData.Size = new System.Drawing.Size(800, 85);
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
            this.btnSelect.Location = new System.Drawing.Point(5, 91);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSelect.Size = new System.Drawing.Size(193, 40);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Select an employee";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblJan
            // 
            this.lblJan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJan.AutoSize = true;
            this.lblJan.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblJan.Location = new System.Drawing.Point(631, 11);
            this.lblJan.Name = "lblJan";
            this.lblJan.Size = new System.Drawing.Size(47, 15);
            this.lblJan.TabIndex = 7;
            this.lblJan.Text = "January";
            // 
            // lblFeb
            // 
            this.lblFeb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFeb.AutoSize = true;
            this.lblFeb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFeb.Location = new System.Drawing.Point(631, 31);
            this.lblFeb.Name = "lblFeb";
            this.lblFeb.Size = new System.Drawing.Size(53, 15);
            this.lblFeb.TabIndex = 8;
            this.lblFeb.Text = "February";
            // 
            // lblMar
            // 
            this.lblMar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMar.AutoSize = true;
            this.lblMar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblMar.Location = new System.Drawing.Point(631, 51);
            this.lblMar.Name = "lblMar";
            this.lblMar.Size = new System.Drawing.Size(41, 15);
            this.lblMar.TabIndex = 9;
            this.lblMar.Text = "March";
            // 
            // lblApr
            // 
            this.lblApr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApr.AutoSize = true;
            this.lblApr.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblApr.Location = new System.Drawing.Point(631, 71);
            this.lblApr.Name = "lblApr";
            this.lblApr.Size = new System.Drawing.Size(32, 15);
            this.lblApr.TabIndex = 10;
            this.lblApr.Text = "April";
            // 
            // lblMay
            // 
            this.lblMay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMay.AutoSize = true;
            this.lblMay.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblMay.Location = new System.Drawing.Point(631, 91);
            this.lblMay.Name = "lblMay";
            this.lblMay.Size = new System.Drawing.Size(30, 15);
            this.lblMay.TabIndex = 11;
            this.lblMay.Text = "May";
            // 
            // lblJun
            // 
            this.lblJun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJun.AutoSize = true;
            this.lblJun.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblJun.Location = new System.Drawing.Point(631, 111);
            this.lblJun.Name = "lblJun";
            this.lblJun.Size = new System.Drawing.Size(31, 15);
            this.lblJun.TabIndex = 12;
            this.lblJun.Text = "June";
            // 
            // lblJul
            // 
            this.lblJul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJul.AutoSize = true;
            this.lblJul.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblJul.Location = new System.Drawing.Point(631, 131);
            this.lblJul.Name = "lblJul";
            this.lblJul.Size = new System.Drawing.Size(27, 15);
            this.lblJul.TabIndex = 13;
            this.lblJul.Text = "July";
            // 
            // lblAug
            // 
            this.lblAug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAug.AutoSize = true;
            this.lblAug.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblAug.Location = new System.Drawing.Point(631, 151);
            this.lblAug.Name = "lblAug";
            this.lblAug.Size = new System.Drawing.Size(45, 15);
            this.lblAug.TabIndex = 14;
            this.lblAug.Text = "August";
            // 
            // lblSep
            // 
            this.lblSep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSep.AutoSize = true;
            this.lblSep.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSep.Location = new System.Drawing.Point(631, 171);
            this.lblSep.Name = "lblSep";
            this.lblSep.Size = new System.Drawing.Size(64, 15);
            this.lblSep.TabIndex = 15;
            this.lblSep.Text = "September";
            // 
            // lblOct
            // 
            this.lblOct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOct.AutoSize = true;
            this.lblOct.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblOct.Location = new System.Drawing.Point(631, 191);
            this.lblOct.Name = "lblOct";
            this.lblOct.Size = new System.Drawing.Size(50, 15);
            this.lblOct.TabIndex = 16;
            this.lblOct.Text = "October";
            // 
            // lblNov
            // 
            this.lblNov.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNov.AutoSize = true;
            this.lblNov.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNov.Location = new System.Drawing.Point(632, 211);
            this.lblNov.Name = "lblNov";
            this.lblNov.Size = new System.Drawing.Size(63, 15);
            this.lblNov.TabIndex = 17;
            this.lblNov.Text = "November";
            // 
            // lblDec
            // 
            this.lblDec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDec.AutoSize = true;
            this.lblDec.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDec.Location = new System.Drawing.Point(634, 231);
            this.lblDec.Name = "lblDec";
            this.lblDec.Size = new System.Drawing.Size(61, 15);
            this.lblDec.TabIndex = 18;
            this.lblDec.Text = "December";
            // 
            // lblEmpData
            // 
            this.lblEmpData.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblEmpData.Location = new System.Drawing.Point(157, 418);
            this.lblEmpData.Name = "lblEmpData";
            this.lblEmpData.Size = new System.Drawing.Size(631, 138);
            this.lblEmpData.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.monthBar11);
            this.panel2.Controls.Add(this.lblMonthData11);
            this.panel2.Controls.Add(this.monthBar10);
            this.panel2.Controls.Add(this.monthBar9);
            this.panel2.Controls.Add(this.lblMonthData10);
            this.panel2.Controls.Add(this.monthBar8);
            this.panel2.Controls.Add(this.lblMonthData9);
            this.panel2.Controls.Add(this.monthBar7);
            this.panel2.Controls.Add(this.lblDec);
            this.panel2.Controls.Add(this.monthBar6);
            this.panel2.Controls.Add(this.lblMonthData8);
            this.panel2.Controls.Add(this.monthBar5);
            this.panel2.Controls.Add(this.lblNov);
            this.panel2.Controls.Add(this.monthBar4);
            this.panel2.Controls.Add(this.lblOct);
            this.panel2.Controls.Add(this.monthBar3);
            this.panel2.Controls.Add(this.lblMonthData7);
            this.panel2.Controls.Add(this.monthBar2);
            this.panel2.Controls.Add(this.lblSep);
            this.panel2.Controls.Add(this.monthBar1);
            this.panel2.Controls.Add(this.lblMonthData6);
            this.panel2.Controls.Add(this.monthBar0);
            this.panel2.Controls.Add(this.lblAug);
            this.panel2.Controls.Add(this.lblMonthData5);
            this.panel2.Controls.Add(this.lblJul);
            this.panel2.Controls.Add(this.lblMonthData4);
            this.panel2.Controls.Add(this.lblJun);
            this.panel2.Controls.Add(this.lblMonthData3);
            this.panel2.Controls.Add(this.lblMay);
            this.panel2.Controls.Add(this.lblMonthData2);
            this.panel2.Controls.Add(this.lblApr);
            this.panel2.Controls.Add(this.lblMonthData1);
            this.panel2.Controls.Add(this.lblMar);
            this.panel2.Controls.Add(this.lblMonthData0);
            this.panel2.Controls.Add(this.lblFeb);
            this.panel2.Controls.Add(this.lblJan);
            this.panel2.Location = new System.Drawing.Point(5, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 256);
            this.panel2.TabIndex = 20;
            // 
            // monthBar11
            // 
            this.monthBar11.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.monthBar11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthBar11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.monthBar11.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.monthBar11.Location = new System.Drawing.Point(154, 226);
            this.monthBar11.Name = "monthBar11";
            this.monthBar11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.monthBar11.Size = new System.Drawing.Size(471, 20);
            this.monthBar11.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.monthBar11.TabIndex = 15;
            // 
            // lblMonthData11
            // 
            this.lblMonthData11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMonthData11.Location = new System.Drawing.Point(72, 226);
            this.lblMonthData11.Name = "lblMonthData11";
            this.lblMonthData11.Size = new System.Drawing.Size(74, 20);
            this.lblMonthData11.TabIndex = 33;
            this.lblMonthData11.Text = "0";
            // 
            // monthBar10
            // 
            this.monthBar10.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.monthBar10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthBar10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.monthBar10.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.monthBar10.Location = new System.Drawing.Point(154, 206);
            this.monthBar10.Name = "monthBar10";
            this.monthBar10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.monthBar10.Size = new System.Drawing.Size(471, 20);
            this.monthBar10.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.monthBar10.TabIndex = 14;
            // 
            // monthBar9
            // 
            this.monthBar9.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.monthBar9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthBar9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.monthBar9.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.monthBar9.Location = new System.Drawing.Point(154, 186);
            this.monthBar9.Name = "monthBar9";
            this.monthBar9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.monthBar9.Size = new System.Drawing.Size(471, 20);
            this.monthBar9.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.monthBar9.TabIndex = 13;
            // 
            // lblMonthData10
            // 
            this.lblMonthData10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMonthData10.Location = new System.Drawing.Point(72, 206);
            this.lblMonthData10.Name = "lblMonthData10";
            this.lblMonthData10.Size = new System.Drawing.Size(74, 20);
            this.lblMonthData10.TabIndex = 32;
            this.lblMonthData10.Text = "0";
            // 
            // monthBar8
            // 
            this.monthBar8.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.monthBar8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthBar8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.monthBar8.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.monthBar8.Location = new System.Drawing.Point(154, 166);
            this.monthBar8.Name = "monthBar8";
            this.monthBar8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.monthBar8.Size = new System.Drawing.Size(471, 20);
            this.monthBar8.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.monthBar8.TabIndex = 12;
            // 
            // lblMonthData9
            // 
            this.lblMonthData9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMonthData9.Location = new System.Drawing.Point(72, 186);
            this.lblMonthData9.Name = "lblMonthData9";
            this.lblMonthData9.Size = new System.Drawing.Size(76, 20);
            this.lblMonthData9.TabIndex = 31;
            this.lblMonthData9.Text = "0";
            // 
            // monthBar7
            // 
            this.monthBar7.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.monthBar7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthBar7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.monthBar7.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.monthBar7.Location = new System.Drawing.Point(154, 146);
            this.monthBar7.Name = "monthBar7";
            this.monthBar7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.monthBar7.Size = new System.Drawing.Size(471, 20);
            this.monthBar7.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.monthBar7.TabIndex = 11;
            // 
            // monthBar6
            // 
            this.monthBar6.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.monthBar6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthBar6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.monthBar6.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.monthBar6.Location = new System.Drawing.Point(154, 126);
            this.monthBar6.Name = "monthBar6";
            this.monthBar6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.monthBar6.Size = new System.Drawing.Size(471, 20);
            this.monthBar6.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.monthBar6.TabIndex = 10;
            // 
            // lblMonthData8
            // 
            this.lblMonthData8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMonthData8.Location = new System.Drawing.Point(72, 166);
            this.lblMonthData8.Name = "lblMonthData8";
            this.lblMonthData8.Size = new System.Drawing.Size(74, 20);
            this.lblMonthData8.TabIndex = 30;
            this.lblMonthData8.Text = "0";
            // 
            // monthBar5
            // 
            this.monthBar5.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.monthBar5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthBar5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.monthBar5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.monthBar5.Location = new System.Drawing.Point(154, 106);
            this.monthBar5.Name = "monthBar5";
            this.monthBar5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.monthBar5.Size = new System.Drawing.Size(471, 20);
            this.monthBar5.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.monthBar5.TabIndex = 9;
            // 
            // monthBar4
            // 
            this.monthBar4.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.monthBar4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthBar4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.monthBar4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.monthBar4.Location = new System.Drawing.Point(154, 86);
            this.monthBar4.Name = "monthBar4";
            this.monthBar4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.monthBar4.Size = new System.Drawing.Size(471, 20);
            this.monthBar4.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.monthBar4.TabIndex = 8;
            // 
            // monthBar3
            // 
            this.monthBar3.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.monthBar3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthBar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.monthBar3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.monthBar3.Location = new System.Drawing.Point(154, 66);
            this.monthBar3.Name = "monthBar3";
            this.monthBar3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.monthBar3.Size = new System.Drawing.Size(471, 20);
            this.monthBar3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.monthBar3.TabIndex = 7;
            // 
            // lblMonthData7
            // 
            this.lblMonthData7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMonthData7.Location = new System.Drawing.Point(72, 146);
            this.lblMonthData7.Name = "lblMonthData7";
            this.lblMonthData7.Size = new System.Drawing.Size(74, 20);
            this.lblMonthData7.TabIndex = 29;
            this.lblMonthData7.Text = "0";
            // 
            // monthBar2
            // 
            this.monthBar2.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.monthBar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.monthBar2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.monthBar2.Location = new System.Drawing.Point(154, 46);
            this.monthBar2.Name = "monthBar2";
            this.monthBar2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.monthBar2.Size = new System.Drawing.Size(471, 20);
            this.monthBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.monthBar2.TabIndex = 6;
            // 
            // monthBar1
            // 
            this.monthBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.monthBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.monthBar1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.monthBar1.Location = new System.Drawing.Point(154, 26);
            this.monthBar1.Name = "monthBar1";
            this.monthBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.monthBar1.Size = new System.Drawing.Size(471, 20);
            this.monthBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.monthBar1.TabIndex = 5;
            // 
            // lblMonthData6
            // 
            this.lblMonthData6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMonthData6.Location = new System.Drawing.Point(72, 126);
            this.lblMonthData6.Name = "lblMonthData6";
            this.lblMonthData6.Size = new System.Drawing.Size(74, 20);
            this.lblMonthData6.TabIndex = 28;
            this.lblMonthData6.Text = "0";
            // 
            // monthBar0
            // 
            this.monthBar0.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.monthBar0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthBar0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.monthBar0.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.monthBar0.Location = new System.Drawing.Point(154, 6);
            this.monthBar0.Name = "monthBar0";
            this.monthBar0.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.monthBar0.Size = new System.Drawing.Size(471, 20);
            this.monthBar0.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.monthBar0.TabIndex = 4;
            // 
            // lblMonthData5
            // 
            this.lblMonthData5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMonthData5.Location = new System.Drawing.Point(72, 106);
            this.lblMonthData5.Name = "lblMonthData5";
            this.lblMonthData5.Size = new System.Drawing.Size(76, 20);
            this.lblMonthData5.TabIndex = 27;
            this.lblMonthData5.Text = "0";
            // 
            // lblMonthData4
            // 
            this.lblMonthData4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMonthData4.Location = new System.Drawing.Point(72, 86);
            this.lblMonthData4.Name = "lblMonthData4";
            this.lblMonthData4.Size = new System.Drawing.Size(74, 20);
            this.lblMonthData4.TabIndex = 26;
            this.lblMonthData4.Text = "0";
            // 
            // lblMonthData3
            // 
            this.lblMonthData3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMonthData3.Location = new System.Drawing.Point(72, 66);
            this.lblMonthData3.Name = "lblMonthData3";
            this.lblMonthData3.Size = new System.Drawing.Size(74, 20);
            this.lblMonthData3.TabIndex = 25;
            this.lblMonthData3.Text = "0";
            // 
            // lblMonthData2
            // 
            this.lblMonthData2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMonthData2.Location = new System.Drawing.Point(72, 46);
            this.lblMonthData2.Name = "lblMonthData2";
            this.lblMonthData2.Size = new System.Drawing.Size(74, 20);
            this.lblMonthData2.TabIndex = 24;
            this.lblMonthData2.Text = "0";
            // 
            // lblMonthData1
            // 
            this.lblMonthData1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMonthData1.Location = new System.Drawing.Point(72, 26);
            this.lblMonthData1.Name = "lblMonthData1";
            this.lblMonthData1.Size = new System.Drawing.Size(74, 20);
            this.lblMonthData1.TabIndex = 23;
            this.lblMonthData1.Text = "0";
            // 
            // lblMonthData0
            // 
            this.lblMonthData0.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMonthData0.Location = new System.Drawing.Point(72, 6);
            this.lblMonthData0.Name = "lblMonthData0";
            this.lblMonthData0.Size = new System.Drawing.Size(74, 20);
            this.lblMonthData0.TabIndex = 22;
            this.lblMonthData0.Text = "0";
            // 
            // lblAvgText
            // 
            this.lblAvgText.AutoSize = true;
            this.lblAvgText.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblAvgText.Location = new System.Drawing.Point(34, 143);
            this.lblAvgText.Name = "lblAvgText";
            this.lblAvgText.Size = new System.Drawing.Size(50, 15);
            this.lblAvgText.TabIndex = 21;
            this.lblAvgText.Text = "In hours";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(5, 415);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // yearPicker
            // 
            this.yearPicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.yearPicker.ForeColor = System.Drawing.Color.DodgerBlue;
            this.yearPicker.FormattingEnabled = true;
            this.yearPicker.Location = new System.Drawing.Point(597, 108);
            this.yearPicker.Name = "yearPicker";
            this.yearPicker.Size = new System.Drawing.Size(121, 23);
            this.yearPicker.TabIndex = 22;
            this.yearPicker.SelectedIndexChanged += new System.EventHandler(this.yearPicker_SelectedIndexChanged);
            // 
            // lblDilyAvgHours
            // 
            this.lblDilyAvgHours.AutoSize = true;
            this.lblDilyAvgHours.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDilyAvgHours.Location = new System.Drawing.Point(278, 143);
            this.lblDilyAvgHours.Name = "lblDilyAvgHours";
            this.lblDilyAvgHours.Size = new System.Drawing.Size(107, 15);
            this.lblDilyAvgHours.TabIndex = 23;
            this.lblDilyAvgHours.Text = "Total hours worked";
            // 
            // GeneralData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.lblDilyAvgHours);
            this.Controls.Add(this.yearPicker);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEmpData);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.panelGeneralData);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblAvgText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GeneralData";
            this.Text = "GeneralData";
            this.panelGeneralData.ResumeLayout(false);
            this.panelGeneralData.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelGeneralData;
        private Label lblGeneralData;
        private Button btnSelect;
        private System.Windows.Forms.DataVisualization.Charting.Chart dataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
        System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
        System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
        System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
        private Label lblJan;
        private Label lblFeb;
        private Label lblMar;
        private Label lblApr;
        private Label lblMay;
        private Label lblJun;
        private Label lblJul;
        private Label lblAug;
        private Label lblSep;
        private Label lblOct;
        private Label lblNov;
        private Label lblDec;
        private Label lblEmpData;
        private Panel panel2;
        private Label lblAvgText;
        private PictureBox pictureBox1;
        private ComboBox yearPicker;
        private Label lblMonthData11;
        private Label lblMonthData10;
        private Label lblMonthData9;
        private Label lblMonthData8;
        private Label lblMonthData7;
        private Label lblMonthData6;
        private Label lblMonthData5;
        private Label lblMonthData4;
        private Label lblMonthData3;
        private Label lblMonthData2;
        private Label lblMonthData1;
        private Label lblMonthData0;
        private ProgressBar monthBar11;
        private ProgressBar monthBar10;
        private ProgressBar monthBar9;
        private ProgressBar monthBar8;
        private ProgressBar monthBar7;
        private ProgressBar monthBar6;
        private ProgressBar monthBar5;
        private ProgressBar monthBar4;
        private ProgressBar monthBar3;
        private ProgressBar monthBar2;
        private ProgressBar monthBar1;
        private ProgressBar monthBar0;
        private Label lblDilyAvgHours;
    }
}