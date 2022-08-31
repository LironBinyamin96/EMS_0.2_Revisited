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
        static List<MyConnection> connections = new List<MyConnection>(); //All active connections on the server.

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
                    MyConnection connection = new MyConnection(client);
                    connection.ClientFinished += OnClientFinished;

                    connections.Add(connection);
                    EMS_ServerMainScreen.serverForm.ReRenderConnections(Array.ConvertAll(connections.ToArray(), x => x._tcpClient.Client?.RemoteEndPoint.ToString()));
                    connection.ReadData();
                });
            }
        }

        /// <summary>
        /// Method used to shutdown the client connections.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void OnClientFinished(object sender, EventArgs e)
        {
            if (sender is MyConnection)
            {
                //Dispose of the connections.
                for (int i = 0; i < connections.Count; i++)
                {
                    if (connections[i]._tcpClient.Client != null &&
                       (sender as MyConnection)._tcpClient.Client != null &&
                       (sender as MyConnection)._tcpClient.Client.RemoteEndPoint.ToString().Split(':')[0] == connections[i]._tcpClient.Client.RemoteEndPoint.ToString().Split(":")[0])
                    
                    {
                        connections[i].Terminate();
                        connections.Remove(connections[i--]);
                    }
                }
                EMS_ServerMainScreen.serverForm.ReRenderConnections(Array.ConvertAll(connections.ToArray(), x => x._tcpClient.Client?.RemoteEndPoint.ToString()));
            }
        }

        internal class MyConnection
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

            /// <summary>
            /// Method used for reading requests sent by the client.
            /// </summary>
            public void ReadData()
            {
                _request = new DataPacket(_stream);
                EMS_ServerMainScreen.serverForm.WriteToServerConsole("Recieved request: " + _request);

                //Preform action dependant on the request recieved.
                switch (_request.StringData.ToLower())
                {
                    //Reply to the ping.
                    case "ping": { DataPacket responce = new DataPacket("ping"); _stream.Write(responce.Write(), 0, responce.GetTotalSize()); Thread.Sleep(10); OnClientFinished(this, EventArgs.Empty); break; }
                    
                    //Terminate this connection.
                    case "done":
                        {
                            DataPacket responce = new DataPacket("terminated");
                            _stream.Write(responce.Write(), 0, responce.GetTotalSize());
                            Thread.Sleep(10);
                            ClientFinished?.Invoke(this, EventArgs.Empty);
                            
                            break;
                        }

                    //In all other cases, pass the request to the Router, and then pass the responce by to the client.
                    default:
                        {
                            _responce = new MyRouter().Router(_request);
                            EMS_ServerMainScreen.serverForm.WriteToServerConsole("Repsonce: " + _responce.ToString());
                            _stream.Write(_responce.Write(), 0, _responce.GetTotalSize());
                            break;
                        }
                }
            }


            /// <summary>
            /// Terminate the client connection.
            /// </summary>
            public void Terminate()
            {
                if (_tcpClient.Client != null)
                    EMS_ServerMainScreen.serverForm.WriteToServerConsole("Terminating: " + _tcpClient.Client.RemoteEndPoint);
                _stream.Dispose();
                _tcpClient.Dispose();

            }

        }
    }
}
