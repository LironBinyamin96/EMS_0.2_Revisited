using System.Net.Sockets;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Text.RegularExpressions;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using EMS_Library.MyEmployee;
using EMS_Library.MyEmployee.HoursLog;
using EMS_Library.MyEmployee.Divisions;
using EMS_Library.Network;

namespace EMS_Server
{
    public partial class EMS_ServerMainScreen : Form
    {

        #region Variables
        TcpListener listener = new TcpListener(System.Net.IPAddress.Parse(EMS_Library.Config.ServerIP), EMS_Library.Config.ServerPort);
        TcpClient client = null;
        Process FR_Process = new Process();
        bool scheduleForceExits = true;
        #endregion

        #region Tasks&Tokens
        public Task listeningTask;
        public CancellationTokenSource listner_CXL_Src = new CancellationTokenSource();
        CancellationToken listner_CXL;

        public Task SQLServerLookup;
        public CancellationTokenSource SQLLookup_CXL_Src = new CancellationTokenSource();
        CancellationToken SQLLookup_CXL;

        public Task FRTrainer;
        public CancellationTokenSource FRTrainer_CXL_Src = new CancellationTokenSource();
        CancellationToken FRTrainer_CXL;

        public Task TestingTask;

        #endregion

        public EMS_ServerMainScreen()
        {
            InitializeComponent();
            listeningTask = BuildServerTask();
            listner_CXL = listner_CXL_Src.Token;
            SQLServerLookup = BuildSQLServerLookup();
            SQLLookup_CXL = SQLLookup_CXL_Src.Token;
            TestingTask = TestingTaskBuilder();
        }

        #region Event Methods
        private void EMS_ServerMainScreen_Load(object sender, EventArgs e)
        {
            SQLServerLookup.Start();
            listener.Start();
            listeningTask.Start();
            TestingTask.Start();

            listnerTimer.Interval = 60000;
            listnerTimer.Start();

        }
        private void listnerTimer_Tick(object sender, EventArgs e)
        {
            if (EMS_Library.Config.SQLConnectionString != default)
            {
                if ((DateTime.Now + new TimeSpan(300000000000)).Day >= DateTime.Now.Day + 1)
                {
                    if (scheduleForceExits)
                    {
                        scheduleForceExits = false;
                        SQLBridge.TwoWayCommand("update HourLogs set _exit='01-01-0001 00:00:00' where _exit is null;");
                    }
                }
                else scheduleForceExits = true;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TestingTask.Start();
        }
        private void btnExit_Click_1(object sender, EventArgs e) => Close();      
        private void btnSimExit_Click(object sender, EventArgs e)
        {
            WriteToServerConsole(SQLBridge.Departure("111111111"));
            WriteToServerConsole(SQLBridge.OneWayCommand(SQLBridge.Departure("111111111")));
        }
        private void btnSimEnter_Click(object sender, EventArgs e)
        {
            WriteToServerConsole(SQLBridge.Arrival("111111111"));
            WriteToServerConsole(SQLBridge.OneWayCommand(SQLBridge.Arrival("111111111")));
        }
        #endregion

        #region NonEvent Methods
        public void WriteToServerConsole(string text)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtServerConsole.AppendText(text + Environment.NewLine);
                Console.WriteLine(text + "\n");
            });
        }
        public Task BuildServerTask()
        {
            return new Task(() =>
            {
                if (!SQLServerLookup.IsCompleted) SQLServerLookup.Wait();
                WriteToServerConsole("Server started");
                while (true)
                {
                    WriteToServerConsole($"Listening...");
                    client = listener.AcceptTcpClient();
                    WriteToServerConsole($"client: " + client.Client.RemoteEndPoint);
                    listnerTimer.Start();
                    try
                    {
                        NetworkStream stream = client.GetStream();
                        DataPacket data = new DataPacket(stream);
                        WriteToServerConsole("Request:\n" + data.StringData);
                        string responseStr = new MyRouter().Router(data);
                        DataPacket response = new DataPacket(responseStr, 255);
                        WriteToServerConsole(responseStr);
                        stream.Write(response.Write(), 0, response.GetTotalSize());
                        client.Close();
                        client.Dispose();
                    }
                    catch (Exception ex) { Console.WriteLine(ex); }
                    WriteToServerConsole("Connection closed.");
                }
            }, listner_CXL);
        }
        public Task BuildSQLServerLookup()
        {
            return new Task(() =>
            {
                while (true)
                {
                    string SQLConnectionString = $"" +
                        $"server={EMS_Library.Config.SQLServerName};" +
                        $"database={EMS_Library.Config.SQLDatabaseName};" +
                        $"Integrated Security=SSPI;" +
                        $"Connection Timeout=1";
                    SqlConnection connenction = new SqlConnection(SQLConnectionString);

                    WriteToServerConsole("attempting " + SQLConnectionString);
                    try { connenction.Open(); }
                    catch
                    {
                        if (EMS_Library.Config.ServerNamesIterator > EMS_Library.Config.SQLServerNames.Length)
                        { MessageBox.Show("Couldn't find sql server!"); Close(); }
                    }
                    if (connenction.State == System.Data.ConnectionState.Open)
                    {
                        WriteToServerConsole("SQL Server Found.");
                        connenction.Close();
                        connenction.Dispose();
                        EMS_Library.Config.SQLConnectionString = SQLConnectionString;
                        break;
                    }
                }
            }, SQLLookup_CXL);
        }  
        private Task TestingTaskBuilder()
        {
            return new Task(() =>
            {
                if (!SQLServerLookup.IsCompleted) SQLServerLookup.Wait();
                #region Add 20 random eployees to DB
                /*
                    for (int i = 0; i < 20; i++)
                    {
                        string response = SQLBridge.OneWayCommand(SQLBridge.Add("#" + Employee.RandomEmployeeGenerator(int.Parse(SQLBridge.GetFreeID())).ToString()));
                        WriteToServerConsole(response);
                        Thread.Sleep(1000);
                    }
                 */
                #endregion
                #region Auto logs
                /*
                {
                    string[] ids = SQLBridge.TwoWayCommand("select _intId from " + EMS_Library.Config.EmployeeDataTable).Split('|');
                    foreach (string id in ids)
                    {
                        DateTime time = EMS_Library.Utility.RandomDateTime();
                        WriteToServerConsole(time.ToString());
                        WriteToServerConsole(SQLBridge.OneWayCommand($"insert into HourLogs (_intId) values ({id});"));
                        string x = $"update HorLogs set _entry={time.ToString()} where _intId={id.ToString()};";
                        WriteToServerConsole(SQLBridge.OneWayCommand($"update HourLogs set _entry='{time.ToString("yyyy-MM-dd HH:mm:ss")}' where _intId={id};"));
                        WriteToServerConsole(SQLBridge.OneWayCommand($"" +
                                $"update HourLogs " +
                                $"set _exit='{(time + new TimeSpan(8, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")}'" +
                                $"where _intId={id};"));
                    }
                }
                */
                #endregion
                #region Get me some logs
                string responce = SQLBridge.TwoWayCommand(SQLBridge.GetMonthLog($"get log #111111111, 2022, 05"));
                WriteToServerConsole(responce);
                HoursLogMonth log = new HoursLogMonth(responce);
                foreach(var a in log.GetDays)
                {
                    WriteToServerConsole(a.ToString());
                }
                #endregion
                #region Write Logs to file
                System.IO.File.WriteAllText(EMS_Library.Config.RootDirectory+"\\log.json", log.JSON());
                #endregion

            });
        }
        #endregion

        private void txtServerConsole_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                string[] temp = txtServerConsole.Text.Split(Environment.NewLine);
                switch (temp[temp.Length - 1].ToLower())
                {
                    default: break;
                    case "close": { Close(); break; }
                    case "terminate": { Close(); break; }
                    case "exit": { Close(); break; }
                    case "shutdown": { Close(); break; }
                    case "fr powerup": { try { FR_Process.Start(); } catch { } break;  }
                    case "fr shutdown": { try { FR_Process.Close(); } catch { } break; }
                }
            }
        }
    }
}