using EMS_Library;
using System.Net;
using System.Net.Mail;

namespace EMS_Client.Forms
{
    public partial class newEmail : Form
    {
        string to;
        string subject;

        /// <summary>
        /// NewEmail constructor | בנאי להודעה חדשה
        /// </summary>
        public newEmail()
        {
            InitializeComponent();
        }

        /// <summary>
        /// NewEmail constructor | בנאי להשיב למייל
        /// </summary>
        public newEmail(string to, string subject)
        {
            InitializeComponent();
            this.to = to;
            this.subject = subject;
            EMS_ClientMainScreen.PrimaryForms.Push(this);
        }

        /// <summary>
        /// Method called by the OnLoad event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newEmail_Load(object sender, EventArgs e)
        {
            if (to != "" || subject != "")
            {
                txtTo.Text = to;
                txtSubject.Text = subject;
            }
        }

        /// <summary>
        /// Validating relevant fields and changing thier colors appropriately.
        /// אימות שדות רלוונטיים ושינוי הצבעים שלהם כראוי.
        /// </summary>
        private bool CheckingDataFields()
        {
            //Aggrigation of the controlls and their vilidity status into singular collection.
            // בדיקת תקינות הנתונים באמצעות מיליון פאנלים ובדיקות
            Dictionary<Panel, bool> test = new Dictionary<Panel, bool>();
            test.Add(panelTo, txtTo.Text.Parsable(typeof(MailAddress)));
            test.Add(panelSubject, txtSubject.Text.Length > 2);

            //Prefoms serach for fields with invalid data and coloring them appropriately while aggregating validity status.
            // חיפוש שדות עם נתונים לא חוקיים ושינוי צבע הפאנל שלהם לאדום
            bool res = true;
            foreach (KeyValuePair<Panel, bool> item in test)
            {
                if (!item.Value) { item.Key.BackColor = Color.FromArgb(255, 102, 102); res &= false; }
                else { item.Key.BackColor = Color.FromArgb(0, 126, 249); res &= true; }
            }

            return res;
        }

        /// <summary>
        /// Filling fields with data.
        /// מילוי השדות בנתונים
        /// </summary>
        public void Fill() => txtTo.Text = EMS_ClientMainScreen.employee.Email;



        #region Buttons
        /// <summary>
        ///Sending the email | שליחת המייל
        /// </summary>
        private void btnSend_Click(object sender, EventArgs e)
        {
            // Checking that the recipient and subject fields of the email are not empty
            // בדיקה ששדות נמען ונושא המייל לא ריקים
            if (!CheckingDataFields()) return;

            //Creating the email and sending it
            // יצירת ההמייל ושליחתו
            //user - "employee.management.system010@gmail.com", pass - "employee.management.system!!@" "generated: wcvyicyfscoiqfgr"
            SmtpClient Smtp = new SmtpClient("smtp.gmail.com", 587);
            MailMessage mail = new MailMessage(Config.EMS_EmailAddress, txtTo.Text, txtSubject.Text, richTextBody.Text);
            if (lblFile.Text != "")
            {
                Attachment file = new Attachment(lblFile.Text);
                mail.Attachments.Add(file);
            }
            Smtp.EnableSsl = true;
            Smtp.Credentials = new NetworkCredential(Config.EMS_EmailAddress, Config.EMA_EmailPassword);
            Smtp.Send(mail);
            txtTo.Clear();
            txtSubject.Clear();
            richTextBody.Clear();
            lblFile.Text = "";
            EMS_ClientMainScreen.PrimaryForms.Pop().Close();
        }

        /// <summary>
        /// הוספת קובץ למייל
        /// Adding a file to an email
        /// </summary>
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

        /// <summary>
        /// Method for mass email sending. | שליחת הודעת תפוצה
        /// </summary>
        private void btnSendToAll_Click(object sender, EventArgs e) => txtTo.Text = Requests.RequestFromServer(Requests.GetAllEmails(), 9).ArrayToString();
        private void btnX_Click(object sender, EventArgs e) => Close();

        #endregion

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
