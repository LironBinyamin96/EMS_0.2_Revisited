using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using EMS_Library;
using EMS_Library.Network;
using System.Timers;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

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
                    Monitor monitor = new Monitor(client);
                    NetworkStream stream = client.GetStream();
                    DataPacket request = new DataPacket(stream);
                    EMS_ServerMainScreen.serverForm.WriteToServerConsole($"Request: {request}");
                    DataPacket responce = new MyRouter().Router(request);
                    EMS_ServerMainScreen.serverForm.WriteToServerConsole($"Responce: {responce}");
                    stream.Write(responce.Write(), 0, responce.GetTotalSize());

                    //Wait until client finishes or times out.
                    while (monitor.MaintainConnection()) Thread.Sleep(5);

                    EMS_ServerMainScreen.serverForm.AddConnection($"{DateTime.Now.TimeOfDay.ToString().Remove(8)} {client.Client.RemoteEndPoint} took {monitor.Elapsed}ms");
                    monitor.Dispose();
                });
            }
        }
        class Monitor:IDisposable
        {
            System.Timers.Timer _connectionTimeout = new System.Timers.Timer(Config.ClientRequestTimeout);
            bool _timedout = false;
            TcpClient _client;
            DateTime _startTime = DateTime.Now;
            bool _disposed=false;
            public double Elapsed => (DateTime.Now - _startTime).TotalMilliseconds;
            public Monitor(TcpClient client)
            {
                _client = client;
                _connectionTimeout.Start();
                _connectionTimeout.Elapsed += OnConnectionTimeout;
            }

            /// <summary>
            /// Check if server should maintain the connection
            /// </summary>
            public bool MaintainConnection() => TestConnection() && !_timedout;

            /// <summary>
            /// Handeling of connection timeout event.
            /// </summary>
            /// <param name="source"></param>
            /// <param name="e"></param>
            private void OnConnectionTimeout(object source, ElapsedEventArgs e)
            {
                EMS_ServerMainScreen.serverForm.WriteToServerConsole(this._client.Client.RemoteEndPoint.ToString() + "timed out and being disconnected");
                _timedout = true;
                Dispose();
            }

            /// <summary>
            /// Tests if client is still connected.
            /// </summary>
            private bool TestConnection()
            {
                if (_client.Client.Poll(0, SelectMode.SelectRead)) //true if last operation was succesfull.
                {
                    //Attempts to recieve an empty message. If it can't then client is disconnected.
                    if (_client.Client.Receive(new byte[1], SocketFlags.Peek) == 0) 
                         return false;
                    else return true;
                }
                return false;
            }

            /// <summary>
            /// Method for releasing resourses.
            /// </summary>
            public void Dispose()
            {
                if (!_disposed)
                {
                    _client?.Dispose();
                    _connectionTimeout?.Dispose();
                    _disposed = true;
                }
            }
        }
    }
}
