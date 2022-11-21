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
        /// Email login
        /// התחברות למייל
        /// </summary>
        private void Mail_Load(object sender, EventArgs e)
        {
            Action getMail = () =>
            {
                using (ImapClient client = new ImapClient("imap.gmail.com", 993, "employee.management.system010@gmail.com", "wcvyicyfscoiqfgr", AuthMethod.Auto, true))
                {
                    var uids = client.Search(SearchCondition.All());
                    var messages = client.GetMessages(uids);

                    foreach (var mail in messages)
                    {
                        try
                        {
                            string subject = mail.Subject;
                            string body = mail.Body;
                            string from = Convert.ToString(mail.From);
                            string output = from.Substring(from.IndexOf("<") + 1, from.IndexOf(">") - from.IndexOf("<") - 1);
                            Invoke((MethodInvoker)delegate { inbox.Rows.Add(output, subject, body); });
                        }
                        catch { }
                    }
                }
                (Array.Find(EMS_ClientMainScreen.PrimaryForms.ToArray(), x => x is EMS_ClientMainScreen) as EMS_ClientMainScreen).Invoke(() => EMS_ClientMainScreen.PrimaryForms.Pop().Close());
            };
            StandbyScreen standby = new StandbyScreen(getMail);
            standby.Show();
            GC.Collect();
        }
        #endregion

        /// <summary>
        /// Opening a new email window
        /// פתיחת חלון של מייל חדש
        /// </summary>
        private void btnNewEmail_Click(object sender, EventArgs e)
        {
            newEmail ne = new newEmail();
            ne.Show();
        }

        /// <summary>
        /// Opening an email to read
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
