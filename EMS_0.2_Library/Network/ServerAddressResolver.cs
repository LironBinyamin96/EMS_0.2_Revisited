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
        public static bool LookedUp=false;
        /// <summary>
        /// Mothod for resolving IP addresses for both client and server.
        /// </summary>
        /// <param name="server">Indicates if method located at server side</param>
        /// <exception cref="Exception">Could not find a server</exception>
        static public void ServerIP(bool server)
        {
            if (Config.ServerIP != default) return; //If address is known=>skip.

            if (server) //Am i a server?
            {
                //Figure out what is my IP address
                foreach (NetworkInterface netInterface in NetworkInterface.GetAllNetworkInterfaces())
                {
                    Console.WriteLine("Name: " + netInterface.Name);
                    Console.WriteLine("Description: " + netInterface.Description);
                    Console.WriteLine("Addresses: ");
                    IPInterfaceProperties ipProps = netInterface.GetIPProperties();
                    foreach (UnicastIPAddressInformation addr in ipProps.UnicastAddresses)
                    {
                        Console.WriteLine(" " + addr.Address.ToString());
                    }
                    Console.WriteLine("");
                }
                NetworkInterface netFace = Array.Find(NetworkInterface.GetAllNetworkInterfaces(), x => x.Name=="Ethernet") ?? Array.Find(NetworkInterface.GetAllNetworkInterfaces(), x => x.Name.Contains("Wi-Fi"));
                if (netFace != null)
                {
                    IPInterfaceProperties x = netFace.GetIPProperties();
                    Array.ConvertAll(x.UnicastAddresses.ToArray(), x=>x.Address.ToString()).DebugPrint();
                    var temp = Array.Find(x.UnicastAddresses.ToArray(), x => x.Address.ToString().Contains("192.168."));
                    if (temp != null) Config.ServerIP = temp.Address.ToString();
                }
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
                            IAsyncResult ar = tcp.BeginConnect(ip, Config.ServerPort, null, null);
                            WaitHandle wh = ar.AsyncWaitHandle;
                            try
                            {
                                if (!ar.AsyncWaitHandle.WaitOne(TimeSpan.FromMilliseconds(10), false))
                                {
                                    tcp.Close();
                                    throw new TimeoutException();
                                }
                                NetworkStream stream = tcp.GetStream();
                                DataPacket ping = new DataPacket("Ping", 255);
                                stream.Write(ping.Write(), 0, ping.GetTotalSize());
                                DataPacket responce = new DataPacket(stream);
                                if (responce.StringData.ToLower() == "ping")
                                    Config.ServerIP = $"192.168.{i}.{j}";
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
