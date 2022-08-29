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

namespace EMS_Client.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            if (Config.DevelopmentMode)
            {
                txtIntId.Text = Config.DefaultId;
                txtPassword.Text = Config.DefaultPassword;
            }
        }

        #region Buttons
        private void btnLogin_Click(object sender, EventArgs e)
        {
            CancellationTokenSource CXL_Src = new CancellationTokenSource();
            CancellationToken CXL = CXL_Src.Token;

            //Credentials format check
            if (!txtIntId.Text.Parsable(typeof(int)))
            { MessageBox.Show("Wrong credentials"); return; }

            string querry = Requests.SelectEmployee(new Dictionary<string, string>
            {
                {"_intId", txtIntId.Text},
                {"_password",$"'{txtPassword.Text}'" }
            });
            string[] buffer = Requests.RequestFromServer(querry, 1);

            //Credentials check
            if (buffer.Length == 0 || buffer[0] == "-1")
            {
                Employee emp = Employee.ActivateEmployee(buffer[0].Split(','));
                if (!(emp is EMS_Library.MyEmployee.IAccess.IExtendedAccess))
                {
                    MessageBox.Show("Wrong credentials");
                    return;
                }
            }

            EMS_ClientMainScreen.CurEmployee = Employee.ActivateEmployee(buffer[0].Split(','));
            Close();
        }
        private void lblExit_Click(object sender, EventArgs e)
        {
            while (EMS_ClientMainScreen.PrimaryForms.TryPop(out Form result))
                result.Close();
        }

        private void txtIntId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnLogin.PerformClick();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnLogin.PerformClick();
        }
        #endregion

        #region Supplemental
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
