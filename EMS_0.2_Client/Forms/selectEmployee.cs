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
using EMS_Library.Network;
using EMS_Library.MyEmployee;

namespace EMS_Client.Forms
{
    public partial class selectEmployee : Form
    {
        #region Variables
        List<string> buffer = new List<string>();
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
        private void panelSelectEmployee_MouseDown(object sender, MouseEventArgs e) => Drag(e);
        private void lblSelectEmployee_MouseDown(object sender, MouseEventArgs e) => Drag(e);

        #endregion
        public selectEmployee()
        {
            InitializeComponent();
        }
        private void btnSaerch_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtSaerch.Text.Length.ToString());
            
        }
        // הצגת כל העובדים בטבלה
        private void selectEmployee_Load(object sender, EventArgs e)
        {
            if (EMS_Library.Config.flag)
            {
             string querry = Requests.SelectEmployee();
                
                Action action = Requests.BuildAction(this, new DataPacket(querry, 1), buffer, false);
                action.Invoke();

            foreach (string item in buffer) 
                {
                string[] newItem = item.Split(',');
                employeesTable.Rows.Add(newItem[0], newItem[1], newItem[2], newItem[3], newItem[4], newItem[5], newItem[6], newItem[8], newItem[9], newItem[11], newItem[12], newItem[13], newItem[14], newItem[15]);
                }
            }
            
   
        }
        // בדאבל קליק - העובד שלחצנו עליו ייכנס לתוך משתנה סטטי שנמצא במסך הראשי
        private void employeesTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indexRow = employeesTable.CurrentCell.RowIndex;
            MessageBox.Show(indexRow.ToString());
            EMS_ClientMainScreen.employee = Employee.ActivateEmployee(buffer[indexRow].Remove(buffer[indexRow].Length - 1).Split(','));
            MessageBox.Show(EMS_ClientMainScreen.employee.ToString());
            Close();
        }
        private void btnX_Click(object sender, EventArgs e) => Close();   
    }
}