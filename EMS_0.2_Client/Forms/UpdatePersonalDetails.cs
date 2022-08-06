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
    public partial class UpdatePersonalDetails : Form
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
        private void panelUpdatePersonalDetails_MouseDown(object sender, MouseEventArgs e) => Drag(e);
        private void lblUpdatePersonalDetails_MouseDown(object sender, MouseEventArgs e) => Drag(e);

        #endregion
        Control[] activeControls;
        public UpdatePersonalDetails()
        {
            InitializeComponent();
            activeControls = new Control[] {
                txtID, txtFirstName , txtLastName, txtMiddleName,
                txtGender,txtDateOfBirth,txtAddres,txtPhone,
                txtBaseSalary,txtSalaryModifire,txtEmail,positionBox,txtFile,pictureBox1
            };
        }
        private void UpdatePersonalDetails_Activated(object sender, EventArgs e)
        {
            if (EMS_ClientMainScreen.employee != null) Fill();
        }

        #region Buttons
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckingDataFields())
            {
                Employee tempEmp = Employee.ActivateEmployee(new object[] {
                    positionBox.Text,
                    EMS_ClientMainScreen.employee.IntId,
                    txtID.Text,
                    txtFirstName.Text,
                    txtLastName.Text,
                    txtMiddleName.Text,
                    txtEmail.Text,
                    EMS_ClientMainScreen.employee.Password,
                    txtGender.Text,
                    txtDateOfBirth.Text,
                    EMS_ClientMainScreen.employee.Created,
                    EMS_ClientMainScreen.employee.EmploymentStatus,
                    txtBaseSalary.Text,
                    txtSalaryModifire.Text,
                    txtPhone.Text,
                    txtAddres.Text
                    });

                Employee hold = tempEmp;
                if(tempEmp.ToString()!=EMS_ClientMainScreen.employee.ToString())
                {
                    string querry = Requests.UpdateEmployee(tempEmp.ProvideFieldsAndValues(), new Dictionary<string, string> { { "_intId", EMS_ClientMainScreen.employee.IntId.ToString() } });
                    string[] buffer = Requests.RequestFromServer(querry, 3);
                    MessageBox.Show("Updated: " + buffer[0]);
                }
            }
            else MessageBox.Show("Incorrect format!");
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            selectEmployee select_Employee = new selectEmployee(this);
            select_Employee.Show();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show("Are you sure?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (delete == DialogResult.OK)
            {
                
                string querry = Requests.Delete(int.Parse(txtID.Text));
                string[] buffer = Requests.RequestFromServer(querry,4);
                Clear();
            }
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = $"picture |*{EMS_Library.Config.ImageFormat}| all files|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.InitialDirectory = "c:\\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtFile.Text = openFileDialog1.FileName;
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            EMS_ClientMainScreen.employee = null;
            Close();
        }
        #endregion

        private bool CheckingDataFields()
        {
            Dictionary<Panel, bool> test = new Dictionary<Panel, bool>() {
                { panelID, txtID.Text.Parsable(typeof(int)) },
                { panelFname, txtFirstName.Text.Length > 1 },
                { panelLname, txtLastName.Text.Length > 1 },
                { panelDate, txtDateOfBirth.Text.Parsable(typeof(DateTime)) },
                { panelAddres, txtAddres.Text.Length > 1 },
                { panelPhone, txtPhone.Text.Parsable(typeof(int)) },
                { panelEmail, txtEmail.Text.Parsable(typeof(System.Net.Mail.MailAddress)) },
                { panelBaseSalary, txtBaseSalary.Text.Parsable(typeof(int)) },
                { panelSalaryModifire, txtSalaryModifire.Text.Parsable(typeof(double)) },
                { panelPosition, positionBox.Text != "" },
                { panelUpload, pictureBox1 != null }
            };
            foreach (KeyValuePair<Panel, bool> item in test)
            {
                if (!item.Value) item.Key.BackColor = Color.FromArgb(255, 102, 102);
                else { item.Key.BackColor = Color.FromArgb(0, 126, 249); }
            }
            return !test.Values.Contains(false);
        }

        #region Supplimental
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
            positionBox.Text = "";
            txtBaseSalary.Text = "";
            txtSalaryModifire.Text = "";
            txtEmail.Text = "";
            pictureBox1.Image = null;
        }
        public void Fill()
        {
            if (EMS_ClientMainScreen.employee != null)
            {
                txtID.Text = EMS_ClientMainScreen.employee.StateId.ToString();
                txtFirstName.Text = EMS_ClientMainScreen.employee.FName.ToString();
                txtLastName.Text = EMS_ClientMainScreen.employee.LName.ToString();
                txtMiddleName.Text = EMS_ClientMainScreen.employee.MName.ToString();
                txtEmail.Text = EMS_ClientMainScreen.employee.Email.ToString();
                txtGender.Text = EMS_ClientMainScreen.employee.Gender.ToString();
                txtDateOfBirth.Text = EMS_ClientMainScreen.employee.BirthDate.ToString();
                txtAddres.Text = EMS_ClientMainScreen.employee.Address.ToString();
                txtPhone.Text = EMS_ClientMainScreen.employee.PhoneNumber.ToString();
                positionBox.Text = EMS_ClientMainScreen.employee.Type.Name;
                txtBaseSalary.Text = EMS_ClientMainScreen.employee.BaseSalary.ToString();
                txtSalaryModifire.Text = EMS_ClientMainScreen.employee.SalaryModifire.ToString();
                try { pictureBox1.Image = new Bitmap(EMS_Library.Config.FR_Images + $"\\{EMS_ClientMainScreen.employee.IntId}{EMS_Library.Config.ImageFormat}"); } catch { }
            }
        }
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Fill();
            Panel[] panelArr = new Panel[] { panelID, panelFname, panelLname, panelDate, panelAddres, panelPhone, panelEmail, panelBaseSalary
                ,panelSalaryModifire,panelPosition,panelUpload };
            foreach (Panel panel in panelArr)
                panel.BackColor = Color.FromArgb(0, 126, 249);

        }
    }
}