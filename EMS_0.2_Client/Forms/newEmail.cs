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
        // בנאי להודעה חדשה

        public newEmail()
        {
            InitializeComponent();
        }
        string to;
        string subject;

        // בנאי להשיב למייל
        public newEmail(string to, string subject)
        {
            InitializeComponent();
            this.to = to;
            this.subject = subject;
        }

        private void btnX_Click(object sender, EventArgs e) => Close();

        private void btnSend_Click(object sender, EventArgs e)
        {
            //user - "employee.management.system010@gmail.com", pass - "employee.management.system!!@"
            SmtpClient Smtp = new SmtpClient("smtp.gmail.com", 587);
            MailMessage mail = new MailMessage("employee.management.system010@gmail.com", txtTo.Text, txtSubject.Text, richTextBody.Text);
            if (lblFile.Text != "")
            {
                Attachment file = new Attachment(lblFile.Text);
                mail.Attachments.Add(file);
            }
            Smtp.EnableSsl = true;
            //Smtp.UseDefaultCredentials = true;
            Smtp.Credentials = new System.Net.NetworkCredential("employee.management.system010@gmail.com", "employee.management.system!!@");
            Smtp.Send(mail);
            txtTo.Clear();
            txtSubject.Clear();
            richTextBody.Clear();
            lblFile.Text = "";
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog opdFile = new OpenFileDialog();
            opdFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (opdFile.ShowDialog() == DialogResult.OK)
            {
                lblFile.Text = opdFile.FileName;
            }
        }

        private void newEmail_Load(object sender, EventArgs e)
        {
            if (to != "" || subject != "")
            {
                txtTo.Text = to;
                txtSubject.Text = subject;
            }
        }
    }
}
