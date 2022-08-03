using EMS_Client.Forms;
using System.Runtime.InteropServices;
using EMS_Library.MyEmployee;
using EMS_Library.MyEmployee.HoursLog;
using EMS_Library;
namespace EMS_Client
{
    public partial class EMS_ClientMainScreen : Form
    {
        #region Variables
        public static Stack<Form> PrimaryForms = new Stack<Form>();
        public static Employee CurEmployee;
        public static Employee employee;
        private Form activeForm; // משתנה עזר ששומר את החלון הנוכחי
        #endregion

        // סימון הכפתורים
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        public EMS_ClientMainScreen()
        {
            InitializeComponent();
            PrimaryForms.Push(this);
            // סימון הכפתורים
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        public void openChildForm(Form child, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(child);
            this.panelDesktop.Tag = child;
            child.BringToFront();
            child.Show();
        }
        private void EMS_ClientMainScreen_Load(object sender, EventArgs e)
        {
            if(!Directory.Exists(Config.RootDirectory)) //Create working directory if it doesn't exist
                Directory.CreateDirectory(Config.RootDirectory);
            Action serverLookup = () =>
            {
                EMS_Library.Network.ServerAddressResolver.ServerIP(false);
                (Array.Find(PrimaryForms.ToArray(), x=>x is EMS_ClientMainScreen) as EMS_ClientMainScreen).Invoke(()=>PrimaryForms.Pop().Close());
                if (EMS_Library.Network.ServerAddressResolver.LookedUp) //Message reminding to update ServerIp configurations 
                    MessageBox.Show($"Had to serach for the server!\nServer ip is {Config.ServerIP}\nPlease update client config files to reduce boot time");
            };
            StandbyScreen standby = new StandbyScreen(serverLookup);
            standby.ShowDialog();

            Login login = new Login();
            PrimaryForms.Push(login);
            login.ShowDialog();
            if (PrimaryForms.Count>0) //App wasn't closed at login screen
            {
                EMS_Library.Network.DataPacket packet = new EMS_Library.Network.DataPacket($"get image #{CurEmployee.IntId}", 6);
                byte[] buffer = Requests.GetImage(packet);
                if (!buffer.IsEmpty(10))
                {
                    /*
                    PixelQueueOverflow overflow = new PixelQueueOverflow();
                    for (int i = 0; i < buffer.Length;)
                    {
                        
                        overflow.Add(new byte[] { buffer[i++], buffer[i++], buffer[i++] });
                        if (overflow.Empty) break;
                    }
                    Array.Resize(ref buffer, packet.ByteData.Length);
                    */
                    File.WriteAllBytes(Config.RootDirectory + "\\test.jpg", buffer);
                    File.WriteAllBytes(Config.RootDirectory + "\\test.txt", buffer);
                    userPicture.Image = Image.FromStream(new MemoryStream(buffer));
                }

            }
        }
        class PixelQueueOverflow
        {
            public int counter = 0;
            bool empty = true;
            public bool Empty => empty && queue.Count > 100;
           public Queue<byte[]> queue = new Queue<byte[]>();
            public void Add(byte[] pixel)
            {
                if (pixel.Length != 3) throw new ArgumentException("Needs be 3 bytes per pixel!");
                if (queue.Count >= 100)
                {
                    if (!pixel.IsEmpty()) empty = false;
                    else
                        if (!queue.Dequeue().IsEmpty()) empty = IsEmpty();
                    queue.Enqueue(pixel);
                }
                else
                {
                    empty = empty && pixel.IsEmpty();
                    queue.Enqueue(pixel);

                }
                counter++;
                Console.WriteLine($"Pixel: [{pixel[0]},{pixel[1]},{pixel[2]}]");
            }
            public bool IsEmpty()
            {
                bool check = true;
                foreach (byte[] pixel in queue)
                    check &= pixel.IsEmpty();
                return check;
            }
            public byte[] ToArray()
            {
                byte[] result = new byte[queue.Count*3];
                int i = 0;
                foreach(byte[] pixel in queue)
                {
                    result[i++] = pixel[0];
                    result[i++] = pixel[1];
                    result[i++] = pixel[2];
                }
                return result;
            }
        }


        #region Buttons
        private void changeButton(Button x, Form form, object sender)
        {
            panelStyle.Height = x.Height;
            panelStyle.Top = x.Top;
            x.BackColor = Color.FromArgb(46, 51, 73);
            openChildForm(form, sender);
            x.BackColor = Color.FromArgb(46, 51, 73);
            if (panelDesktop.BackgroundImage != null)
                panelDesktop.BackgroundImage = null;
        }
        private void btnEditingEmployee_Click(object sender, EventArgs e) => changeButton(btnEditingEmployee, new EditingEmployee(), sender);
        private void btnMail_Click(object sender, EventArgs e) => changeButton(btnMail, new Mail(), sender);
        private void btnData_Click(object sender, EventArgs e) => changeButton(btnData, new GeneralData(), sender);
        private void btnAttendence_Click(object sender, EventArgs e) => changeButton(btnAttendence, new AttendanceTable(), sender);
        private void btnEditingEmployee_Leave(object sender, EventArgs e) => btnEditingEmployee.BackColor = Color.FromArgb(24, 30, 54);
        private void btnMail_Leave(object sender, EventArgs e) => btnMail.BackColor = Color.FromArgb(24, 30, 54);
        private void btnData_Leave(object sender, EventArgs e) => btnData.BackColor = Color.FromArgb(24, 30, 54);
        private void btnAttendence_Leave(object sender, EventArgs e) => btnAttendence.BackColor = Color.FromArgb(24, 30, 54);
        private void btnExit_Click_1(object sender, EventArgs e) => Close();
        #endregion

        #region Drag Window
        /// <summary>
        /// Controlls form movement during drag.
        /// </summary>
        void Drag(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panelForUser_MouseDown(object sender, MouseEventArgs e) => Drag(e);
        private void panelDesktop_MouseDown(object sender, MouseEventArgs e) => Drag(e);

        #endregion

        #region Cleanup
        /// <summary>
        /// Cleans temporarry files created by the programm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EMS_ClientMainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            string[] employeeLogs = Directory.GetFiles(Config.RootDirectory);

            //Delete all .xlsx files with numeric names (employee logs)
            foreach (string employeeLog in employeeLogs)
                if (employeeLog.Split("\\").Last().Substring(0, employeeLog.Split("\\").Last().IndexOf('.')).Parsable(typeof(int)))
                    File.Delete(employeeLog);

            try { File.Delete($"{Config.RootDirectory}\\log.json"); } catch { }
            try { File.Delete(Directory.GetCurrentDirectory() + "\\TempClientConfig.txt"); } catch { }

        }
        #endregion


    }
}