using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS_Client.Forms
{
    public partial class showMail : Form
    {
        public showMail()
        {
            InitializeComponent();
        }
        string sub, body, form;

        private void showMail_Load(object sender, EventArgs e)
        {
            txtForm.Text = form;
            txtSubject.Text = sub;
            richTextBody.Text = body;
        }

        private void btnX_Click(object sender, EventArgs e) => Close();

        public showMail(string[] fullMessage)
        {
            InitializeComponent();
            this.form = fullMessage[0];
            this.sub = fullMessage[1];
            this.body = fullMessage[2];
        }

        private void btnReply_Click(object sender, EventArgs e)
        {
            newEmail newEmail = new newEmail(form, sub);
            newEmail.Show();
        }
    }
}
