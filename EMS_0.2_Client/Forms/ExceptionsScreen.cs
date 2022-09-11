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
using EMS_Library.MyEmployee;

namespace EMS_Client.Forms
{
    public partial class ExceptionsScreen : Form
    {
        string[] _data; //Exceptions data reference
        Employee[] _empsData;
        public ExceptionsScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Close Form
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e) => Close();

        /// <summary>
        /// Method called by OnLoad event
        /// </summary>
        private void ExceptionsScreen_Load(object sender, EventArgs e)
        {
            //Request all entries with invalid data from DB
            _data = Requests.RequestFromServer(Requests.GetAllExceptions(), 8);
            if (_data[0] != "-1")
            {
                string[] ids = Array.ConvertAll(_data, x => x.Split(',')[0]).ToHashSet().ToArray();
                string[] empsData=Requests.RequestFromServer( Requests.SelectEmployee("or", Array.ConvertAll(ids, x => new string[] { "_intId", x })),1);
                _empsData = Array.ConvertAll(empsData, x => Employee.ActivateEmployee(x.Split(',')));
                if (_data != null)
                    try
                    {
                        foreach (string item in _data)
                        {
                            Employee emp = Array.Find(_empsData, x => x.IntId == int.Parse(item.Split(',')[0]));
                            if (emp != null)
                            {
                                string[] entryData = item.Split(',');
                                exceptionsTable.Rows.Add(new string[] { emp.LName, emp.FName, emp.Type.Name, entryData[0], entryData[1], entryData[2] });
                            }
                        }
                    }
                    catch { }
            }

        }
        /// <summary>
        /// Opens EditHours screen by double clicking on appropriate cell.
        /// </summary>
        private void exceptionsTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (_data != null)
            {
                Point cellCoordinates = exceptionsTable.CurrentCellAddress;
                EditHours editHours = new EditHours(new EMS_Library.MyEmployee.HoursLog.HoursLogEntry(_data[cellCoordinates.Y]));
                editHours.Show();
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

    }
}
