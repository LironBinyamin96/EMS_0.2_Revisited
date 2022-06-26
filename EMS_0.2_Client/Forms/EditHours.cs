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
    public partial class EditHours : Form
    {
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
        public EditHours()
        {
            InitializeComponent();
        }
        string[] editHours; 
        public EditHours(string[] arr)
        {
            InitializeComponent();
            editHours = arr;
        }
        public void fill()
        {
            txtDate.Text = editHours[1];
            txtEntry.Text = editHours[2];
            txtExit.Text = editHours[3];
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Requests.updateEntry(editHours[0], txtDate.Text, txtEntry.Text, txtExit.Text);
        }
        private void EditHours_Load(object sender, EventArgs e)
        {
            fill();
        }

        private void btnX_Click(object sender, EventArgs e) => Close();


    }
}
