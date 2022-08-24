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
using EMS_Library.MyEmployee.HoursLog;

namespace EMS_Client.Forms
{
    public partial class EditHours : Form
    {
        HoursLogEntry _entry;
        public EditHours()
        {
            InitializeComponent();
        }
        public EditHours(HoursLogEntry entry)
        {
            InitializeComponent();
            _entry = entry;
            bool startCheck = _entry.Start < dateTimeEntey.MinDate || _entry.Start > dateTimeEntey.MaxDate;
            bool endCheck = _entry.End > dateTimeEntey.MaxDate || _entry.End < dateTimeEntey.MinDate;
            dateTimeEntey.Value = startCheck? dateTimeEntey.MinDate : _entry.Start;
            dateTimeExit.Value = endCheck ? dateTimeEntey.MaxDate : _entry.End;
        }

        #region Buttons
        private void btnSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"entry: {dateTimeEntey.Value}\n exit: {dateTimeExit.Value}");
            DateTime newEntry = dateTimeEntey.Value, newExit = dateTimeExit.Value;
            Dictionary<Label, bool> invalidation = new Dictionary<Label, bool>()
            {
                { lblEntry, newEntry>EMS_Library.Config.MinDate && newEntry < newExit },
                { lblExit, newExit>EMS_Library.Config.MinDate && newEntry<newExit}
            };




            if (invalidation.Values.Contains(false))
            {
                foreach(KeyValuePair<Label,bool> label in invalidation)
                {
                    if(label.Value) label.Key.ForeColor = Color.DodgerBlue;
                    else label.Key.ForeColor = Color.Red;
                }
            }
            else
            {
                string querry = Requests.UpdateEntry(_entry.IntId.ToString(), newEntry, newExit);
                string[] x = Requests.RequestFromServer(querry, 7);
                Close();
            }
        }
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
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panelEditHours_MouseDown(object sender, MouseEventArgs e) => Drag(e);
        #endregion

    }
}
