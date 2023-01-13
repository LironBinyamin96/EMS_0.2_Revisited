using AForge.Video;
using AForge.Video.DirectShow;
using EMS_Library;
using EMS_Library.MyEmployee;

namespace EMS_Client.Forms
{
    public partial class addEmployee : Form
    {
        #region Variables
        Bitmap employeeImage;
        Control[] activeControls; //Collection holding references for the interactable controlls (excluding buttons)
        #endregion
        public addEmployee()
        {
            InitializeComponent();
            activeControls = new Control[]
            {
                txtID, txtFirstName , txtLastName, txtMiddleName,
                txtGender,txtDateOfBirth,txtAddres,txtPhone,
                txtBaseSalary,txtSalaryModifire,txtEmail,positionBox,pictureBox1
            };
        }

        #region Buttons
        //Methods called by Click events.



        //Returning the panels to blue color and cleaning the text
        // החזרת הפאנלים לצבע כחול וניקוי הטקסט
        private void ClearValues()
        {
            Panel[] panelArr = new Panel[] { panelID, panelFname, panelLname, panelDate, panelAddres, panelPhone, panelEmail, panelBaseSalary
                ,panelSalaryModifire,panelPosition,panelPicture};
            foreach (Panel panel in panelArr)
                panel.BackColor = Color.FromArgb(0, 126, 249);

            foreach (Control control in activeControls)
            {
                if (control is TextBox) ((TextBox)control).Text = "";
                else if (control is ComboBox) ((ComboBox)control).Text = "";
                else if (control is PictureBox) ((PictureBox)control).Image = null;
            }
        }
        //Upload a picture | העלאת תמונה
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            pictureBoxCamera.Visible = false;
            OpenFileDialog openGalery = new OpenFileDialog();
            if (openGalery.ShowDialog() == DialogResult.OK)
                try
                {
                    string file = openGalery.FileName;
                    employeeImage = new Bitmap(file);
                    pictureBox1.Image = employeeImage;
                }
                catch { MessageBox.Show("Failed"); }
        }
        private void btnX_Click(object sender, EventArgs e) { EMS_ClientMainScreen.PrimaryForms.Remove(this); Close(); Dispose(); }
        #endregion

        #region Camera
        // Activating the camera to take a picture of the employee
        // הפעלת המצלמה לצילום תמונה של העובד

        VideoCaptureDevice videoCapture;
        FilterInfoCollection filterInfo;
        byte frameCount = 0;

        private void Camera_on(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBoxCamera.Image = (Bitmap)eventArgs.Frame.Clone();
            unchecked { frameCount++; }
            if (frameCount % 10 == 0) GC.Collect();
        }
        private void btnCameraImage_Click(object sender, EventArgs e)
        {
            if (StartCamera())
            {
                btnCameraImage.Visible = false;
                pictureBoxCamera.Visible = true;
                btnPictureTakingImage.Visible = true;
            }


            bool StartCamera()
            {
                bool success = true;
                filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                success &= filterInfo.Capacity > 0;
                if (success) videoCapture = new VideoCaptureDevice(filterInfo[0].MonikerString);
                success &= videoCapture != null;
                if (success)
                {
                    videoCapture.NewFrame += new NewFrameEventHandler(Camera_on);
                    videoCapture.Start();
                    return true;
                }
                else { MessageBox.Show("Coudn't find a camera!\n"); return false; }
            }
        }
        private void btnPictureTakingImage_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBoxCamera.Image;
            videoCapture?.SignalToStop();
            btnCameraImage.Visible = true;
            pictureBoxCamera.Visible = false;
            btnPictureTakingImage.Visible = false;
            try
            {
                employeeImage = new Bitmap(pictureBox1.Image);
                pictureBox1.Image = employeeImage;
            }
            catch { MessageBox.Show("Image could not be captured!"); }
        }
        #endregion

        /// <summary>
        /// Prefforms validation of data provided by the user.
        /// אימות הנתונים שהוקלדו על ידי המשתמש
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Format validation | אימות פורמט
            if (CheckingDataFields())
            {
                //Addition of a new employee to DB. | הוספת עובד חדש לבסיס נתונים
                string[] buffer = Requests.RequestFromServer("", 252);
                string password = Utility.RandomString(9);

                object[] empParts = new object[] {
                    positionBox.Text,
                    buffer[0],
                    txtID.Text,
                    txtFirstName.Text,
                    txtLastName.Text,
                    txtMiddleName.Text,
                    txtEmail.Text,
                    password,
                    txtGender.Text,
                    txtDateOfBirth.Text,
                    DateTime.Now,        //created at | תאריך יצירת עובד
                    "1",                 //status | סטטוס עובד
                    txtBaseSalary.Text,
                    txtSalaryModifire.Text,
                    txtPhone.Text,
                    txtAddres.Text
                };


                Employee emp = Employee.ActivateEmployee(empParts);
                bool validation = emp != null;
                if (!validation) { MessageBox.Show("Failed to create employee!"); return; }

                //Send image to the server | שליחת התמונה לשרת
                string[] picBuffer = Requests.SaveImmage(employeeImage, emp.IntId);
                validation &= picBuffer[0].ToLower() == "saved";

                if (validation)
                {
                    Requests.RequestFromServer(Requests.AddEmployee(emp), 2);
                    MessageBox.Show($"Employee {emp.FName} {emp.LName} created!\nHis internal id: [{emp.IntId}]\nAutogenerated password is: [{emp.Password}]");
                    ClearValues();
                }
                else MessageBox.Show(picBuffer[0]);

            }
            else MessageBox.Show("Incorrect format!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearValues();
        }
        private bool CheckingDataFields()
        {
            //Aggrigation of the controlls and their vilidity status into singular collection.
            // בדיקת תקינות הנתונים באמצעות מיליון פאנלים ובדיקות
            Dictionary<Control, bool> test = new Dictionary<Control, bool>() {
                { panelID, txtID.Text.IsStateID()},
                { panelFname, txtFirstName.Text.Length > 1 },
                { panelLname, txtLastName.Text.Length > 1 },
                { panelDate, txtDateOfBirth.Text.Parsable(typeof(DateTime)) && (DateTime.Now - DateTime.Parse(txtDateOfBirth.Text)).TotalDays / 365 >= 18 },
                { panelAddres, txtAddres.Text.Length > 1 },
                { panelPhone, txtPhone.Text.Parsable(typeof(int)) },
                { panelEmail, txtEmail.Text.Parsable(typeof(System.Net.Mail.MailAddress)) && (txtEmail.Text.Contains(".")) },
                { panelBaseSalary, txtBaseSalary.Text.Parsable(typeof(int))&& int.Parse(txtBaseSalary.Text)>0 },
                { panelSalaryModifire, txtSalaryModifire.Text.Parsable(typeof(double))&& double.Parse(txtSalaryModifire.Text)>0},
                { panelPosition, positionBox.Text != "" },
                { panelPicture,pictureBox1.Image != null }
            };

            //Prefoms serach for fields with invalid data and coloring them appropriately while aggregating validity status
            // חיפוש שדות עם נתונים לא חוקיים ושינוי צבע הפאנל שלהם לאדום
            bool check = true;
            foreach (KeyValuePair<Control, bool> item in test)
            {
                if (item.Key is Button)
                {
                    if (!item.Value) { item.Key.ForeColor = Color.Red; check = false; }
                    else { item.Key.ForeColor = Color.DodgerBlue; check &= true; }
                }
                else
                {
                    if (!item.Value) { item.Key.BackColor = Color.Red; check = false; }
                    else { item.Key.BackColor = Color.DodgerBlue; check &= true; }
                }
            }
            return check;
        }

        /// <summary>
        /// Finalization of running processes upon form closure.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            videoCapture?.SignalToStop();
            btnCameraImage.Visible = true;
            pictureBoxCamera.Visible = false;
            btnPictureTakingImage.Visible = false;
        }

        #region Drag Window
        /// <summary>
        /// Controlls form's movement during drag.
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
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panelAddEmployee_MouseDown(object sender, MouseEventArgs e) => Drag(e);
        private void lblAddEmployee_MouseDown(object sender, MouseEventArgs e) => Drag(e);










        #endregion

    
    }
}