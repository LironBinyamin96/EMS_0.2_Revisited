using EMS_Library;
using EMS_Library.Network;
using System.Net.Sockets;

namespace EMS_Client
{
    static class Requests
    {
        //Mothods that provide querries for comunicating with SQL db through EMS server.
        public static string SelectEmployee(string[][] clause, string gate = "")
        {
            string querry = $"get employee #";
            if (clause != null)
            {
                foreach (string[] item in clause)
                    querry += $"{item[0]}={item[1]} {gate} ";
                return querry.Remove(querry.Length - (gate.Length + 2)) + ';';
            }
            return querry;
        }
        public static string SelectEmployee() => "get employee #";
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
        public static string DeleteEmployee(int _intId) => "delete employee #" + _intId;
        public static string AddEmployee(EMS_Library.MyEmployee.Employee employee) => "add employee #" + employee.ToString();
        public static string GetHourLogs(int _intId, int year, int month) => $"get log #{_intId}, {year}, {month}";
        public static string GetYearlyHourLog(int _intId, int year) => $"get log #{_intId}, {year}";
        public static string GetAllExceptions() => "get all exceptions #";
        public static string GetAllOfStatus(byte status) => SelectEmployee(new string[][] { new string[] { "_employmentStatus", status.ToString() } });

        /// <summary>
        /// Sends picture to the server to be saved.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="intId"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static string[] SaveImmage(Bitmap image, int intId)
        {
            TcpClient tcpClient = new TcpClient(Config.ServerIP, Config.ServerPort);
            NetworkStream stream = tcpClient.GetStream();
            //Get byte data of the image;
            byte[] imageBytes = new ImageConverter().ConvertTo(image, typeof(byte[])) as byte[];
            if (imageBytes != null)
            {
                //Create new data packet while appending employee ID to the end of the data stream.
                DataPacket packet = new DataPacket(imageBytes.Concat(BitConverter.GetBytes(intId)).ToArray(), 10);
                //Send it away.
                stream.Write(packet.Write(), 0, packet.GetTotalSize());
                string[] responce = new DataPacket(stream).StringData.Split('|');
                tcpClient.Close();
                return responce;
            }
            else { tcpClient.Close(); throw new ArgumentException("Clould not parse the image to byte[]."); }
        }

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
                tcpClient.Close();
            }
            catch { }
            return result;
        }

        /// <summary>
        /// Main client side method for handling client-server communication.
        /// </summary>
        /// <param name="querry"></param>
        /// <param name="routingFunctionNum"></param>
        /// <returns>Array of strings containing the responce</returns>
        public static string[] RequestFromServer(string querry, byte routingFunctionNum = 255)
        {
            string[] result = null;
            try //In case server doesn't respond
            {
                TcpClient client = new TcpClient(Config.ServerIP, Config.ServerPort);
                NetworkStream stream = client.GetStream();
                DataPacket request = new DataPacket(querry, routingFunctionNum);
                stream.Write(request.Write(), 0, request.GetTotalSize());
                DataPacket responce = new DataPacket(stream);
                result = responce.StringData.Split('|');
                client.Client.Close();
                Console.WriteLine("Client connected to the server: " + client.Connected);
            }
            catch (Exception e) { throw e; }

            return result;
        }
    }
}
