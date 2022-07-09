using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EMS_Library.Network;

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
        public UpdatePersonalDetails()
        {
            InitializeComponent();
        }
        private void UpdatePersonalDetails_Activated(object sender, EventArgs e)
        {
            if (EMS_ClientMainScreen.employee != null) Fill();
        }

        #region Buttons
        private void btnSave_Click(object sender, EventArgs e)
        {
            string querry = Requests.UpdateEmployee(
                EMS_ClientMainScreen.employee.ProvideFieldsAndValues(),
                new Dictionary<string, string>() { { "_intId", EMS_ClientMainScreen.employee.IntId.ToString() } }
                );
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            selectEmployee select_Employee = new selectEmployee(this);
            select_Employee.Show();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var delete = MessageBox.Show("Are you sure?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (delete == DialogResult.OK)
            {
                List<string> buffer = new List<string>();
                string querry = Requests.Delete(int.Parse(txtID.Text));
                Action action = Requests.BuildAction(this, new DataPacket(querry, 4), buffer, false);
                action.Invoke();
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
            txtPosition.Text = "";
            txtBaseSalary.Text = "";
            txtSalaryModifire.Text = "";
            txtEmail.Text = "";
            pictureBox1.Image = null;
        }
        public void Fill()
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
            txtPosition.Text = EMS_ClientMainScreen.employee.Type.Name;
            txtBaseSalary.Text = EMS_ClientMainScreen.employee.BaseSalary.ToString();
            txtSalaryModifire.Text = EMS_ClientMainScreen.employee.SalaryModifire.ToString();
            try { pictureBox1.Image = new Bitmap(EMS_Library.Config.FR_Images + $"\\{EMS_ClientMainScreen.employee.IntId}{EMS_Library.Config.ImageFormat}"); } catch { }
        }
        #endregion
    }
}
