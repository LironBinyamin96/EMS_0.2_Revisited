using EMS_Library;
using EMS_Library.MyEmployee.HoursLog;
using System.Runtime.InteropServices;

namespace EMS_Client.Forms
{
    public partial class EditHours : Form
    {
        HoursLogEntry _entry;
        bool _changingEntry;
        public EditHours(HoursLogEntry entry)
        {
            InitializeComponent();
            dateTimeEntey.MaxDate = DateTime.Now;
            dateTimeExit.MaxDate = DateTime.Now;
            _entry = entry;
            dateTimeEntey.Value = entry.Start > DateTime.MinValue && entry.Start < DateTime.MaxValue ? entry.Start : DateTimePicker.MinimumDateTime;
            dateTimeExit.Value = entry.End > DateTime.MinValue && entry.End < DateTime.MaxValue ? entry.End : DateTimePicker.MinimumDateTime;
            radioEntry.Checked = true;

        }

        #region Buttons

        /// <summary>
        /// Saves the data.
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_changingEntry)
            {
                if (dateTimeEntey.Value > Config.MinDate && dateTimeEntey.Value < _entry.End)
                {
                    string temp = Requests.UpdateEntry(_entry.IntId.ToString(), dateTimeEntey.Value, _entry.End);
                    Requests.RequestFromServer(temp, 7);
                    Close();
                }
                else radioEntry.ForeColor = Color.Red;
            }
            else
            {
                if (dateTimeExit.Value < DateTime.MaxValue && dateTimeExit.Value > _entry.Start)
                {
                    string temp = Requests.UpdateEntry(_entry.IntId.ToString(), _entry.Start, dateTimeExit.Value);
                    Requests.RequestFromServer(temp, 7);
                    Close();
                }
                else radioExit.ForeColor = Color.Red;
            }
            EMS_ClientMainScreen.PrimaryForms.Pop();
            if (EMS_ClientMainScreen.PrimaryForms is ExceptionsScreen)
                (EMS_ClientMainScreen.PrimaryForms.Pop() as ExceptionsScreen).PopulateExceptionsTable();
        }

        /// <summary>
        /// Switching between states.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioEntry_CheckedChanged(object sender, EventArgs e)
        {
            _changingEntry = (sender as RadioButton).Checked;
            if (_changingEntry) { dateTimeExit.Enabled = false; dateTimeEntey.Enabled = true; }
            else { dateTimeExit.Enabled = true; dateTimeEntey.Enabled = false; }
            radioExit.ForeColor = Color.DodgerBlue;
            radioEntry.ForeColor = Color.DodgerBlue;
        }

        /// <summary>
        /// Close form
        /// </summary>
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
