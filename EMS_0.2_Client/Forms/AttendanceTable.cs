using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EMS_Library.MyEmployee.HoursLog;

namespace EMS_Client.Forms
{
    public partial class AttendanceTable : Form
    {
        public AttendanceTable()
        {
            InitializeComponent();
        }

        public void Fill()
        {
            txtName.Text = EMS_ClientMainScreen.employee.LName.ToString() + " " + EMS_ClientMainScreen.employee.FName.ToString();
            txtID.Text = EMS_ClientMainScreen.employee.IntId.ToString();
            
            
            
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            selectEmployee select_Employee = new selectEmployee();
            select_Employee.Show();


        }

        private void AttendanceTable_Activated(object sender, EventArgs e)
        {
            MessageBox.Show("Activated");
            if (EMS_ClientMainScreen.employee != null)
            {
                MessageBox.Show("Fill");
                Fill();
            }
            else MessageBox.Show("Not fill");
            
        }
    }
}
