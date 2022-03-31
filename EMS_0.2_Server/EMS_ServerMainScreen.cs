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

        private VideoCapture videoCapture = null;
        private Image<Bgr, Byte> curFrame = null;
        Mat frame = new Mat();
        bool faceDetectionEnabled = false;
        CascadeClassifier faceCascadeClassifire = new CascadeClassifier("haarcascade_frontalface_alt.xml");
        bool enableSaveImages = false;
        static bool IsTrained = false;
        List<Image<Gray, Byte>> trainedFaces = new List<Image<Gray, Byte>>();
        List<int> personsLabes = new List<int>();
        EigenFaceRecognizer recognizer;
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
            videoCapture = new VideoCapture();
            videoCapture.ImageGrabbed += ProcessFrame;
            videoCapture.Start();
            bool EnableSaveImages = false;
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            videoCapture.Retrieve(frame, 0);
            curFrame = frame.ToImage<Bgr, Byte>().Resize(videoFeed.Width, videoFeed.Height, Inter.Cubic);
            videoFeed.Image = curFrame.ToBitmap();

            if (faceDetectionEnabled)
            {
                Mat gray = new Mat();
                CvInvoke.CvtColor(curFrame, gray, ColorConversion.Bgr2Gray);
                CvInvoke.EqualizeHist(gray, gray);
                Rectangle[] faces = faceCascadeClassifire.DetectMultiScale(gray, 1.1, 3, Size.Empty, Size.Empty);
                if (faces.Length > 0) //if detected face
                {
                    foreach (Rectangle face in faces)
                    {
                        //Draw square around each face
                        CvInvoke.Rectangle(curFrame, face, new Bgr(Color.Red).MCvScalar, 2, LineType.Filled);
                        faceDetected.Image = curFrame.ToBitmap();

                        //Add person
                        Image<Bgr, Byte> resultImage = curFrame.Convert<Bgr, byte>();
                        resultImage.ROI = face;
                        picDetected.SizeMode = PictureBoxSizeMode.StretchImage;
                        picDetected.Image = resultImage.ToBitmap();

                        if(enableSaveImages)
                        {
                            //Create a dir
                            string path = EMS_Library.Config.EmployeeFilesDir+"\\Training_Images";
                            if(!Directory.Exists(path))
                                Directory.CreateDirectory(path);
                            for (int i = 0; i < 50; i++)
                            {
                                resultImage.Resize(200, 200, Inter.Cubic).Save($"{path}\\test{i}.png");
                            }
                            enableSaveImages = false;
                        }
                        if(btnAddPerson.InvokeRequired)
                        {
                            btnAddPerson.Invoke(new Action(() => { btnAddPerson.Enabled = true; }));
                        }

                        if(IsTrained)
                        {
                            Image<Gray, Byte> grayFace = resultImage.Convert<Gray, byte>().Resize(200, 200, Inter.Cubic);
                            grayFaceBox.Image = grayFace.ToBitmap();
                            var result = recognizer.Predict(grayFace);
                            
                            if (result.Label > 0) //Found known face
                            {
                                WriteToServerConsole("Known");
                            }
                            else //Didn't find known face
                            { 
                                WriteToServerConsole("UnKnown");
                            }
                        }

                    }
                }
            }

        }

        private void btnCaptureFace_Click(object sender, EventArgs e)
        {
            faceDetectionEnabled = true;

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            btnAddPerson.Enabled = false;
            btnSave.Enabled = true;
            enableSaveImages = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnAddPerson.Enabled = true;
            enableSaveImages = false;
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            TrainModelFromDir();
        }
        bool TrainModelFromDir()
        {
            int imagesCount = 0;
            double threshold = 7000;
            trainedFaces.Clear();
            personsLabes.Clear();
            try
            {
                string path = EMS_Library.Config.EmployeeFilesDir + "\\Training_Images";
                string[] images = Directory.GetFiles(path);
                List<Mat> matList = new List<Mat>();
                foreach (string file in images)
                {
                    personsLabes.Add(imagesCount++);
                    matList.Add(new Mat(file));
                }
                foreach (Mat mat in matList)
                    boxTest.Image = mat.ToBitmap();

                recognizer = new EigenFaceRecognizer(imagesCount,threshold);
                recognizer.Train(matList.ToArray(), personsLabes.ToArray());
                IsTrained = true;
                WriteToServerConsole($"Training finished. IsTrained: {IsTrained}");
                return true; ;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Training failed!\n"+ex.Message);
                return IsTrained = false;
            }
        }

        private void faceDetected_Click(object sender, EventArgs e)
        {

        }

        private void btnRecognize_Click(object sender, EventArgs e)
        {

        }
    }
}