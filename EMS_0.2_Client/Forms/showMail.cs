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
        /// <summary>
        /// Showing the email | הצגת המייל
        /// </summary>
        /// <param name="fullMessage"></param>
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

        // Reply to sender | השב לשולח
        private void btnReply_Click(object sender, EventArgs e)
        {
            newEmail newEmail = new newEmail(form, sub);
            newEmail.Show();
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
        private void panelMail_MouseDown_1(object sender, MouseEventArgs e) => Drag(e);
        private void lblMail_MouseDown_1(object sender, MouseEventArgs e) => Drag(e);
        #endregion
    }
}
