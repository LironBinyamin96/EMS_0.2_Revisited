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
    public partial class EmpsByStatus : Form
    {
        public EmpsByStatus()
        {
            InitializeComponent();
        }

        private void statusBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte status;
            switch (statusBox.Text)
            {
                default: { return; }
                case "Not employed": { status = 0; break; }
                case "On site": { status = 1; break; }
                case "At home": { status = 2; break; }
            }

            employeesTable.Rows.Clear();
            string[] buffer = Requests.RequestFromServer(Requests.GetAllOfStatus(status), 1);
            if (buffer != null && buffer[0] != "-1")
                foreach (string item in buffer)
                {
                    string[] newItem = item.Split(',');
                    employeesTable.Rows.Add(newItem[0], newItem[1], newItem[2], newItem[3], newItem[4], newItem[5], newItem[6], newItem[8], newItem[9], newItem[11], newItem[12], newItem[13], newItem[14], newItem[15]);
                }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

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

        private void lblSearchByStatus_MouseDown(object sender, MouseEventArgs e) => Drag(e);
        private void EmpsByStatus_MouseDown(object sender, MouseEventArgs e) => Drag(e);
        #endregion
    }
}
