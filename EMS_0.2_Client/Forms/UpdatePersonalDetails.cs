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
        public UpdatePersonalDetails()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e) 
        {
            EMS_ClientMainScreen.employee = null;
            Close();

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "picture |*.jpg| picture |*.png | all files|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.InitialDirectory = "c:\\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = openFileDialog1.FileName;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var delete = MessageBox.Show("Are you sure?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (delete == DialogResult.OK)
            {
                List<string> buffer = new List<string>();
                string querry = Requests.Delete(Int32.Parse(txtID.Text));
                Action action = Requests.BuildAction(this, new DataPacket(querry, 4), buffer, false);
                action.Invoke();
                Clear();               
            }
        }
        public void Fill()
        {
            txtID.Text = EMS_ClientMainScreen.employee.IntId.ToString();
            txtFirstName.Text = EMS_ClientMainScreen.employee.FName.ToString();
            txtLastName.Text = EMS_ClientMainScreen.employee.LName.ToString();
            txtMiddleName.Text= EMS_ClientMainScreen.employee.MName.ToString();
            txtEmail.Text = EMS_ClientMainScreen.employee.Email.ToString();
            txtGender.Text = EMS_ClientMainScreen.employee.Gender.ToString();
            txtDateOfBirth.Text= EMS_ClientMainScreen.employee.BirthDate.ToString();
            txtAddres.Text= EMS_ClientMainScreen.employee.Address.ToString();
            txtPhone.Text = EMS_ClientMainScreen.employee.PhoneNumber.ToString();
            txtPosition.Text = EMS_ClientMainScreen.employee.Type.Name;
            txtBaseSalary.Text = EMS_ClientMainScreen.employee.BaseSalary.ToString();
            txtSalaryModifire.Text = EMS_ClientMainScreen.employee.SalaryModifire.ToString();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            selectEmployee select_Employee = new selectEmployee();
            select_Employee.Show();
        }

        private void UpdatePersonalDetails_Activated(object sender, EventArgs e)
        {
            if (EMS_ClientMainScreen.employee != null)
                Fill();
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
            txtPosition.Text = "";
            txtBaseSalary.Text = "";
            txtSalaryModifire.Text = "";
        }
    }
}
