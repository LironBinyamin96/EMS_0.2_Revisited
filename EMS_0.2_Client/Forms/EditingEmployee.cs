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

        #region Buttons
        /// <summary>
        /// Opens Add Worker screen
        /// פתח מסך הוספת עובד
        /// </summary>
        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            addEmployee ae = new addEmployee();
            ae.Show();
        }

        /// <summary>
        /// Opens Update Personal Details screen
        /// פתח מסך עדכון פרטים אישיים של עובד
        /// </summary>
        private void btnUpdatePersonalDetails_Click(object sender, EventArgs e)
        {
            UpdatePersonalDetails upd = new UpdatePersonalDetails();
            upd.Show();
        }
        #endregion
    }
}
