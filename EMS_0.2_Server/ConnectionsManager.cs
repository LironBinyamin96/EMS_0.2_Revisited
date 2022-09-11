using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using EMS_Library;
using EMS_Library.Network;

namespace EMS_Server
{
    /// <summary>
    /// Class for managing connections.
    /// </summary>
    internal class ConnectionsManager
    {
        /// <summary>
        /// Main listening method.
        /// </summary>
        public static void Listen()
        {
            TcpListener listener = new TcpListener(IPAddress.Parse(Config.ServerIP), Config.ServerPort);
            listener.Start();
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                Task.Run(() =>
                {
                    EMS_ServerMainScreen.serverForm.WriteToServerConsole($"Client {client.Client.RemoteEndPoint} connected.");
                    NetworkStream stream = client.GetStream();
                    DataPacket request = new DataPacket(stream);
                    EMS_ServerMainScreen.serverForm.WriteToServerConsole($"Request: {request}");
                    DataPacket responce = new MyRouter().Router(request);
                    EMS_ServerMainScreen.serverForm.WriteToServerConsole($"Responce: {responce}");
                    stream.Write(responce.Write(), 0, responce.GetTotalSize());
                    EMS_ServerMainScreen.serverForm.AddConnection(client.Client.RemoteEndPoint.ToString());
                    while (client.Connected) { Thread.Sleep(1); } //Wait until client finishes.
                });
            }
        }
    }
}
