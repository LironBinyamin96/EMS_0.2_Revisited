using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace EMS_Client.Forms
{
    public partial class newEmail : Form
    {
        string to;
        string subject;

        /// <summary>
        /// New email constructor
        /// בנאי להודעה חדשה
        /// </summary>
        public newEmail()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Reply constructor בנאי להשיב למייל
        /// </summary>
        /// <param name="to"></param>
        /// <param name="subject"></param>
        public newEmail(string to, string subject)
        {
            InitializeComponent();
            this.to = to;
            this.subject = subject;
        }

        private void newEmail_Load(object sender, EventArgs e)
        {
            if (to != "" || subject != "")
            {
                txtTo.Text = to;
                txtSubject.Text = subject;
            }
        }

        #region Buttons
        /// <summary>
        /// כפתור שליחת מייל
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            // בדיקה ששדות נמען ונושא המייל לא ריקים
            if (!CheckingDataFields()) return;

            // יצירת ההמייל ושליחתו
            //user - "employee.management.system010@gmail.com", pass - "employee.management.system!!@" "generated: wcvyicyfscoiqfgr"
            SmtpClient Smtp = new SmtpClient("smtp.gmail.com", 587);
            MailMessage mail = new MailMessage("employee.management.system010@gmail.com", txtTo.Text, txtSubject.Text, richTextBody.Text);
            if (lblFile.Text != "")
            {
                Attachment file = new Attachment(lblFile.Text);
                mail.Attachments.Add(file);
            }
            Smtp.EnableSsl = true;
            Smtp.Credentials = new NetworkCredential("employee.management.system010@gmail.com", "wcvyicyfscoiqfgr");
            Smtp.Send(mail);
            txtTo.Clear();
            txtSubject.Clear();
            richTextBody.Clear();
            lblFile.Text = "";
        }
        /// <summary>
        /// הוספת קובץ למייל
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog opdFile = new OpenFileDialog();
            opdFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (opdFile.ShowDialog() == DialogResult.OK)
                lblFile.Text = opdFile.FileName;
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            selectEmployee se = new selectEmployee(this);
            se.Show();
        }
        private void btnX_Click(object sender, EventArgs e) => Close();

        #endregion

        private bool CheckingDataFields()
        {
            Checks checks = new Checks();

            Dictionary<Panel, bool> test = new Dictionary<Panel, bool>();
            test.Add(panelTo, !checks.IsValidEmail(txtTo.Text));
            test.Add(panelSubject, !checks.StringLength(txtSubject.Text));;

            bool res = true;
            foreach (KeyValuePair<Panel, bool> item in test)
            {
                if (item.Value) { item.Key.BackColor = Color.FromArgb(255, 102, 102); res &= false; }
                else { item.Key.BackColor = Color.FromArgb(0, 126, 249); res &= true; }
            }
            return res;
        }


        #region Drag Window
        /// <summary>
        /// Controlls form movement during drag.
        /// </summary>
        void Drag(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panelNewMail_MouseDown(object sender, MouseEventArgs e) => Drag(e);
        private void lblNewMail_MouseDown(object sender, MouseEventArgs e) => Drag(e);
        #endregion
    }
}
