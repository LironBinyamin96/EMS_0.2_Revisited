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
                txtBaseSalary,txtSalaryModifire,txtEmail,positionBox,txtFile,pictureBox1
            };
        }

        #region Buttons
        /// <summary>
        /// Saving data
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!CheckingDataFields()) return;

            MessageBox.Show("OK");


            //Format validation
            if (txtDateOfBirth.Text.Parsable(typeof(DateTime)))
            {
                //Addition of a new employee to DB.
                List<string> buffer = new List<string>();
                Action getFreeIdAction = Requests.BuildAction(this, new EMS_Library.Network.DataPacket("", 252), buffer);
                getFreeIdAction.Invoke();

                object[] empParts = new object[] {
                    positionBox.Text,
                    buffer[0],
                    txtID.Text,
                    txtFirstName.Text,
                    txtLastName.Text,
                    txtMiddleName.Text,
                    txtEmail.Text,
                    "PasswordPlaceholder",
                    txtGender.Text,
                    txtDateOfBirth.Text,
                    DateTime.Now,        //created at
                    "1",                 //status
                    txtBaseSalary.Text,
                    txtSalaryModifire.Text,
                    txtPhone.Text
                };

                buffer.Clear();
                Employee emp = Employee.ActivateEmployee(empParts);
                string querry = Requests.AddEmployee(emp);

                Action AddEmpAction = Requests.BuildAction(this, new EMS_Library.Network.DataPacket(emp.ToString(), 2), buffer);
                AddEmpAction.Invoke();

                //Rescaling image
                Utility.RescaleImage(employeeImage).Save(Config.FR_Images + $"\\{emp.IntId}{Config.ImageFormat}");
            }
            else MessageBox.Show("Incorrect format!");
        }

        /// <summary>
        /// Close button
        /// </summary>
        private void btnX_Click(object sender, EventArgs e) => Close();

        /// <summary>
        /// Clear all fields
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            Panel[] panelArr = new Panel[] { panelID, panelFname, panelLname, panelDate, panelAddres, panelPhone, panelEmail, panelBaseSalary
                ,panelSalaryModifire,panelPosition,panelUpload };
            foreach (Panel panel in panelArr)
                panel.BackColor = Color.FromArgb(0, 126, 249);

            foreach (Control control in activeControls)
            {
                if (control is TextBox) ((TextBox)control).Text = "";
                else if (control is CheckBox) ((ComboBox)control).SelectedIndex = 0;
                else if (control is PictureBox) ((PictureBox)control).Image = null;
            }
        }
        /// <summary>
        /// Import picture
        /// </summary>
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog a = new OpenFileDialog();
            a.ShowDialog();
            string file = a.FileName;
            try
            {
                employeeImage = new Bitmap(file);
                pictureBox1.Image = employeeImage;
                txtFile.Text = file;
            }
            catch { MessageBox.Show("Failed"); }
        }
        #endregion

        private bool CheckingDataFields()
        {
            Checks checks = new Checks();

            Dictionary<Panel, bool> test = new Dictionary<Panel, bool>();
            test.Add(panelID,!checks.IdNumber(txtID.Text));
            test.Add(panelFname,!checks.StringLength(txtFirstName.Text));
            test.Add(panelLname, !checks.StringLength(txtLastName.Text));
            test.Add(panelDate, !checks.ItsDate(txtDateOfBirth.Text));
            test.Add(panelAddres, !checks.StringLength(txtAddres.Text));
            test.Add(panelPhone, !checks.IsNumber(txtPhone.Text));
            test.Add(panelEmail, !checks.IsValidEmail(txtEmail.Text));
            test.Add(panelBaseSalary, !checks.IsNumber(txtBaseSalary.Text));
            test.Add(panelSalaryModifire, !checks.IsNumber(txtSalaryModifire.Text));
            test.Add(panelPosition, !checks.SelectedPosition(positionBox));
            test.Add(panelUpload, !checks.picture(employeeImage));

            int countTrue = 0;
            foreach (KeyValuePair<Panel, bool> item in test)
            {
                if (item.Value) item.Key.BackColor = Color.FromArgb(255, 102, 102);
                else { item.Key.BackColor = Color.FromArgb(0, 126, 249); countTrue++; }
            }
            return countTrue == 11;
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
