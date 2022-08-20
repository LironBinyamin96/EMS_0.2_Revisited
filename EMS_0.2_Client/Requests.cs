using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using EMS_Library.Network;
using EMS_Library;

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
        public static string GetAllEmails() => "get all emails #";
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
        }
        public static string DeleteEmployee(Dictionary<string, string> clause)
        { throw new NotImplementedException("WIP"); }
        public static string AddEmployee(EMS_Library.MyEmployee.Employee employee) => "add employee #" + employee.ToString();
        public static string UpdateEmployee(EMS_Library.MyEmployee.Employee employee) => "update employee #" + employee.ToString();
        public static string Delete(int _intId) => "delete employee #" + _intId;
        public static string GetHourLogs(int _intId, int year, int month) => $"get log #{_intId}, {year}, {month}";
        public static string GetAllExceptions() => "get all exceptions #";

        
        /// <summary>
        /// Requests an image from the server
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] GetImage(DataPacket data)
        {
            byte[] result = new byte[0];
            try
            {
                //Request an image
                TcpClient tcpClient = new TcpClient(Config.ServerIP, Config.ServerPort);
                NetworkStream stream = tcpClient.GetStream();
                stream.Write(data.Write(), 0, data.GetTotalSize());
                DataPacket packet = new DataPacket(stream);
                result = packet.ByteData;

                //Notify server that you're done reading the responce.
                stream = new TcpClient(Config.ServerIP, Config.ServerPort).GetStream();
                DataPacket done = new DataPacket("done");
                stream.Write(done.Write(), 0, done.GetTotalSize());
            }
            catch { }
            return result;
        }

        /// <summary>
        /// Handles clien-server requests
        /// </summary>
        /// <param name="querry"></param>
        /// <param name="routingFunctionNum"></param>
        /// <returns>Array of strings containing the responce</returns>
        public static string[] RequestFromServer(string querry, byte routingFunctionNum = 255)
        {
            string[] result = null;
            Action action = () =>
            {
                //request data from the server
                DataPacket request = new DataPacket(querry, routingFunctionNum);
                try //In case server doesn't respond
                {
                    TcpClient client = new TcpClient(Config.ServerIP, Config.ServerPort);
                    NetworkStream stream = client.GetStream();
                    //NetworkStream stream = new TcpClient(Config.ServerIP, Config.ServerPort).GetStream();
                    stream.Write(request.Write(), 0, request.GetTotalSize());
                    DataPacket responce = new DataPacket(stream);
                    result = responce.StringData.Split('|');

                    //Notify the server that you're done reading the responce
                    stream = new TcpClient(Config.ServerIP, Config.ServerPort).GetStream();
                    DataPacket done = new DataPacket("done");
                    stream.Write(done.Write(), 0, done.GetTotalSize());
                    Thread.Sleep(10);

                }
                catch (Exception e) { throw e; }
            };
            action.Invoke();
            return result;
        }





    }
}
