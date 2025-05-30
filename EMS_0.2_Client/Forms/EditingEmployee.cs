﻿namespace EMS_Client.Forms
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
       private void btnNewWorker_Click(object sender, EventArgs e)
        {
            addEmployee ae = new addEmployee();
            ae.Show();
        }

        /// <summary>
        /// Opens Update Personal Details screen
        /// פתח מסך עדכון פרטים אישיים של עובד
        /// </summary>
        private void rjbtnUpdatePersonalDetails_Click(object sender, EventArgs e)
        {
            UpdatePersonalDetails upd = new UpdatePersonalDetails();
            upd.Show();
        }

        #endregion


    }
}
