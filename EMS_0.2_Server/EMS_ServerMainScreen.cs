using System.Net.Sockets;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Text.RegularExpressions;
using System.Drawing;
using EMS_Library.MyEmployee;
using EMS_Library.MyEmployee.HoursLog;
using EMS_Library.MyEmployee.Divisions;
using EMS_Library.Network;
using EMS_Library;

namespace EMS_Server
{
    public partial class EMS_ServerMainScreen : Form
    {
        #region Variables
        Task FacialRecognition;
        bool scheduleForceExits = true;
        bool scheduleBackup = true;
        bool SQLQuerryInput = false;
        Process FRProcess = null;
        public static EMS_ServerMainScreen serverForm;
        #endregion

        #region Tasks&Tokens
        public Task listeningTask;

        public Task SQLServerLookup;

        public Task TestingTask;

        #endregion

        public EMS_ServerMainScreen()
        {
            InitializeComponent();
            listeningTask = BuildServerTask();
            SQLServerLookup = BuildSQLServerLookup();
            FacialRecognition = BuildFRTask();
            TestingTask = TestingTaskBuilder();
            serverForm = this;
        }

        #region Event Methods
        private void EMS_ServerMainScreen_Load(object sender, EventArgs e)
        {
            SQLServerLookup.Start();
            ServerAddressResolver.ServerIP(true);
            listeningTask.Start();
            TestingTask.Start();
            FacialRecognition.Start();
            listnerTimer.Interval = 6000;
            listnerTimer.Start();
            if (!Directory.Exists(Config.RootDirectory)) Directory.CreateDirectory(Config.RootDirectory);
            if (!Directory.Exists(Config.FR_Images)) Directory.CreateDirectory(Config.FR_Images);
            
        }
        private void listnerTimer_Tick(object sender, EventArgs e)
        {

            if (Config.SQLConnectionString != default)
            {
                ForceExits(); //Automated exit enforcer
                BackupDB();   //Automated Database Backup
            }


            void BackupDB()
            {
                if ((DateTime.Now + new TimeSpan(60000)).Day >= DateTime.Now.Day + 1)
                {
                    if (scheduleBackup)
                    {
                        if (!Directory.Exists(Config.RootDirectory + "\\Backups")) Directory.CreateDirectory(EMS_Library.Config.RootDirectory + "\\Backups");
                        SQLBridge.OneWayCommand($"backup database {Config.SQLDatabaseName } to disk=N'{ Config.RootDirectory}\\Backups\\DB_Backup.{DateTime.Now.Date.ToString("yyyy-MM-dd HH-mm-ss")}.bak' WITH NOFORMAT, NOINIT,  NAME = N'data-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10");
                        scheduleBackup = false;
                    }
                }
                else scheduleBackup = true;
            }

            void ForceExits()
            {
                if ((DateTime.Now + new TimeSpan(60000)).Day >= DateTime.Now.Day + 1)
                {
                    //Auto exit if none present
                    if (scheduleForceExits)
                    {
                        scheduleForceExits = false;
                        SQLBridge.TwoWayCommand($"update {EMS_Library.Config.EmployeeHourLogsTable} set _exit='01-01-0001 00:00:00' where _exit is null;");
                    }
                }
                else scheduleForceExits = true;
            }
        }
        private void btnExit_Click_1(object sender, EventArgs e) => Close();
        private void txtServerConsole_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string[] temp = txtServerConsole.Text.Split(Environment.NewLine);
                txtServerConsole.AppendText(Environment.NewLine);
                if (SQLQuerryInput)
                {
                    if (temp[temp.Length - 1].ToLower() == "sql querry stop")
                    { SQLQuerryInput = false; WriteToServerConsole(Environment.NewLine + "stoped"); return; }
                    if (temp[temp.Length - 1].ToLower().Contains("select"))
                    {
                        WriteToServerConsole("");
                        WriteToServerConsole(SQLBridge.TwoWayCommand(temp[temp.Length - 1].ToLower()).Split('|'));
                    }
                    else
                    {
                        WriteToServerConsole("");
                        WriteToServerConsole(SQLBridge.OneWayCommand(temp[temp.Length - 1].ToLower()));
                    }
                    return;
                }
                else
                    switch (temp[temp.Length - 1].ToLower())
                    {
                        default: break;
                        case "close": { Close(); break; }
                        case "terminate": { Close(); break; }
                        case "exit": { Close(); break; }
                        case "shutdown": { Close(); break; }
                        case "sql querry begin": { SQLQuerryInput = true; WriteToServerConsole(Environment.NewLine + "Listening for querry:"); break; }
                        case "fr powerup": { try { FRProcess.Start(); } catch { } break; }
                        case "fr shutdown": { try { FRProcess.Kill(); WriteToServerConsole(FRProcess.ProcessName + " " + FRProcess.HasExited); } catch { } break; }
                        case "simmulate": {
                                string id = SQLBridge.TwoWayCommand($"SELECT TOP 1 _intId FROM {Config.EmployeeDataTable} ORDER BY _created DESC; ");
                                WriteToServerConsole("Pupulating log for " + id);
                                DateTime curDate = DateTime.Now;
                                int count = 0;
                                for (int j = 1; j <= 12; j++)
                                    for (int i = 1; i <= DateTime.DaysInMonth(curDate.Year, j); i++)
                                    {
                                        if (Config.WorkDaysInWeek.Contains((int)new DateTime(curDate.Year, j, i).DayOfWeek))
                                        {
                                            string querry = $"insert into {Config.EmployeeHourLogsTable} values " +
                                                $"({id}, " +
                                                $"'{new DateTime(curDate.Year, j, i, Utility.RandomInt(7, 9), 0, 0).ToString("yyyy-MM-dd HH:mm:ss")}', " +
                                                $"'{new DateTime(curDate.Year, j, i, Utility.RandomInt(15, 17), 0, 0).ToString("yyyy-MM-dd HH:mm:ss")}');";
                                            count += int.Parse(SQLBridge.OneWayCommand(querry));
                                        }
                                    }
                                WriteToServerConsole($"Max: {curDate.TotalAmountOfDays()}, Added: {count}");
                                break; }
                    }
            }
        }
        private void FRStoped(object sender, EventArgs e)
        {
            WriteToServerConsole("fr stoped");
        }
        private void EMS_ServerMainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            FRProcess.Kill();
            FacialRecognition.Dispose();
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
        public void WriteToServerConsole(string[] text)
        {
            foreach (string s in text)
                WriteToServerConsole(s);
        }
        private void WriteToConfigFile()
        {
            EMS_Library.Config.PythonDBConnection =
                $"Driver={{SQL Server Native Client 11.0}};|" +
                $"Server={EMS_Library.Config.SQLServerNames[EMS_Library.Config.ServerNamesIterator < 1 ? 0 : EMS_Library.Config.ServerNamesIterator - 1]};|" +
                $"Database=EmployeeManagmentDataBase;|" +
                $"Trusted_Connection=yes;";

            string str = $"" +
                $"ServerIP#{EMS_Library.Config.ServerIP}" + Environment.NewLine +
                $"ServerPort#{EMS_Library.Config.ServerPort}\n" + Environment.NewLine +
                $"RootDirectory#{EMS_Library.Config.RootDirectory}\n" + Environment.NewLine +
                $"FR_Location#{EMS_Library.Config.FR_Location}\n" + Environment.NewLine +
                $"PythonDBConnection#{EMS_Library.Config.PythonDBConnection}\n" + Environment.NewLine +
                $"NormalShiftLength#{EMS_Library.Config.NormalShiftLength}\n" + Environment.NewLine +
                $"MaxShiftLength#{EMS_Library.Config.MaxShiftLength}";
            File.WriteAllText(Directory.GetCurrentDirectory() + "\\Config.txt", str);
        }
        public Task BuildServerTask()
        {
            return new Task(() =>
            {
                if (!SQLServerLookup.IsCompleted) SQLServerLookup.Wait();
                WriteToServerConsole("Server started");
                ConnectionsManager.Listen();
            });
        }
        public Task BuildSQLServerLookup()
        {
            return new Task(() =>
            {
                while (true)
                {
                    string SQLConnectionString = $"" +
                        $"server={Config.SQLServerName};" +
                        $"database={Config.SQLDatabaseName};" +
                        $"Integrated Security=SSPI;" +
                        $"Connection Timeout=1";
                    SqlConnection connenction = new SqlConnection(SQLConnectionString);

                    WriteToServerConsole("attempting " + SQLConnectionString);
                    try { connenction.Open(); }
                    catch
                    {
                        if (EMS_Library.Config.ServerNamesIterator > Config.SQLServerNames.Length)
                        { MessageBox.Show("Couldn't find sql server!"); Close(); }
                    }
                    if (connenction.State == System.Data.ConnectionState.Open)
                    {
                        WriteToServerConsole("SQL Server Found.");
                        connenction.Close();
                        connenction.Dispose();
                        Config.SQLConnectionString = SQLConnectionString;
                        break;
                    }
                }
                WriteToConfigFile();
            });
        }
        public void AddConnection(string data)
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (connectionsList.Items.Count > 30)
                    connectionsList.Items.RemoveAt(0);
                connectionsList.Items.Add(data);
            });
        }

        /// <summary>
        /// Build facial recognition task
        /// </summary>
        /// <returns></returns>
        public Task BuildFRTask()
        {
            return new Task(() =>
            {
                FRProcess = new Process();
                FRProcess.StartInfo.FileName = "IdentifyAndUpdateHours.py";
                FRProcess.StartInfo.UseShellExecute = true;
                FRProcess.Start();
                FRProcess.Exited += this.FRStoped;
            });
        }
        #endregion

        #region Debug
        private Task TestingTaskBuilder()
        {
            return new Task(() =>
            {
                if (!SQLServerLookup.IsCompleted) SQLServerLookup.Wait();
                #region Add 20 random eployees to DB
                /*
                    for (int i = 0; i < 20; i++)
                    {
                        string responce = SQLBridge.OneWayCommand(SQLBridge.Add("#" + Employee.RandomEmployeeGenerator(int.Parse(SQLBridge.GetFreeID())).ToString()));
                        WriteToServerConsole(responce);
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
                /*
                string logData = SQLBridge.TwoWayCommand(SQLBridge.GetMonthLog($"get log #111111111, 2022, 05"));
                string employee = SQLBridge.TwoWayCommand("select * from Employees where _intId=111111111");
                HoursLogMonth log = new HoursLogMonth(logData, Employee.ActivateEmployee(employee.Split('|')[0].Split(',')));
                WriteToServerConsole(log.JSON());
                */
                #endregion
                #region Write Logs to file
                //System.IO.File.WriteAllText(EMS_Library.Config.RootDirectory+"\\log.json", log.JSON());
                #endregion
                //Employee emp = Employee.ActivateEmployee(SQLBridge.TwoWayCommand("select * from Employees where _intId=111111111;").Split('|')[0].Split(','));
                //WriteToServerConsole(emp.GetDirectory.ToString());

                //FR().Start();
            });
        }
        #endregion


    }
}