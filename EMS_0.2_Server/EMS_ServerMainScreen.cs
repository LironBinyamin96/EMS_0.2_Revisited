using EMS_Library;
using EMS_Library.Network;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace EMS_Server
{
    public partial class EMS_ServerMainScreen : Form
    {
        #region Variables
        Task FacialRecognition;
        bool scheduleForceExits = true; //Insuring that force exits occures only once. (this value is false during execution of ForceExits() method);
        bool scheduleBackup = true; //Insuring that DB backup occures only once. (this value is false during execution of BackupDB() method);
        bool SQLQuerryInput = false; //Tracking of console state for direct SQL injection.
        Process FRProcess = null; //Pointer to FR process. (Used for it's propper termination.)
        public static EMS_ServerMainScreen serverForm; //Pointer to the main server screen.
        #endregion

        #region Tasks&Tokens
        //Variables for various server treads.
        public Task listeningTask;

        public Task SQLServerLookup;

        public Task TestingTask;

        #endregion

        /// <summary>
        /// EMS_Server Form constructor. | בנאי
        /// </summary>
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
        /// <summary>
        /// Used for starting threads that must be executed on load. (Triggered by Load event)
        /// משתמש להפעלת תהליכים שצריכים להיות מופעלים בעת הפעלת התוכנית
        /// </summary>
        private void EMS_ServerMainScreen_Load(object sender, EventArgs e)
        {
            SQLServerLookup.Start();
            ServerAddressResolver.ServerIP(true);
            WriteToServerConsole($"IP in use: {Config.ServerIP}, port: {Config.ServerPort}");
            listeningTask.Start();
            TestingTask.Start();
            if (Config.AutoStartFR) FacialRecognition?.Start(); else WriteToServerConsole("FR Autostart disabled in the config!");
            listnerTimer.Interval = 6000;
            listnerTimer.Start();
            if (!Directory.Exists(Config.RootDirectory)) Directory.CreateDirectory(Config.RootDirectory);
            if (!Directory.Exists(Config.FR_Images)) Directory.CreateDirectory(Config.FR_Images);

        }

        /// <summary>
        /// Method for executing time dependant logic. (Triggered by listnerTimer_Tick event)
        /// פעולה לביצוע לוגיקה שתלויה בזמן
        /// </summary>
        private void listnerTimer_Tick(object sender, EventArgs e)
        {

            if (Config.SQLConnectionString != default)
            {
                ForceExits(); //Automated exit enforcer
                BackupDB();   //Automated Database Backup
            }

            //DB backup method | גיבוי
            void BackupDB()
            {
                if ((DateTime.Now + new TimeSpan(60000)).Day >= DateTime.Now.Day + 1)
                {
                    if (scheduleBackup)
                    {
                        if (!Directory.Exists(Config.RootDirectory + "\\Backups")) Directory.CreateDirectory(EMS_Library.Config.RootDirectory + "\\Backups");
                        SQLBridge.OneWayCommand($"backup database {Config.SQLDatabaseName} to disk=N'{Config.RootDirectory}\\Backups\\DB_Backup.{DateTime.Now.Date.ToString("yyyy-MM-dd HH-mm-ss")}.bak' WITH NOFORMAT, NOINIT,  NAME = N'data-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10");
                        scheduleBackup = false;
                    }
                }
                else scheduleBackup = true;
            }

            void ForceExits()
            {
                if ((DateTime.Now + new TimeSpan(60000)).Day >= DateTime.Now.Day + 1)
                {
                    //Auto exit if none present | יציאה אוטומטית אם לא קיים
                    if (scheduleForceExits)
                    {
                        scheduleForceExits = false;
                        SQLBridge.TwoWayCommand($"update {EMS_Library.Config.EmployeeHourLogsTable} set _exit='01-01-0001 00:00:00' where _exit is null;");
                    }
                }
                else scheduleForceExits = true;
            }
        }

        /// <summary>
        /// Triggering propper Close() method. (Triggered by X button)
        /// </summary>
        private void btnExit_Click_1(object sender, EventArgs e) => Close();

        /// <summary>
        /// Handeling console commands. (Triggered by txtServerConsole_KeyPress event)
        /// טיפול בפקודות הקונסול
        /// </summary>
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
                        case "fr powerup": { try { if (FacialRecognition.Status == TaskStatus.RanToCompletion) FRProcess.Start(); else FacialRecognition.Start(); WriteToServerConsole(FRProcess?.ProcessName + " Powering up"); } catch { } break; }
                        case "fr shutdown": { try { FRProcess.Kill(); WriteToServerConsole(FRProcess?.ProcessName + " Powering down"); } catch { } break; }
                        case "simmulate":
                            {
                                string id = SQLBridge.TwoWayCommand($"SELECT TOP 1 _intId FROM {Config.EmployeeDataTable} ORDER BY _created DESC; ");
                                WriteToServerConsole("Pupulating log for " + id);

                                //Check existance of entries for this employee. (Preventing excessive amount of hours.)
                                // (בדוק את קיומם של ערכים עבור עובד זה. (מניעת כמות מוגזמת של שעות
                                if (int.TryParse(SQLBridge.TwoWayCommand($"select count(*) from {Config.EmployeeHourLogsTable} where _intId={id}"), out int entryIntcount) && entryIntcount > 0)
                                {
                                    WriteToServerConsole(
                                        $"This employee already have some entries.{Environment.NewLine}" +
                                        $"Running this simulation might result in employee \"working\" for more than {Config.MaxShiftLength.Hours} hours a day.{Environment.NewLine}" +
                                        $"Terminated.");
                                    break;
                                }

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
                                break;
                            }
                        case "clear before simmulation":
                            {
                                WriteToServerConsole("Cleared: " + SQLBridge.OneWayCommand(
                                    $"delete from {Config.EmployeeHourLogsTable} " +
                                    $"where  _intId=(SELECT TOP 1 _intId FROM {Config.EmployeeDataTable} ORDER BY _created DESC);"));
                                break;
                            }
                    }
            }

           


        }

        /// <summary>
        /// Notification on Facial recognition stopped.
        /// עצירת זיהוי פנים
        /// </summary>
        private void FRStoped(object sender, EventArgs e)
        {
            WriteToServerConsole("fr stoped");
        }

        /// <summary>
        /// Method for terminating EMS_Server subprocesses. (Triggered by FormClosing event)
        /// פעולה לסיום תהליכי משנה של השרת
        /// </summary>
        private void EMS_ServerMainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            FRProcess?.Kill();
        }

        /// <summary>
        /// Method for terminating EMS_Server subprocesses. (Triggered by FormClosing event)
        /// פעולה לסיום תהליכי משנה של השרת
        /// </summary>
        private void EMS_ServerMainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            FRProcess?.Kill();
        }
        #endregion

        #region NonEvent Methods
        /// <summary>
        /// Outputs provided texts to server's console.
        /// הדפסת טקסטים בקונסול
        /// </summary>
        public void WriteToServerConsole(string text)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtServerConsole.AppendText(text + Environment.NewLine);
                Console.WriteLine(text + "\n");
            });
        }
        /// <summary>
        /// Outputs provided text to server's console.
        /// הדפסת טקסטים בקונסול
        /// </summary>
        public void WriteToServerConsole(string[] text)
        {
            foreach (string s in text)
                WriteToServerConsole(s);
        }
        /// <summary>
        /// Generates config.txt file for FR consumption.
        /// יצירת קובץ התחברות בשביל מערכת זיהוי פנים
        /// </summary>
        private void WriteToConfigFile()
        {
            Config.PythonDBConnection =
                $"Driver={{SQL Server Native Client 11.0}};|" +
                $"Server={Config.SQLServerNames[Config.ServerNamesIterator < 1 ? 0 : Config.ServerNamesIterator - 1]};|" +
                $"Database=EmployeeManagmentDataBase;|" +
                $"Trusted_Connection=yes;";

            string str = $"" +
                $"ServerIP#{Config.ServerIP}" + Environment.NewLine +
                $"ServerPort#{Config.ServerPort}\n" + Environment.NewLine +
                $"RootDirectory#{Config.RootDirectory}\n" + Environment.NewLine +
                $"FR_Location#{Config.FR_Location}\n" + Environment.NewLine +
                $"PythonDBConnection#{Config.PythonDBConnection}\n" + Environment.NewLine +
                $"NormalShiftLength#{Config.NormalShiftLength}\n" + Environment.NewLine +
                $"MaxShiftLength#{Config.MaxShiftLength}\n" + Environment.NewLine +
                $"EmployeeDataTable#{Config.EmployeeDataTable}\n" + Environment.NewLine +
                $"EmployeeLogsTable#{Config.EmployeeHourLogsTable}\n" + Environment.NewLine +
                $"DataBaseName#{Config.SQLDatabaseName}\n"+Environment.NewLine +
                $"ImageFormat#{Config.ImageFormat}\n" + Environment.NewLine;
            File.WriteAllText(Directory.GetCurrentDirectory() + "\\Config.txt", str);
            File.WriteAllText(Config.RootDirectory + "\\Config.txt", str);
        }
        /// <summary>
        /// Provides primary listening tread for the server.
        /// האזנה של השרת
        /// </summary>
        public Task BuildServerTask()
        {
            return new Task(() =>
            {
                if (!SQLServerLookup.IsCompleted) SQLServerLookup.Wait();
                WriteToServerConsole("Server started");
                ConnectionsManager.Listen();
            });
        }
        /// <summary>
        /// Provides thread for SQLServer lookup.
        /// פעולה לחיפוש בסיס הנתונים
        /// </summary>
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
                        if (Config.ServerNamesIterator > Config.SQLServerNames.Length)
                        { MessageBox.Show("Couldn't find sql server!"); serverForm.Close(); }
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
        /// <summary>
        /// Populates Connsections list.
        /// שמירה של רשימת החיבורים
        /// </summary>
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
        /// Provides thread for facial recognition.
        /// תהליך להפעלת זיהוי פנים
        /// </summary>
        public Task BuildFRTask()
        {
            return new Task(() =>
            {
                if (!SQLServerLookup.IsCompleted) SQLServerLookup.Wait();
                FRProcess = new Process();
                FRProcess.StartInfo.FileName = "IdentifyAndUpdateHours.py";
                FRProcess.StartInfo.UseShellExecute = true;
                FRProcess.Start();
                FRProcess.Exited += FRStoped;
                FRProcess.Disposed += FRStoped;
            });
        }
        #endregion

        /// <summary>
        /// Prevents storage of excessive amounts of text.
        /// מונע אחסון של כמויות מופרזות של טקסט
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtServerConsole_TextChanged(object sender, EventArgs e)
        {
            string[] temp = txtServerConsole.Text.Split(Environment.NewLine);
            if (temp.Length > 30) txtServerConsole.Text = temp.TakeLast(30).ToArray().ArrayToString();
        }

        #region Debug
        /// <summary>
        /// Provides thread for testing and devolopement purposes.
        /// </summary>
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