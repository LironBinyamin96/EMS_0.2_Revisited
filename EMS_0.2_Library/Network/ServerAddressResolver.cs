using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace EMS_Library.Network
{
    public class ServerAddressResolver
    {
        public static bool LookedUp=false; //(true if had to look for the server) Notify user that he should update server ip in the config.

        /// <summary>
        /// Mothod for resolving IP addresses for both client and server.
        /// </summary>
        /// <param name="server">Indicates if method called by the server</param>
        /// <exception cref="Exception">Could not find a server</exception>
        static public void ServerIP(bool server)
        {
            if (Config.ServerIP != default) return; //If address is known=>skip.

            if (server) //Am i a server?
            {
                //Find suitable IP to operate from.
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
            else //I'm a client!
            {
                //Look for the server
                for (int i = 1; i < 256; i++)
                {
                    Console.WriteLine($"Trying: 192.168.{i}.X");
                    for (int j = 0; j < 256; j++)
                    {
                        string ip = $"192.168.{i}.{j}";
                        using (TcpClient tcp = new TcpClient())
                        {
                            IAsyncResult ar = tcp.BeginConnect(ip, Config.ServerPort, null, null); //Try to connect
                            WaitHandle wh = ar.AsyncWaitHandle;
                            try
                            {
                                if (!ar.AsyncWaitHandle.WaitOne(TimeSpan.FromMilliseconds(2), false)) //Wait for 2ms.
                                {
                                    tcp.Close(); //If 2ms passed without responce=>stop.
                                    throw new TimeoutException();
                                }

                                //If you managed to connect try to send request in EMS format to double-check that this is EMS server. (ping)
                                NetworkStream stream = tcp.GetStream();
                                DataPacket ping = new DataPacket("Ping", 255);
                                stream.Write(ping.Write(), 0, ping.GetTotalSize());
                                DataPacket responce = new DataPacket(stream);
                                if (responce.StringData.ToLower() == "ping") //If responce is "ping", you've found the server.
                                    Config.ServerIP = $"192.168.{i}.{j}";    //Remember the address.
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
