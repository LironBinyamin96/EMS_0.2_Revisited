using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS_Client.Forms
{
    public partial class EditingEmployee : Form
    {

        public EditingEmployee()
        {
            InitializeComponent();
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            addEmployee ae = new addEmployee();
            ae.Show();
        }

        private void btnUpdatePersonalDetails_Click(object sender, EventArgs e)
        {
            UpdatePersonalDetails upd = new UpdatePersonalDetails();
            upd.Show();
        }
    }
}
