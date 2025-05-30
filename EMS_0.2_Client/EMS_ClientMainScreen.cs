﻿using EMS_Client.Forms;
using EMS_Library;
using EMS_Library.MyEmployee;
using System.Runtime.InteropServices;

namespace EMS_Client
{
    public partial class EMS_ClientMainScreen : Form
    {
        #region Global Variables
        public static Stack<Form> PrimaryForms = new Stack<Form>(); //Stack for storing all primary forms.
        public static Employee CurEmployee; //User data.
        public static Employee employee; //Temporary storage for employee data.
        #endregion

        #region Local Variables
        private Form activeForm; // משתנה עזר ששומר את החלון הנוכחי
        #endregion

        public EMS_ClientMainScreen()
        {
            InitializeComponent();
            PrimaryForms.Push(this);
            //Marking the buttons | סימון הכפתורים
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        /// <summary>
        /// Method called on form loading
        ///טעינת מסך ראשי
        /// </summary>
        private void EMS_ClientMainScreen_Load(object sender, EventArgs e)
        {
            //Create working directory if it doesn't exist
            // יצירת ספריית עבודה אם היא לא קיימת
            if (!Directory.Exists(Config.RootDirectory))
                Directory.CreateDirectory(Config.RootDirectory);
            Action serverLookup = () => //Lambda method to look for the server. | חיפוש השרת
            {
                EMS_Library.Network.ServerAddressResolver.ServerIP(false);
                (Array.Find(PrimaryForms.ToArray(), x => x is EMS_ClientMainScreen) as EMS_ClientMainScreen).Invoke(() => PrimaryForms.Pop().Close());
                if (EMS_Library.Network.ServerAddressResolver.LookedUp && !Config.DevelopmentMode) //Message reminding to update ServerIp configurations
                    MessageBox.Show($"Had to serach for the server!\nServer ip is {Config.ServerIP}\nPlease update client config files to reduce boot time");
            };
            StandbyScreen standby = new StandbyScreen(serverLookup);
            standby.ShowDialog();


            Login login = new Login();
            PrimaryForms.Push(login);
            login.ShowDialog();

            if (PrimaryForms.Count == 0) return; //App was closed at login screen | סגירת התוכנה במסך הכניסה

            lblCurrentOnShift.Text = "Current employees on site: " + Requests.RequestFromServer($"select count(_intId) from {Config.EmployeeDataTable} where _employmentStatus='1';", 254)[0];

            EMS_Library.Network.DataPacket packet = new EMS_Library.Network.DataPacket($"get image #{CurEmployee.IntId}", 6);
            byte[] buffer = Requests.GetImage(packet);
            if (!buffer.IsEmpty(10))
                UserPictureBox.Image = new ImageConverter().ConvertFrom(buffer) as Bitmap;
        }


        #region Subscreens
        //This region contains methods needed for the subscreens rendering

        //Marking the buttons | סימון הכפתורים
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public void openChildForm(Form child)
        {
            GC.Collect();
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
        private void changeButton(Button x, Form form)
        {
            panelStyle.Height = x.Height;
            panelStyle.Top = x.Top;
            x.BackColor = Color.FromArgb(46, 51, 73);
            openChildForm(form);
            x.BackColor = Color.FromArgb(46, 51, 73);
            if (panelDesktop.BackgroundImage != null)
                panelDesktop.BackgroundImage = null;
        }


        private void btnEditingEmployee_Click(object sender, EventArgs e) => changeButton(btnEditingEmployee, new EditingEmployee());
        private void btnMail_Click(object sender, EventArgs e) => changeButton(btnMail, new Mail());
        private void btnData_Click(object sender, EventArgs e) => changeButton(btnData, new GeneralData());
        private void btnAttendence_Click(object sender, EventArgs e) => changeButton(btnAttendence, new AttendanceTable());
        private void btnMail_Leave(object sender, EventArgs e) => btnMail.BackColor = Color.FromArgb(24, 30, 54);
        private void btnData_Leave(object sender, EventArgs e) => btnData.BackColor = Color.FromArgb(24, 30, 54);
        private void btnEditingEmployee_Leave(object sender, EventArgs e) => btnEditingEmployee.BackColor = Color.FromArgb(24, 30, 54);
        private void btnAttendence_Leave(object sender, EventArgs e) => btnAttendence.BackColor = Color.FromArgb(24, 30, 54);

        #endregion

        #region Buttons
        //Methods called by buttonPress events
        private void btnExit_Click_1(object sender, EventArgs e) => Close();
        #endregion

        #region Drag Window
        /// <summary>
        /// Code from the Internet-  Controlls form movement during drag.
        /// הזזת חלונות במהלך גרירה
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
        /// מנקה קבצים זמניים שנוצרו על ידי התוכנית
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EMS_ClientMainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            string[] employeeLogs = Directory.GetFiles(Config.RootDirectory);

            //Delete all .xlsx files with numeric names (employee logs)
            // עם שמות מספריים xlsx מחק את כל קבצי
            foreach (string employeeLog in employeeLogs)
                if (employeeLog.Split("\\").Last().Substring(0, employeeLog.Split("\\").Last().IndexOf('.')).Parsable(typeof(int)))
                    File.Delete(employeeLog);

            try { File.Delete($"{Config.RootDirectory}\\log.json"); } catch { }
            try { File.Delete(Directory.GetCurrentDirectory() + "\\TempClientConfig.txt"); } catch { }
            try { File.Delete($"{Config.RootDirectory}\\Config.txt"); } catch { }

        }
        #endregion

        private void btnView_Click(object sender, EventArgs e)
        {
            EmpsByStatus empsByStatus = new EmpsByStatus();
            empsByStatus.Location = new Point(Location.X + Size.Width, Location.Y);
            empsByStatus.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            activeForm?.Close();
            panelDesktop.BackgroundImage = Properties.Resources.HR1;
        }


    }
}