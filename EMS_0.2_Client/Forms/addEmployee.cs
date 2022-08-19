using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using EMS_Library.MyEmployee;
using EMS_Library;

namespace EMS_Client.Forms
{
    public partial class addEmployee : Form
    {
        #region Variables
        Bitmap employeeImage;
        Control[] activeControls;
        #endregion
        public addEmployee()
        {
            InitializeComponent();
            activeControls = new Control[] {
                txtID, txtFirstName , txtLastName, txtMiddleName,
                txtGender,txtDateOfBirth,txtAddres,txtPhone,
                txtBaseSalary,txtSalaryModifire,txtEmail,positionBox,pictureBox1
            };
        }

        #region Buttons
        //Methods called by Click events.
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Format validation
            if (CheckingDataFields())
            {
                //Addition of a new employee to DB.
                string[] buffer = Requests.RequestFromServer("", 252);


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
                    DateTime.Now,        //created at
                    "1",                 //status
                    txtBaseSalary.Text,
                    txtSalaryModifire.Text,
                    txtPhone.Text,
                    txtAddres.Text
                };

                Employee emp = Employee.ActivateEmployee(empParts);
                if (emp == null) { MessageBox.Show("Failed to create employee!"); return; }

                string querry = Requests.AddEmployee(emp);
                buffer = Requests.RequestFromServer(querry, 2);

                //Rescaling image
                Utility.RescaleImage(employeeImage).Save(Config.FR_Images + $"\\{emp.IntId}{Config.ImageFormat}");
                if(buffer[0]=="1") MessageBox.Show($"{emp.FName} {emp.LName} saved");
            }
            else MessageBox.Show("Incorrect format!");
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            // החזרת הפאנלים לצבע כחול
            Panel[] panelArr = new Panel[] { panelID, panelFname, panelLname, panelDate, panelAddres, panelPhone, panelEmail, panelBaseSalary
                ,panelSalaryModifire,panelPosition};
            foreach (Panel panel in panelArr)
                panel.BackColor = Color.FromArgb(0, 126, 249);

            foreach (Control control in activeControls)
            {
                if (control is TextBox) ((TextBox)control).Text = "";
                else if (control is ComboBox) ((ComboBox)control).Text = "";
                else if (control is PictureBox) ((PictureBox)control).Image = null;
            }
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog a = new OpenFileDialog();
            a.ShowDialog();
            string file = a.FileName;
            try
            {
                employeeImage = new Bitmap(file);
                pictureBox1.Image = employeeImage;
            }
            catch { MessageBox.Show("Failed"); }
        }
        private void btnX_Click(object sender, EventArgs e) => Close();
        #endregion

        /// <summary>
        /// Checks validity of data in the text fields
        /// </summary>
        private bool CheckingDataFields()
        {
            Dictionary<Control, bool> test = new Dictionary<Control, bool>() {
                { panelID, txtID.Text.Parsable(typeof(int)) },
                { panelFname, txtFirstName.Text.Length > 1 },
                { panelLname, txtLastName.Text.Length > 1 },
                { panelDate, txtDateOfBirth.Text.Parsable(typeof(DateTime)) && (DateTime.Now - DateTime.Parse(txtDateOfBirth.Text)).TotalDays / 365 >= 18 },
                { panelAddres, txtAddres.Text.Length > 1 },
                { panelPhone, txtPhone.Text.Parsable(typeof(int)) },
                { panelEmail, txtEmail.Text.Parsable(typeof(System.Net.Mail.MailAddress)) && (!txtEmail.Text.Contains(".") || txtEmail.Text.Trim().EndsWith(".")) },
                { panelBaseSalary, txtBaseSalary.Text.Parsable(typeof(int))&& int.Parse(txtBaseSalary.Text)>0 },
                { panelSalaryModifire, txtSalaryModifire.Text.Parsable(typeof(double))&& double.Parse(txtSalaryModifire.Text)>0},
                { panelPosition, positionBox.Text != "" },
                { btnUpload,pictureBox1.Image != null }
            };
            foreach (KeyValuePair<Control, bool> item in test)
            {
                if (item.Key is Button)
                {
                    if (!item.Value) item.Key.ForeColor = Color.FromArgb(255, 102, 102);
                    else { item.Key.ForeColor = Color.FromArgb(0, 126, 249); }
                }
                else 
                { 
                if (!item.Value) item.Key.BackColor = Color.FromArgb(255, 102, 102);
                else { item.Key.BackColor = Color.FromArgb(0, 126, 249); }
                }
            }
            return !test.Values.Contains(false);
        }

        #region Drag Window
        /// <summary>
        /// Controlls form's movement during drag.
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
    }
}