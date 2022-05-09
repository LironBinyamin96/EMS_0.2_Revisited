using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EMS_Library.MyEmployee;

namespace EMS_Client.Forms
{
    public partial class addEmployee : Form
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
        private void panelAddEmployee_MouseDown(object sender, MouseEventArgs e) => Drag(e);
        private void lblAddEmployee_MouseDown(object sender, MouseEventArgs e) => Drag(e);
        #endregion
        public addEmployee()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> buffer = new List<string>();
            Action getIdAction = Requests.BuildAction(this,new EMS_Library.Network.DataPacket("", 252), buffer);
            getIdAction.Invoke();
            object[] empParts = new object[] {
                positionBox.Text,
                buffer[0],
                txtID.Text,
                txtFirstName.Text,
                txtLastName.Text,
                txtMiddleName.Text,
                "PasswordPlaceholder",
                txtEmail.Text,
                txtGender.Text,
                txtDateOfBirth.Text,
                DateTime.Now, //created at
                "1", //status
                txtBaseSalary.Text,
                txtSalaryModifire.Text,
                txtPhone.Text
            };
            buffer.Clear();
            Employee emp = Employee.ActivateEmployee(empParts);
            string querry = Requests.AddEmployee(emp);
            
            Action AddEmpAction = Requests.BuildAction(this, new EMS_Library.Network.DataPacket(emp.ToString(),2), buffer);
            AddEmpAction.Invoke();
        }
        public void Clear()
        {
            txtID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMiddleName.Text = "";
            txtGender.Text = "";
            txtDateOfBirth.Text = "";
            txtAddres.Text = "";
            txtPhone.Text = "";
            txtFile.Text = "";
            txtBaseSalary.Text = "";
            txtSalaryModifire.Text = "";
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
