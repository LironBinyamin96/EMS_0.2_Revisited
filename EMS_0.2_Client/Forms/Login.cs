using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using EMS_Library;
using EMS_Library.Network;
using EMS_Library.MyEmployee;
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
            if (Config.DevelopmentMode)
            {
                txtIntId.Text = Config.DefaultId;
                txtPassword.Text = Config.DefaultPassword;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        #region Buttons
        /// <summary>
        /// Handles user authentication. (Called by btnLogin button).
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Credentials format check
            if (!txtIntId.Text.Parsable(typeof(int)))
            { MessageBox.Show("Wrong credentials"); return; }

            //Request employee data from the server.
            string querry = Requests.SelectEmployee(new Dictionary<string, string>
            {
                {"_intId", txtIntId.Text},
                {"_password",$"'{txtPassword.Text}'" }
            });
            string[] buffer = Requests.RequestFromServer(querry, 1);

            //Try to reconstruct employee from recieved data. If failed to verify with DB for any
            //reason (failed connection, wrong cridentials, etc.) employee activator will fail and return null. 
            logingInEmp = Employee.ActivateEmployee(buffer[0].Split(','));
            if (logingInEmp == null)
            {
                MessageBox.Show("Wrong credentials.");
                return;
            }

            //Checking if the employee has access to the system.
            if (!(logingInEmp is EMS_Library.MyEmployee.IAccess.IExtendedAccess))
            {
                MessageBox.Show("You do not have propper access to use this software.\nAccess denied.");
                return;
            }

            //Second phase in two-factor authentication.
            panelLogin.Visible = false;
            panelPasscode.Visible = true;

            //Generate passcode.
            passcode = Utility.RandomNumericString(6);
            if (Config.DevelopmentMode) //Bypasses two-factor autentication
            {
                txtPasscode.Text = passcode;
                return;
            }

            //Send the passcode to employee's email address.
            SmtpClient Smtp = new SmtpClient("smtp.gmail.com", 587);
            MailMessage mail = new MailMessage(Config.EMS_EmailAddress, logingInEmp.Email, "Verification code from employee management system", passcode);
            Smtp.EnableSsl = true;
            Smtp.Credentials = new NetworkCredential(Config.EMS_EmailAddress, Config.EMA_EmailPassword);
            Smtp.Send(mail);
        }

        /// <summary>
        /// Compare user provided and system generated passcodes. (Called by btnLoginPasscode button.)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoginPasscode_Click(object sender, EventArgs e)
        {
            if (passcode == txtPasscode.Text) { EMS_ClientMainScreen.CurEmployee = logingInEmp; Close(); }
            else
            {
                MessageBox.Show("Incorrect passcode");
                panelLogin.Visible = true;
                panelPasscode.Visible = false;
            }
        }

        /// <summary>
        /// Method for closing programm from login screen. (Called by X button)
        /// </summary>
        private void lblExit_Click(object sender, EventArgs e)
        {
            while (EMS_ClientMainScreen.PrimaryForms.TryPop(out Form result))
                result.Close();
        }

        //Allowing for use of Enter key for switching to the next field.
        private void txtIntId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //KeyChar 13 is the Enter key
                txtPassword.Focus();
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //KeyChar 13 is the Enter key
                btnLogin.PerformClick();
        }
        private void txtPasscode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //KeyChar 13 is the Enter key
                btnLoginPasscode.PerformClick();
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

    }

}
