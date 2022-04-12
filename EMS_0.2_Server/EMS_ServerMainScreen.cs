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
using EMS_Library.MyEmployee.Divisions;
using EMS_Library.Network;

namespace EMS_Server
{
    public partial class EMS_ServerMainScreen : Form
    {

        #region Variables
        TcpListener listener = new TcpListener(System.Net.IPAddress.Parse(EMS_Library.Config.ServerIP), EMS_Library.Config.ServerPort);
        TcpClient client = null;

        private VideoCapture cam;
        private Image<Bgr, Byte> curFrame;
        Mat frame = new Mat();
        CascadeClassifier faceCascadeClassifire = new CascadeClassifier("haarcascade_frontalface_alt.xml");
        
        EigenFaceRecognizer recognizer;
        List<int> personsLabels = new List<int>();
        List<int> employeeIds = new List<int>();
        Process FR_Process = new Process();


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
            FRTrainer = BuildFRTrainer();
            FRTrainer_CXL = FRTrainer_CXL_Src.Token;
            FR_Process.StartInfo.FileName = EMS_Library.Config.FR_Location;

            TestingTask = TestingTaskBuilder();
        }

        #region Event Methods
        private void EMS_ServerMainScreen_Load(object sender, EventArgs e)
        {
            
            listener.Start();
            listeningTask.Start();
            SQLServerLookup.Start();
            TestingTask.Start();

            //FRTrainer.Start();

            cam = new VideoCapture();
            cam.ImageGrabbed += ProcessFrame;
            cam.Start();
        }
        private void listnerTimer_Tick(object sender, EventArgs e)
        {
            client.Close();
            client.Dispose();
            WriteToServerConsole("Client aborted!");
            listnerTimer.Stop();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void txtServerConsole_TextChanged(object sender, EventArgs e)
        {
            string[] temp = txtServerConsole.Text.Split(Environment.NewLine);
            switch (temp[temp.Length - 2].ToLower())
            {
                default: break;
                case "close": { Close(); break; }
                case "terminate": { Close(); break; }
                case "exit": { Close(); break; }
                case "shutdown": { Close(); break; }
                case "fr powerup": { FR_Process.Start(); break; }
                case "fr Shotdown": { FR_Process.Close(); break; }
            }
        }
        private void btnExit_Click_1(object sender, EventArgs e) => Close();
        public void ProcessFrame(object sender, EventArgs e)
        {
            cam.Retrieve(frame, 0);
            curFrame = frame.ToImage<Bgr, Byte>().Resize(cam1Feed.Width, cam1Feed.Height, Inter.Cubic);
            cam1Feed.Image = curFrame.ToBitmap();
            Mat gray = new Mat();
            CvInvoke.CvtColor(curFrame, gray, ColorConversion.Bgr2Gray);
            CvInvoke.EqualizeHist(gray, gray);
            Rectangle[] faces = faceCascadeClassifire.DetectMultiScale(gray, 1.1, 3, Size.Empty, Size.Empty);
            if (faces.Length > 0) //if detected face
            {
                foreach (Rectangle face in faces)
                {
                    
                    CvInvoke.Rectangle(curFrame, face, new Bgr(Color.Red).MCvScalar, 2, LineType.Filled);
                    if(FRTrainer.IsCompleted)
                    {
                        try { 
                        var result = recognizer.Predict(curFrame);
                        CvInvoke.PutText(curFrame, employeeIds[result.Label].ToString(), new Point(face.X - 2, face.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                        }catch (Exception ex) { WriteToServerConsole(ex.Message); }
                    }
                    
                    cam1Feed.Image = curFrame.ToBitmap();
                }
            }
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
        public Task BuildFRTrainer()
        {
            return new Task(() =>
            {
                while (!SQLServerLookup.IsCompleted) { }
                if (!Directory.Exists(EMS_Library.Config.RootDirectory)) throw new Exception("Root directory doesn't exist!");
                string[] _intIdsString = SQLBridge.TwoWayCommand("select _intId from Employees").Split('|');
                List<EmployeeDirectory> empDirs = new List<EmployeeDirectory>();
                foreach (string _intId in _intIdsString)
                    if (_intId.Length == 9)
                        empDirs.Add(new EmployeeDirectory(int.Parse(_intId)));
                foreach(EmployeeDirectory employeeDirectory in empDirs)
                {
                    List<Mat> matList = new List<Mat>();
                    List<int> empImageCounter = new List<int>();
                    int imagesCount = 0;
                    foreach (var file in employeeDirectory.TrainingImmagesDir.GetFiles())
                    {
                        personsLabels.Add(imagesCount++);
                        matList.Add(new Mat(file.FullName));
                    };
                    employeeIds.Add(employeeDirectory.IntId);
                    recognizer = new EigenFaceRecognizer(imagesCount, 7000);
                    recognizer.Train(matList.ToArray(), personsLabels.ToArray());
                    WriteToServerConsole("FR Trained");
                }
            }, FRTrainer_CXL);
        }

        

        #endregion

        private Task TestingTaskBuilder()
        {
            return new Task(() => {
                while (SQLServerLookup.Status == TaskStatus.Running) { }

                {
                    /*
                    for (int i = 0; i < 20; i++)
                    {
                        string response = SQLBridge.OneWayCommand(SQLBridge.Add("#" + Employee.RandomEmployeeGenerator(int.Parse(SQLBridge.GetFreeID())).ToString()));
                        WriteToServerConsole(response);
                        Thread.Sleep(1000);
                    }
                    */
                } //Add 20 random eployees to DB

                {
                    /*
                    string[] ids = SQLBridge.TwoWayCommand("select _intId from Employees").Split('|');
                    foreach (string id in ids)
                    {
                        DateTime time = EMS_Library.Utility.RandomDateTime();
                        WriteToServerConsole(SQLBridge.OneWayCommand($"insert into HourLogs (_intId) values ({id});"));
                        string x = $"update HorLogs set _entry={time.ToString()} where _intId={id.ToString()};";
                        WriteToServerConsole(SQLBridge.OneWayCommand($"update HourLogs set _entry={time.ToString("yyyyMMdd")} where _intId={id};"));
                        WriteToServerConsole(SQLBridge.OneWayCommand($"" +
                                $"update HourLogs " +
                                $"set _entry={(time + new TimeSpan(8, 0, 0)).ToString("yyyyMMdd")}" +
                                $"where _intId={id};"));
                    }
                    */
                }//Auto logs attempt


            });
        }

        private void btnSimExit_Click(object sender, EventArgs e)
        {

        }

        private void btnSimEnter_Click(object sender, EventArgs e)
        {

        }
    }
}