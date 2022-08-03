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
        //Mothods that provide querries for comunicating with SQL db through EMS server.
        public static string SelectEmployee(Dictionary<string, string> data = null)
        {
            string querry = $"get employee #";
            if (data != null)
            {
                foreach (KeyValuePair<string, string> kvp in data)
                    querry += $"{kvp.Key}={kvp.Value} and ";
                return querry.Remove(querry.Length - 5) + ';';
            }
            return querry;
        }
        public static string UpdateEntry(string id, DateTime entry, DateTime exit) => $"update entry #{id}, {entry.ToString("yyyy-MM-dd HH:mm:ss")}, {exit.ToString("yyyy-MM-dd HH:mm:ss")}";
        public static string UpdateEmployee(Dictionary<string, string> data, Dictionary<string, string> clause)
        {
            string querry = $"update employee where ";
            foreach (KeyValuePair<string, string> kvp in clause)
                querry += $"{kvp.Key}={kvp.Value}";
            querry += " #";
            foreach (KeyValuePair<string, string> kvp in data)
                if (kvp.Key == "_intId" || kvp.Key == "_baseSalary" || kvp.Key == "_baseSalary" || kvp.Key == "_salaryModifire")
                    querry += $"{kvp.Key}={kvp.Value}, ";
                else querry += $"{kvp.Key}='{kvp.Value}', ";
            return querry.Remove(querry.Length - 2);
            /*
             if(kvp.Key == "_intId" || kvp.Key == "_baseSalary" || kvp.Key == "_baseSalary" || kvp.Key == "_salaryModifire")
                    querry += $"{kvp.Key}={kvp.Value} ";
                else querry += $"{kvp.Key}='{kvp.Value}' ";
            */
        }
        public static string DeleteEmployee(Dictionary<string, string> clause)
        { throw new NotImplementedException("WIP"); }
        public static string AddEmployee(EMS_Library.MyEmployee.Employee employee) => "add employee #" + employee.ToString();
        public static string UpdateEmployee(EMS_Library.MyEmployee.Employee employee) => "update employee #" + employee.ToString();
        public static string Delete(int _intId) => "delete employee #" + _intId;
        public static string GetHourLogs(int _intId, int year, int month) => $"get log #{_intId}, {year}, {month}";

        /// <summary>
        /// Builds an lambda method for retrieving data from the server. When invoked action will fill the buffer with the data.
        /// </summary>
        /// <param name="parentForm"></param>
        /// <param name="data"></param>
        /// <param name="buffer"></param>
        /// <param name="closeForm"></param>
        /// <returns></returns>
        public static Action BuildAction(Form parentForm, DataPacket data, List<string> buffer, bool closeForm = false)
        {
            buffer.Clear();
            Action action = new Action(() =>
                {
                    try
                    {
                        TcpClient tcpClient = new TcpClient(EMS_Library.Config.ServerIP, EMS_Library.Config.ServerPort);
                        NetworkStream stream = tcpClient.GetStream();
                        stream.Write(data.Write(), 0, data.GetTotalSize());
                        DataPacket responce = new DataPacket(stream);

                        string[] processed = responce.StringData.Split('|');
                        foreach (string a in processed)
                            buffer.Add(a);
                    }
                    catch (Exception ex) { parentForm.Invoke(() => { MessageBox.Show(ex.Message); }); }
                    if (closeForm) parentForm.Invoke(() => { EMS_ClientMainScreen.PrimaryForms.Pop().Close(); });
                });
            return action;
        }
        /// <summary>
        /// Requests an image rom the server
        /// </summary>
        /// <param name="data"></param>
        /// <returns>byte[] containing the image.</returns>
        public static byte[] GetImage(DataPacket data)
        {
            byte[] result = new byte[0];
            try
            {
                TcpClient tcpClient = new TcpClient(EMS_Library.Config.ServerIP, EMS_Library.Config.ServerPort);
                NetworkStream stream = tcpClient.GetStream();
                stream.Write(data.Write(), 0, data.GetTotalSize());
                DataPacket packet = new DataPacket(stream);
                result = packet.ByteData;
            }
            catch { }
            return result;
        }
    }
}
