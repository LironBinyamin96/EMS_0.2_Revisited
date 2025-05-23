﻿using EMS_Library;
using EMS_Library.Network;
using System.Net;
using System.Net.Sockets;
using System.Timers;

namespace EMS_Server
{
    /// <summary>
    /// Class for managing connections.
    /// מחלקה לניהול חיבורים
    /// </summary>
    internal class ConnectionsManager
    {
        /// <summary>
        /// Main listening method.
        /// פונקציה להאזנה
        /// </summary>
        public static void Listen()
        {
            TcpListener listener = new TcpListener(IPAddress.Parse(Config.ServerIP), Config.ServerPort);
            listener.Start();
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                Task.Run(async () =>
                {
                    EMS_ServerMainScreen.serverForm.WriteToServerConsole($"Client {client.Client.RemoteEndPoint} connected.");
                    Monitor monitor = new Monitor(client);
                    NetworkStream stream = client.GetStream();
                    DataPacket request = new DataPacket(stream);
                    EMS_ServerMainScreen.serverForm.WriteToServerConsole($"Request: {request}");
                    DataPacket responce = await new MyRouter().Router(request);
                    EMS_ServerMainScreen.serverForm.WriteToServerConsole($"Responce: {responce}");
                    stream.Write(responce.Write(), 0, responce.GetTotalSize());

                    //Wait until client finishes or times out.
                    while (monitor.MaintainConnection()) Thread.Sleep(5);

                    EMS_ServerMainScreen.serverForm.AddConnection($"{DateTime.Now.TimeOfDay.ToString().Remove(8)} {client.Client.RemoteEndPoint} took {monitor.Elapsed}ms");
                    monitor.Dispose();
                });
            }
        }
        class Monitor : IDisposable
        {
            System.Timers.Timer _connectionTimeout = new System.Timers.Timer(Config.ClientRequestTimeout);
            bool _timedout = false;
            TcpClient _client;
            DateTime _startTime = DateTime.Now;
            bool _disposed = false;
            public double Elapsed => (DateTime.Now - _startTime).TotalMilliseconds;
            public Monitor(TcpClient client)
            {
                _client = client;
                _connectionTimeout.Start();
                _connectionTimeout.Elapsed += OnConnectionTimeout;
            }

            /// <summary>
            /// Check if server should maintain the connection
            ///  בדוק אם השרת צריך לשמור על החיבור
            /// </summary>
            public bool MaintainConnection() => TestConnection() && !_timedout;

            /// <summary>
            /// Handeling of connection timeout event. | הפסקת חיבור
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
            /// Tests if client is still connected. | בדיקה שהלקוח עדיין מחובר
            /// </summary>
            private bool TestConnection()
            {
                //true if last operation was succesfull. | אמת אם הפעולה האחרונה הצליחה
                if (_client.Client.Poll(0, SelectMode.SelectRead))
                {
                    //Attempts to recieve an empty message. If it can't then client is disconnected.
                    //ניסיון לקבל הודעה ריקה. אם זה לא יכול אז הלקוח מנותק.
                    if (_client.Client.Receive(new byte[1], SocketFlags.Peek) == 0)
                        return false;
                    else return true;
                }
                return false;
            }

            /// <summary>
            /// Method for releasing resourses.
            /// פעולה לשחרור משאבים
            /// </summary>
            public void Dispose()
            {
                if (!_disposed)
                {
                    _client?.Dispose();
                    _connectionTimeout?.Dispose();
                    _disposed = true;
                    GC.Collect();
                }
            }
        }
    }
}
