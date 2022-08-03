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
        static public void ServerIP(bool server)
        {
            if (Config.ServerIP != default) return;
            if (server)
            {
                //My IP lookup
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
            else
            {
                for (int i = 1; i < 256; i++)
                {
                    for (int j = 0; j < 256; j++)
                    {
                        string ip = $"192.168.{i}.{j}";
                        Console.WriteLine("Attempting: " + ip);
                        using (TcpClient tcp = new TcpClient())
                        {
                            IAsyncResult ar = tcp.BeginConnect(ip, Config.ServerPort, null, null);
                            WaitHandle wh = ar.AsyncWaitHandle;
                            try
                            {
                                if (!ar.AsyncWaitHandle.WaitOne(TimeSpan.FromMilliseconds(5), false))
                                {
                                    tcp.Close();
                                    throw new TimeoutException();
                                }
                                NetworkStream stream = tcp.GetStream();
                                DataPacket ping = new DataPacket("Ping", 255);
                                stream.Write(ping.Write(), 0, ping.GetTotalSize());
                                DataPacket responce = new DataPacket(stream);
                                if (responce.StringData == "Ping")
                                    Config.ServerIP = $"192.168.{i}.{j}";
                                tcp.EndConnect(ar);
                                wh.Close();
                                return;
                            }
                            catch { }
                            
                        }

                    }
                }
            }
        }
    }
}
