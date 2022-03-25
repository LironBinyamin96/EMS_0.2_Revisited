using System.Net.Sockets;
using EMS_Library.Network;
using System.Data.SqlClient;
using System.Data.Sql;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using System.Text.RegularExpressions;
using System.Drawing;
namespace EMS_Server
{
    public partial class EMS_ServerMainScreen : Form
    {

        #region Variables
        TcpListener listener = new TcpListener(System.Net.IPAddress.Parse(EMS_Library.Config.ServerIP), EMS_Library.Config.ServerPort);
        TcpClient client = null;

        private VideoCapture vc = null;
        private Image<Bgr, Byte> curFrame = null;
        Mat frame = new Mat();
        bool faceDetectionEnabled = false;
        CascadeClassifier faceCascadeClassifire = new CascadeClassifier("haarcascade_frontalface_alt.xml");
        #endregion

        #region Tasks&Tokens
        public Task listeningTask;
        public CancellationTokenSource listner_CXL_Src = new CancellationTokenSource();
        CancellationToken listner_CXL;

        public Task SQLServerLookup;
        public CancellationTokenSource SQLLookup_CXL_Src = new CancellationTokenSource();
        CancellationToken SQLLookup_CXL;

        //public Task SQLServerLookup;

        #endregion

        public EMS_ServerMainScreen()
        {
            InitializeComponent();
            listeningTask = BuildServerTask();
            listner_CXL = listner_CXL_Src.Token;
            SQLServerLookup = BuildSQLServerLookup();
            SQLLookup_CXL = SQLLookup_CXL_Src.Token;
        }

        #region Event Methods
        private void EMS_ServerMainScreen_Load(object sender, EventArgs e)
        {
            listener.Start();
            listeningTask.Start();
            SQLServerLookup.Start();
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
            Testing();
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
            }
        }
        private void btnExit_Click_1(object sender, EventArgs e) => Close();
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

        #endregion

        private void Testing()
        {
            //TcpClient tcpClient = new TcpClient(EMS_Library.Config.ServerIP, EMS_Library.Config.ServerPort);
            //NetworkStream stream = tcpClient.GetStream();
            //DataPacket data = new DataPacket($"select * from Employees", 254);
            //stream.Write(data.Write(), 0, data.GetTotalSize());
            //WriteToServerConsole("Client made a request!");
            //DataPacket response = new DataPacket(stream);
            //WriteToServerConsole($"Client recieved response [{response}]");
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            vc = new VideoCapture();
            vc.ImageGrabbed += ProcessFrame;
            vc.Start();
        }

        private void ProcessFrame(object? sender, EventArgs e)
        {
            vc.Retrieve(frame, 0);
            curFrame = frame.ToImage<Bgr, byte>().Resize(videoFeed.Width, videoFeed.Height, Inter.Cubic);
            videoFeed.Image = curFrame.ToBitmap();

            if(faceDetectionEnabled)
            {
                Mat gray = new Mat();
                CvInvoke.CvtColor(curFrame, gray, ColorConversion.Bgr2Gray);
                CvInvoke.EqualizeHist(gray, gray);
                Rectangle[] faces = faceCascadeClassifire.DetectMultiScale(gray, 1.1,3,Size.Empty,Size.Empty); //change
                if(faces.Length > 0) //if detected face
                {
                    foreach(Rectangle face in faces)
                    {
                        //Draw square around each face
                        CvInvoke.Rectangle(curFrame, face, new Bgr(Color.LightSkyBlue).MCvScalar, 2);

                    }
                }
            }

        }

        private void btnCaptureFace_Click(object sender, EventArgs e)
        {
            faceDetectionEnabled = true;

        }


    }
}