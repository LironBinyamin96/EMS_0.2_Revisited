using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using EMS_Library.Network;

namespace EMS_Client
{
    static class Requests
    {
        public static string SelectEmployee(Dictionary<string, string> data = null)
        {
            string querry = $"get employee #";
            if (data != null)
                foreach (KeyValuePair<string, string> kvp in data)
                    querry += $"{kvp.Key}={kvp.Value} and ";
            return querry.Remove(querry.Length-5)+';';
        }
        public static string AddEmployee(EMS_Library.MyEmployee.Employee employee) => "add employee #" + employee.ToString();
        public static string UpdateEmployee(EMS_Library.MyEmployee.Employee employee) => "update employee #" + employee.ToString();
        public static string Delete(int _intId) => "delete employee #" + _intId;

        public static Action BuildAction(Form parentForm, byte routeCase, string querry, List<string> buffer, bool loading = false)
        {
            Action action = new Action(() =>
                {
                    try
                    {
                        TcpClient tcpClient = new TcpClient(EMS_Library.Config.ServerIP, EMS_Library.Config.ServerPort);
                        NetworkStream stream = tcpClient.GetStream();
                        DataPacket packet = new DataPacket(querry, routeCase);
                        stream.Write(packet.Write(), 0, packet.GetTotalSize());
                        DataPacket responce = new DataPacket(stream);
                        string[] processed = responce.StringData.Remove(responce.StringData.Length - 1).Split('|');
                        foreach (string a in processed)
                            buffer.Add(a);
                    }
                    catch (Exception ex) { parentForm.Invoke(() => { MessageBox.Show(ex.Message); }); }
                    if (loading) parentForm.Invoke(() => { EMS_ClientMainScreen.PrimaryForms.Pop().Close(); });
                });
            return action;
        }
    }
}
