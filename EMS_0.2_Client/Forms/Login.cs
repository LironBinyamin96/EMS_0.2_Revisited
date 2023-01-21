using EMS_Library;
using EMS_Library.MyEmployee;
using EMS_Library.MyEmployee.IAccess;
using System.Net;
using System.Net.Mail;

namespace EMS_Client.Forms
{
    public partial class Login : Form
    {
        #region Variables
        private string passcode;
        private Employee logingInEmp;
        #endregion

        public Login()
        {
            InitializeComponent();
            if (Config.PresentationMode || Config.DevelopmentMode)
            {
                Employee randomEmp = null;
                do randomEmp = Employee.ActivateEmployee(Requests.RequestFromServer($"SELECT TOP 1 * FROM {Config.EmployeeDataTable} ORDER BY NEWID();", 254)[0].Split(','));
                while (randomEmp == null || !(randomEmp is IRootAccess || randomEmp is IExtendedAccess));
                EMS_ClientMainScreen.CurEmployee = randomEmp;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if(Config.DevelopmentMode) Close();
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        #region Buttons
        /// <summary>
        /// Handles user authentication. (Called by btnLogin button).
        /// אימות משתמש
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Credentials format check | בדיקה שתעודת זהות היא מספר 
            if (!txtIntId.Text.Parsable(typeof(int)))
            { MessageBox.Show("Wrong credentials"); return; }

            //Request employee data from the server. | בקשת נתוני העובד מהשרת
            string querry = Requests.SelectEmployee(new string[][]
            {
                new string[]{"_intId", txtIntId.Text},
                new string[]{"_password",$"'{ txtPassword.Text}'" }
            }, "and");
            string[] buffer = Requests.RequestFromServer(querry, 1);

            //Try to reconstruct employee from recieved data. If failed to verify with DB for any
            //reason (failed connection, wrong cridentials, etc.) employee activator will fail and return null. 
            // בדיקה האם עובד קיים ואם נתונים שהזין נכונים
            logingInEmp = Employee.ActivateEmployee(buffer[0].Split(','));
            if (logingInEmp == null)
            {
                MessageBox.Show("Wrong credentials.");
                return;
            }

            //Checking if the employee has access to the system. | בדיקת הרשאות התחברות
            if (!(logingInEmp is IExtendedAccess))
            {
                MessageBox.Show("You do not have propper access to use this software.\nAccess denied.");
                return;
            }

            //Second phase in two-factor authentication. | מעבר לאימות דו שלבי
            panelLogin.Visible = false;
            panelPasscode.Visible = true;
            txtPasscode.Focus();

            //Send the passcode to employee's email address. | שליחת הקוד למייל
            Action twoFactorAuth = () => {
                SmtpClient Smtp = new SmtpClient("smtp.gmail.com", 587);
                MailMessage mail = new MailMessage(Config.EMS_EmailAddress, logingInEmp.Email, "Verification code from employee management system", Generatepasscode());
                Smtp.EnableSsl = true;
                Smtp.Credentials = new NetworkCredential(Config.EMS_EmailAddress, Config.EMA_EmailPassword);
                Smtp.Send(mail);
                (Array.Find(EMS_ClientMainScreen.PrimaryForms.ToArray(), x => x is EMS_ClientMainScreen) as EMS_ClientMainScreen).Invoke(() => EMS_ClientMainScreen.PrimaryForms.Pop().Close());
            };
            StandbyScreen standby = new StandbyScreen(twoFactorAuth);
            standby.ShowDialog();
            GC.Collect();
        }
        private void btnSendAgain_Click(object sender, EventArgs e)
        {
            //Send the passcode to employee's email address.
            //שלח את קוד הגישה לכתובת המייל של העובד.
            SmtpClient Smtp = new SmtpClient("smtp.gmail.com", 587);
            MailMessage mail = new MailMessage(Config.EMS_EmailAddress, logingInEmp.Email, "Verification code from employee management system", Generatepasscode());
            Smtp.EnableSsl = true;
            Smtp.Credentials = new NetworkCredential(Config.EMS_EmailAddress, Config.EMA_EmailPassword);
            Smtp.Send(mail);
        }

        /// <summary>
        /// Compare user provided and system generated passcodes. (Called by btnLoginPasscode button.)
        /// השוואה בין קוד רנדומלי שסופק לקוד שהוזן על ידי המשתמש
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoginPasscode_Click(object sender, EventArgs e)
        {
            if (passcode == txtPasscode.Text)
            {
                EMS_ClientMainScreen.CurEmployee = logingInEmp;
                Close();
            }
            else
            {
                MessageBox.Show("Incorrect passcode");
                panelLogin.Visible = true;
                panelPasscode.Visible = false;
            }
        }

        /// <summary>
        /// Method for closing programm from login screen. (Called by X button)
        /// סגירת תוכנית ממסך הכניסה.
        /// </summary>
        private void lblExit_Click(object sender, EventArgs e)
        {
            while (EMS_ClientMainScreen.PrimaryForms.TryPop(out Form result))
                result.Close();
        }
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
        private void lblProgrammName_MouseDown(object sender, MouseEventArgs e) => Drag(e);
        private void Login_MouseDown(object sender, MouseEventArgs e) => Drag(e);

        #endregion


        //Allowing for use of "Enter" key for switching to the next field.
        //בשביל לעבור לשדה הבא "Enter" שימוש בכפתור  
        private void txtIntId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtPassword.Focus();
            }
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnLogin.PerformClick();
            }
        }
        private void txtPasscode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnLoginPasscode.PerformClick();
            }
        }
        // Change the background color in the relevant field
        // שינוי צבע הרקע בשדה הרלוונטי
        private void txtIntId_Click(object sender, EventArgs e)
        {
            txtIntId.BackColor = Color.White;
            panelUser.BackColor = Color.White;
            panelPassword.BackColor = Color.LightGray;
            txtPassword.BackColor = Color.LightGray;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
            panelPassword.BackColor = Color.White;
            panelUser.BackColor = Color.LightGray;
            txtIntId.BackColor = Color.LightGray;
        }
        private void txtPasscode_Click(object sender, EventArgs e)
        {
            txtPasscode.BackColor = Color.White;
            panelPasscodeText.BackColor = Color.White;
        }

        private string Generatepasscode()
        {
            //Generate passcode. | יצירת קוד רנדומלי
            passcode = Utility.RandomNumericString(6);

            if (Config.DevelopmentMode) //Bypasses two-factor autentication
            {
                txtPasscode.Text = passcode;
                if (!Config.PresentationMode) return default ;
            }
            return passcode;
        }

        // View password
        // צפייה בסיסמא
        private void pictureBoxEye_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }
        //Stop viewing the password
        // הפסקת צפייה בסיסמא
        private void pictureBoxEye_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }


    }

}
