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
        string[] buffer;
        Form callerForm;
        #endregion

        public selectEmployee(Form caller)
        {
            InitializeComponent();
            callerForm = caller;
        }

        /// <summary>
        /// Method called by OnLoad event.
        /// </summary>
        private void selectEmployee_Load(object sender, EventArgs e)
        {
            //In "Developement mode" request all employees from the DB on screen load.
            if (Config.DevelopmentMode)
            {
                string querry = Requests.SelectEmployee();
                buffer = Requests.RequestFromServer(querry, 1);
                foreach (string item in buffer)
                {
                    string[] newItem = item.Split(',');
                    employeesTable.Rows.Add(newItem[0], newItem[1], newItem[2], newItem[3], newItem[4], newItem[5], newItem[6], newItem[8], newItem[9], newItem[11], newItem[12], newItem[13], newItem[14], newItem[15]);
                }
            }
        }

        /// <summary>
        /// Requests chosen employee from the server and stores in as global variable.
        /// </summary>
        private void employeesTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string empId = employeesTable.Rows[employeesTable.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string empData = Array.Find(buffer, x => x.Contains(empId));
            if (empData == null || empData == default) return;
            EMS_ClientMainScreen.employee = Employee.ActivateEmployee(empData.Remove(empData.Length - 1).Split(','));

            //Invoke Fill() method of callerForm if available
            System.Reflection.MethodInfo fillMethod = callerForm.GetType().GetMethod("Fill");
            if (fillMethod != null) fillMethod.Invoke(callerForm, null);

            callerForm.Activate();
            Close();
        }

        #region Buttons
        private void btnSaerch_Click(object sender, EventArgs e)
        {
            string querry = "";
            switch (comboBoxSelect.SelectedIndex)
            {
                default: return;
                /*All*/    case 0: { querry = Requests.SelectEmployee(); break; }
                /*ID*/     case 1: { querry = txtSaerch.Text != "" ? Requests.SelectEmployee("and", new string[][] { new string[] { "_intId", $"{txtSaerch.Text}" } }) : Requests.SelectEmployee(); break; }
                /*_fName*/ case 2: { querry = txtSaerch.Text != "" ? Requests.SelectEmployee("and", new string[][] { new string[] { "_fName", $"'{txtSaerch.Text}'" } }) : Requests.SelectEmployee(); break; }
                /*_lName*/ case 3: { querry = txtSaerch.Text != "" ? Requests.SelectEmployee("and", new string[][] { new string[] { "_lName", $"'{txtSaerch.Text}'" } }) : Requests.SelectEmployee(); break; }
                /*type*/   case 4: { querry = txtSaerch.Text != "" ? Requests.SelectEmployee("and", new string[][] { new string[] { "type", $"'{txtSaerch.Text}'" } }) : Requests.SelectEmployee(); break; }
            }
            buffer = Requests.RequestFromServer(querry, 1);
            employeesTable.Rows.Clear();
            employeesTable.Columns.Clear();
            employeesTable.Columns.AddRange(new DataGridViewColumn[]
            {
                Type,
                intID,
                StateID,
                FirstName,
                LastName,
                MiddelName,
                Email,
                Gender,
                Birthday,
                Position,
                BaseSalary,
                SalaryModifire,
                Phone,
                Address
            });
            foreach (string item in buffer)
            {
                List<string> empData = item.Split(',').ToList();
                empData.RemoveAt(7);
                empData.RemoveAt(9);
                employeesTable.Rows.Add(empData.ToArray());
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
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panelSelectEmployee_MouseDown(object sender, MouseEventArgs e) => Drag(e);
        private void lblSelectEmployee_MouseDown(object sender, MouseEventArgs e) => Drag(e);

        #endregion


    }
}