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
    public partial class selectEmployee : Form
    {
        public selectEmployee()
        {
            InitializeComponent();
        }

        private void btnSaerch_Click(object sender, EventArgs e)
        {
            if (txtSaerch.Text == "")
            {
                string querry = Requests.SelectEmployee();
                List<string> buffer = new List<string>();
                Action action = Requests.BuildAction(this, new DataPacket(querry, 1), buffer, false);
                action.Invoke();

                foreach (string item in buffer)
                {
                    MessageBox.Show(item);
                }

            }
        }

        private void btnX_Click(object sender, EventArgs e) => Close();
    }
}
