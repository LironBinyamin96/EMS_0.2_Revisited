using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using EMS_Library;
using EMS_Library.Network;
using EMS_Library.MyEmployee;

namespace EMS_Client.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //Debug
            txtIntId.Text = Config.DefaultId;
            txtPassword.Text = Config.DefaultPassword;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CancellationTokenSource CXL_Src = new CancellationTokenSource();
            CancellationToken CXL = CXL_Src.Token;

            //Debug
            txtIntId.Text = Config.DefaultId;
            txtPassword.Text = Config.DefaultPassword;
            string querry = Requests.SelectEmployee(new Dictionary<string, string> 
            { 
                {"_intId", txtIntId.Text},
                {"_password",txtPassword.Text }
            });
            List<string> buffer = new List<string>();

            Action action = Requests.BuildAction(this, new DataPacket(querry, 1), buffer, false);
            action.Invoke();

            string addQuerry = Requests.AddEmployee(Employee.GetStockEmployee());
            List<string> buffer2 = new List<string>();   
            Action add = Requests.BuildAction(this, new DataPacket(addQuerry, 2), buffer2, true);
            StandbyScreen standby = new StandbyScreen(add);
            standby.ShowDialog();

            EMS_ClientMainScreen.CurEmployee = Employee.ActivateEmployee(buffer[0].Split(','));
            MessageBox.Show("Hello\n"+EMS_ClientMainScreen.CurEmployee.FName);
            Close();
        }
    }

}
