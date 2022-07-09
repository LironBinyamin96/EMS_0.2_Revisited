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
        string sub, body, form;

        public showMail()
        {
            InitializeComponent();
        }
        public showMail(string[] fullMessage)
        {
            InitializeComponent();
            form = fullMessage[0];
            sub = fullMessage[1];
            body = fullMessage[2];
        }

        private void showMail_Load(object sender, EventArgs e)
        {
            txtForm.Text = form;
            txtSubject.Text = sub;
            richTextBody.Text = body;
        }

        #region Buttons
        private void btnX_Click(object sender, EventArgs e) => Close();
        private void btnReply_Click(object sender, EventArgs e)
        {
            newEmail newEmail = new newEmail(form, sub);
            newEmail.Show();
        }
        #endregion
    }
}
