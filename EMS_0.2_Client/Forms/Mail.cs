using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S22.Imap;

namespace EMS_Client.Forms
{
    public partial class Mail : Form
    {
        public Mail()
        {
            InitializeComponent();
        }

        #region Supplemental

        /// <summary>
        /// התחברות למייל
        /// </summary>
        private void Mail_Load(object sender, EventArgs e)
        {
            Task getMail = new Task(() =>
            {
                using (ImapClient client = new ImapClient("imap.gmail.com", 993, "employee.management.system010@gmail.com", "wcvyicyfscoiqfgr", AuthMethod.Auto, true))
                {
                    var uids = client.Search(SearchCondition.All());
                    var messages = client.GetMessages(uids);

                    foreach (var mail in messages)
                    {
                        string subject = mail.Subject;
                        string body = mail.Body;
                        string from = Convert.ToString(mail.From);
                        string output = from.Substring(from.IndexOf("<") + 1, from.IndexOf(">") - from.IndexOf("<") - 1);
                        try { this.Invoke((MethodInvoker)delegate { inbox.Rows.Add(output, subject, body); }); }
                        catch { }
                    }
                }
            });
            getMail.Start();
        }
        #endregion

        /// <summary>
        /// פתיחת חלון של מייל חדש
        /// </summary>
        private void btnNewEmail_Click(object sender, EventArgs e)
        {
            newEmail ne = new newEmail();
            ne.Show();
        }

        /// <summary>
        /// פתיחת מייל לקריאה
        /// </summary>
        private void inbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (DataGridViewRow item in inbox.SelectedRows)
            {
                string[] fullMessage = new string[3]
                {
                    item.Cells[0].Value.ToString(),
                    item.Cells[1].Value.ToString(),
                    item.Cells[2].Value.ToString()
                };
                showMail ShowMAil = new showMail(fullMessage);
                ShowMAil.Show();
            }
        }
    }
}
