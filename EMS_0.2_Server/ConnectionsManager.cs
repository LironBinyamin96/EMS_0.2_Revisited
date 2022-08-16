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
    internal class ConnectionsManager
    {
        static List<MyConnection> connections = new List<MyConnection>();
        public static void Listen()
        {
            TcpListener listener = new TcpListener(IPAddress.Parse(Config.ServerIP), Config.ServerPort);
            listener.Start();
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                Task.Run(() =>
                {
                    MyConnection connection = new MyConnection(client);
                    connection.ClientFinished += OnClientFinished;

                    connections.Add(connection);
                    connection.ReadData();
                });
            }

        }
        static void OnClientFinished(object sender, EventArgs e)
        {
            if (sender is MyConnection)
            {
                List<MyConnection> arr = connections.FindAll(x => x._tcpClient.Client != null && (sender as MyConnection)._tcpClient.Client.RemoteEndPoint.ToString().Split(':')[0] == x._tcpClient.Client.RemoteEndPoint.ToString().Split(":")[0]);

                while (arr.Count > 0)
                    foreach (MyConnection connection in arr)
                    { connection.Terminate(); arr.Remove(connection); break; }
                return;
            }
        }

        class MyConnection
        {
            public TcpClient _tcpClient;
            protected DataPacket _request;
            protected DataPacket _responce;
            protected NetworkStream _stream;

            public event EventHandler ClientFinished;

            public MyConnection(TcpClient client)
            {
                EMS_ServerMainScreen.serverForm.WriteToServerConsole("Accepted client: " + client.Client.RemoteEndPoint);
                _tcpClient = client;
                _stream = _tcpClient.GetStream();
            }

            public void ReadData()
            {
                _request = new DataPacket(_stream);
                EMS_ServerMainScreen.serverForm.WriteToServerConsole("Recieved request: " + _request);
                switch (_request.StringData.ToLower())
                {
                    case "ping": { DataPacket responce = new DataPacket("ping"); _stream.Write(responce.Write(), 0, responce.GetTotalSize()); Thread.Sleep(10); OnClientFinished(this, EventArgs.Empty); break; }
                    case "done":
                        {
                            DataPacket responce = new DataPacket("terminated");
                            _stream.Write(responce.Write(), 0, responce.GetTotalSize());
                            Thread.Sleep(10);
                            ClientFinished?.Invoke(this, EventArgs.Empty);
                            
                            break;
                        }
                    default:
                        {
                            _responce = new MyRouter().Router(_request);
                            EMS_ServerMainScreen.serverForm.WriteToServerConsole("Repsonce: " + _responce.ToString());
                            _stream.Write(_responce.Write(), 0, _responce.GetTotalSize());
                            break;
                        }
                }
            }

            public void Terminate()
            {
                if (_tcpClient.Client != null)
                    EMS_ServerMainScreen.serverForm.WriteToServerConsole("Terminating: " + _tcpClient.Client.RemoteEndPoint);
                EMS_ServerMainScreen.serverForm.WriteToServerConsole("Terminating: " + _tcpClient.Client.RemoteEndPoint);
                _stream.Dispose();
                _tcpClient.Dispose();

            }

        }
    }
}
