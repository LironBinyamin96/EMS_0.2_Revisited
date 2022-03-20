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
using EMS_Library.Network;

namespace EMS_Client.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CancellationTokenSource CXL_Src = new CancellationTokenSource();
            CancellationToken CXL = CXL_Src.Token;

            //Debug
            txtIntId.Text = EMS_Library.Config.DefaultId;
            txtPassword.Text = EMS_Library.Config.DefaultPassword;
            Action action = () =>
            {
            try {
                TcpClient tcpClient = new TcpClient(EMS_Library.Config.ServerIP, EMS_Library.Config.ServerPort);
                NetworkStream stream = tcpClient.GetStream();
                DataPacket packet = new DataPacket($"" +
                    $"Select * from Employees" +
                    $" where " +
                    $"_intId={txtIntId.Text} and _password = '{txtPassword.Text}'",
                    254);
                stream.Write(packet.Write(), 0, packet.GetTotalSize());

                EMS_ClientMainScreen.CurEmployee = new DataPacket(stream).StringData;
            } catch (Exception ex)
            { Invoke(() => { MessageBox.Show("Failed to connect to server."); }); }
                Invoke(() => { EMS_ClientMainScreen.PrimaryForms.Pop().Close(); });
            };
            //StandbyScreen standby = new StandbyScreen(action);
            //standby.ShowDialog();

            MessageBox.Show("Hello\n"+EMS_ClientMainScreen.CurEmployee);
            Close();
        }
    }
}
