using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EMS_Library;

namespace EMS_Client.Forms
{
    public partial class ExceptionsScreen : Form
    {
        string[] _data;
        public ExceptionsScreen()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void ExceptionsScreen_Load(object sender, EventArgs e)
        {
            _data = Requests.RequestFromServer(Requests.GetAllExceptions(), 8);
            if (_data != null)
            {
                try
                {
                    foreach (string item in _data)
                        exceptionsTable.Rows.Add(item.Split(','));
                }
                catch { }
            }
        }

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
        private void ExceptionsScreen_MouseDown(object sender, MouseEventArgs e) => Drag(e);
        #endregion

        private void exceptionsTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (_data != null)
            {
                Point cellCoordinates = exceptionsTable.CurrentCellAddress;
                EditHours editHours = new EditHours(new EMS_Library.MyEmployee.HoursLog.HoursLogEntry(_data[cellCoordinates.Y]));
                editHours.Show();
            }
        }
    }
}
