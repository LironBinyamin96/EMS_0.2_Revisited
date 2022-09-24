using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace EMS_Library.Network
{
    /// <summary>
    /// Class for resolving server address.
    /// מחלקה למציאת כתובת השרת
    /// </summary>
    public class ServerAddressResolver
    {
        //(true if had to look for the server) Notify user that he should update server ip in the config.
        // מחזיר אמת אם היה צריך לחפש את השרת - מודיע למשתמש שעליו לעדכן את האיי פי של השרת בתצורה
        public static bool LookedUp=false;

        /// <summary>
        /// Mothod for resolving IP addresses for both client and server.
        /// עבור לקוח ושרת כאחד IP דרך לפתרון כתובות .
        /// </summary>
        /// <param name="server">Indicates if method called by the server</param>
        /// <exception cref="Exception">Could not find a server</exception>
        static public void ServerIP(bool server)
        {
            if (Config.ServerIP != default) return; //If address is known=>skip. | תדלג אם הכתובת ידועה

            if (server) //Am i a server? | האם זה שרת
            {
                //Find suitable IP to operate from.| מתאים לפעול ממנו IP  מצא 
                NetworkInterface netFace = Array.Find(NetworkInterface.GetAllNetworkInterfaces(), x => x.Name.Split().Last() == "Ethernet" && x.OperationalStatus == OperationalStatus.Up);
                if (netFace == null)
                {
                    netFace = Array.Find(NetworkInterface.GetAllNetworkInterfaces(), x => x.Name.Split().Last() == "Wi-Fi" && x.OperationalStatus == OperationalStatus.Up);
                    if (netFace == null) throw new ApplicationException("Could not find vialbe network adapter!");
                }

                IPInterfaceProperties x = netFace.GetIPProperties();
                var temp = Array.Find(x.UnicastAddresses.ToArray(), x => x.Address.ToString().Contains("192.168."));
                if (temp != null) Config.ServerIP = temp.Address.ToString();
            }
            else //I'm a client! | זה לקוח
            {
                //Look for the server | חפש את השרת
                for (int i = 1; i < 256; i++)
                {
                    Console.WriteLine($"Trying: 192.168.{i}.X");
                    for (int j = 0; j < 256; j++)
                    {
                        string ip = $"192.168.{i}.{j}";
                        using (TcpClient tcp = new TcpClient())
                        {
                            IAsyncResult ar = tcp.BeginConnect(ip, Config.ServerPort, null, null); //Try to connect | תנסה להתחבר
                            WaitHandle wh = ar.AsyncWaitHandle;
                            try
                            {
                                if (!ar.AsyncWaitHandle.WaitOne(TimeSpan.FromMilliseconds(2), false)) //Wait for 2ms. | המתן 2 אלפיות שניה 
                                {
                                    tcp.Close(); //If 2ms passed without responce=>stop. | תעצור אם עברו 2 אלפיות שניה
                                    throw new TimeoutException();
                                }

                                //If you managed to connect try to send request in EMS format to double-check that this is EMS server. (ping)
                                //  פינג- EMS כדי לבדוק שוב שזה שרת EMS אם הצלחת להתחבר נסה לשלוח בקשה בפורמט
                                NetworkStream stream = tcp.GetStream();
                                DataPacket ping = new DataPacket("ping");
                                stream.Write(ping.Write(), 0, ping.GetTotalSize());
                                DataPacket responce = new DataPacket(stream);
                                if (responce.StringData.ToLower() == "ping") //If responce is "ping", you've found the server. | אם התגובה היא "פינג", מצאת את השרת.
                                    Config.ServerIP = $"192.168.{i}.{j}";    //Remember the address. | תזכור את הכתובת
                                tcp.EndConnect(ar);
                                wh.Close();
                                LookedUp = true;
                                return;
                            }
                            catch { }
                        }
                    }
                }
                throw new Exception("Could not find the server in local network");
            }
        }
    }
}
