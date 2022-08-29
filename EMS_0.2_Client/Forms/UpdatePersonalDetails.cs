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
        Control[] activeControls; //Collection of controlls for user interaction.
        public UpdatePersonalDetails()
        {
            InitializeComponent();
            activeControls = new Control[] {
                txtID, txtFirstName , txtLastName, txtMiddleName,
                txtGender,txtDateOfBirth,txtAddres,txtPhone,
                txtBaseSalary,txtSalaryModifire,txtEmail,positionBox,pictureBox1
            };
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
            select_Employee.ShowDialog();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show("Are you sure?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (delete == DialogResult.OK)
            {
                
                string querry = Requests.DeleteEmployee(EMS_ClientMainScreen.employee.IntId);
                string[] buffer = Requests.RequestFromServer(querry,4);
                Clear();
            }
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            string employeePicturePath = "";
            openFileDialog1.Filter = $"picture |*{Config.ImageFormat}| all files|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.InitialDirectory = "c:\\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                employeePicturePath = openFileDialog1.FileName;
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            EMS_ClientMainScreen.employee = null;
            Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Panel[] panelArr = new Panel[] { panelID, panelFname, panelLname, panelDate, panelAddres, panelPhone, panelEmail, panelBaseSalary
                ,panelSalaryModifire,panelPosition };
            foreach (Panel panel in panelArr)
                panel.BackColor = Color.FromArgb(0, 126, 249);

        }
        #endregion

        /// <summary>
        /// Prefforms validation of data provided by the user.
        /// </summary>
        /// <returns></returns>
        private bool CheckingDataFields()
        {
            //Aggrigation of the controlls and their vilidity status into singular collection.
            Dictionary<Control, bool> test = new Dictionary<Control, bool>() {
                { panelID, txtID.Text.IsStateID()},
                { panelFname, txtFirstName.Text.Length > 1 },
                { panelLname, txtLastName.Text.Length > 1 },
                { panelDate, txtDateOfBirth.Text.Parsable(typeof(DateTime)) && (DateTime.Now - DateTime.Parse(txtDateOfBirth.Text)).TotalDays / 365 >= 18 },
                { panelAddres, txtAddres.Text.Length > 1 },
                { panelPhone, txtPhone.Text.Parsable(typeof(int)) },
                { panelEmail, txtEmail.Text.Parsable(typeof(System.Net.Mail.MailAddress)) && (txtEmail.Text.Contains(".")) },
                { panelBaseSalary, txtBaseSalary.Text.Parsable(typeof(int))&& int.Parse(txtBaseSalary.Text)>0 },
                { panelSalaryModifire, txtSalaryModifire.Text.Parsable(typeof(double))&& double.Parse(txtSalaryModifire.Text)>0},
                { panelPosition, positionBox.Text != "" },
                { btnUpload,pictureBox1.Image != null }
            };

            //Prefoms scan through the collection and changing field colors appropriately while aggregating validity status.
            bool check = true;
            foreach (KeyValuePair<Control, bool> item in test)
            {
                if (item.Key is Button)
                {
                    if (!item.Value) { item.Key.ForeColor = Color.Red; check = false; }
                    else { item.Key.ForeColor = Color.DodgerBlue; check &= true; }
                }
                else
                {
                    if (!item.Value) { item.Key.BackColor = Color.Red; check = false; }
                    else { item.Key.BackColor = Color.DodgerBlue; check &= true; }
                }
            }
            return check;
        }

        #region Supplimental

        /// <summary>
        /// Clears fields
        /// </summary>
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

            positionBox.Text = "";
            txtBaseSalary.Text = "";
            txtSalaryModifire.Text = "";
            txtEmail.Text = "";
            pictureBox1.Image = null;
        }

        /// <summary>
        /// Fills fields
        /// </summary>
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
                try { pictureBox1.Image = new Bitmap(Config.FR_Images + $"\\{EMS_ClientMainScreen.employee.IntId}{Config.ImageFormat}"); } catch { }
            }
        }
        #endregion


    }
}