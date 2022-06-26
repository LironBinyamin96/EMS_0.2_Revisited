using System;
using System.Runtime.InteropServices;
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
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panelEditHours_MouseDown(object sender, MouseEventArgs e) => Drag(e);


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
        private void Fill()
        {
            lblDay.Text = editHours[1];
            dateTimeEntey.Value = DateTime.Parse($"{lblDay.Text} {editHours[2]}");
            dateTimeExit.Value = DateTime.Parse($"{lblDay.Text} {editHours[3]}");
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"entry: {dateTimeEntey.Value}\n exit: {dateTimeExit.Value}");
            string querry = Requests.UpdateEntry(editHours[0], dateTimeEntey.Value, dateTimeExit.Value);
            List<string> buffer = new List<string>();
            Action action = Requests.BuildAction(this, new EMS_Library.Network.DataPacket(querry, 7), buffer,true);
            StandbyScreen standby = new StandbyScreen(action);
            standby.ShowDialog();
        }
        private void EditHours_Load(object sender, EventArgs e)
        {
            Fill();
        }

        private void btnX_Click(object sender, EventArgs e) => Close();


    }
}
