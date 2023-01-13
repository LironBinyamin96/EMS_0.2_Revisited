using AForge.Video;
using AForge.Video.DirectShow;
using EMS_Library;
using EMS_Library.MyEmployee;
using EMS_Library.Network;

namespace EMS_Client.Forms
{
    public partial class UpdatePersonalDetails : Form
    {
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
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panelUpdatePersonalDetails_MouseDown(object sender, MouseEventArgs e) => Drag(e);
        private void lblUpdatePersonalDetails_MouseDown(object sender, MouseEventArgs e) => Drag(e);

        #endregion

        Control[] activeControls; //Collection of controlls for user interaction.
        Bitmap empPicture;
        public UpdatePersonalDetails()
        {
            
            InitializeComponent();
            activeControls = new Control[] {
                txtID, txtFirstName , txtLastName, txtMiddleName,
                txtGender,txtDateOfBirth,txtAddres,txtPhone,
                txtBaseSalary,txtSalaryModifire,txtEmail,positionBox,pictureBox1
            };
            if (EMS_ClientMainScreen.CurEmployee is EMS_Library.MyEmployee.IAccess.IRootAccess)
                btnDelete.Visible = true;
        }

        #region Buttons
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Format validation | אימות פורמט
            if (CheckingDataFields())
            {
                Employee tempEmp = Employee.ActivateEmployee(new object[] {
                    positionBox.Text,
                    EMS_ClientMainScreen.employee.IntId,
                    txtID.Text,
                    txtFirstName.Text,
                    txtLastName.Text,
                    txtMiddleName.Text,
                    txtEmail.Text,
                    EMS_ClientMainScreen.employee.Password,
                    txtGender.Text,
                    txtDateOfBirth.Text,
                    EMS_ClientMainScreen.employee.Created,
                    EMS_ClientMainScreen.employee.EmploymentStatus,
                    txtBaseSalary.Text,
                    txtSalaryModifire.Text,
                    txtPhone.Text,
                    txtAddres.Text
                    });

                string querry = Requests.UpdateEmployee(tempEmp.ProvideFieldsAndValues(), new Dictionary<string, string> {
                        { "_intId", EMS_ClientMainScreen.employee.IntId.ToString() } });
                bool validation = Requests.RequestFromServer(querry, 3)[0] == "1";
                if (!validation) { MessageBox.Show("Failed to update employee data!"); return; }
                string[] picBuffer = Requests.SaveImmage(pictureBox1.Image as Bitmap, tempEmp.IntId);
                validation &= picBuffer[0].ToLower() == "saved";
                if (!validation) { MessageBox.Show(picBuffer[0]); return; }
                MessageBox.Show("Updaded!");
            }
            else MessageBox.Show("Incorrect format!");
        }

        // employee selection | בחירת עובד
        private void btnSelect_Click(object sender, EventArgs e)
        {
            selectEmployee select_Employee = new selectEmployee(this);
            select_Employee.ShowDialog();
        }

        // Deleting an employee | מחיקת עובד
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (EMS_ClientMainScreen.employee != null)
            { 
                DialogResult delete = MessageBox.Show("Are you sure?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (delete == DialogResult.OK)
                {
                    Requests.RequestFromServer(Requests.DeleteEmployee(EMS_ClientMainScreen.employee.IntId), 4);
                    Clear();
                }
            }
            else MessageBox.Show("Please select a employee");
        }

        // Upload a picture | העלאת תמונה
        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = $"picture |*{Config.ImageFormat}| all files|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.InitialDirectory = "c:\\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                empPicture = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = empPicture;
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            EMS_ClientMainScreen.employee = null;
            EMS_ClientMainScreen.PrimaryForms.Remove(this);
            Close();
        }
        // Undoing the changes | ביטול השינויים
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Fill();
            Panel[] panelArr = new Panel[] { panelID, panelFname, panelLname, panelDate, panelAddres, panelPhone, panelEmail, panelBaseSalary
                ,panelSalaryModifire,panelPosition };
            foreach (Panel panel in panelArr)
                panel.BackColor = Color.FromArgb(0, 126, 249);
        }

        #endregion

        #region Supplimental

        /// <summary>
        /// Clears fields
        /// ניקוי השדות
        /// </summary>
        public void Clear()
        {
            txtID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMiddleName.Text = "";
            txtGender.Text = "";
            txtDateOfBirth.Text = "";
            txtAddres.Text = "";
            txtPhone.Text = "";
            positionBox.Text = "";
            txtBaseSalary.Text = "";
            txtSalaryModifire.Text = "";
            txtEmail.Text = "";
            pictureBox1.Image = null;
        }

        /// <summary>
        /// Fills fields
        /// מילוי השדות
        /// </summary>
        public void Fill()
        {
            if (EMS_ClientMainScreen.employee != null)
            {
                btnUnemploy.Visible = EMS_ClientMainScreen.employee.EmploymentStatus != "0";
                txtID.Text = EMS_ClientMainScreen.employee.StateId.ToString();
                txtFirstName.Text = EMS_ClientMainScreen.employee.FName.ToString();
                txtLastName.Text = EMS_ClientMainScreen.employee.LName.ToString();
                txtMiddleName.Text = EMS_ClientMainScreen.employee.MName.ToString();
                txtEmail.Text = EMS_ClientMainScreen.employee.Email.ToString();
                txtGender.Text = EMS_ClientMainScreen.employee.Gender.ToString();
                txtDateOfBirth.Text = EMS_ClientMainScreen.employee.BirthDate.ToString();
                txtAddres.Text = EMS_ClientMainScreen.employee.Address.ToString();
                txtPhone.Text = EMS_ClientMainScreen.employee.PhoneNumber.ToString();
                positionBox.Text = EMS_ClientMainScreen.employee.Type.Name;
                txtBaseSalary.Text = EMS_ClientMainScreen.employee.BaseSalary.ToString();
                txtSalaryModifire.Text = EMS_ClientMainScreen.employee.SalaryModifire.ToString();
                try
                { pictureBox1.Image = new ImageConverter().ConvertFrom(Requests.GetImage(new DataPacket($"get image #{EMS_ClientMainScreen.employee.IntId}", 6))) as Bitmap; }
                catch { }
            }
        }

        /// <summary>
        /// Prefforms validation of data provided by the user.
        /// אימות הנתונים שהוקלדו על ידי המשתמש
        /// </summary>
        /// <returns></returns>
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
                { btnUpload,pictureBox1.Image != null }
            };

            //Prefoms scan through the collection and changing field colors appropriately while aggregating validity status.
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
        #endregion

        #region Camera
        // Activating the camera to take a picture of the employee
        // הפעלת המצלמה לצילום תמונה של העובד

        VideoCaptureDevice videoCapture;
        FilterInfoCollection filterInfo;
        byte frameCount = 0;


        private void Camera_on(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
            unchecked { frameCount++; }
            if (frameCount % 10 == 0) GC.Collect();
        }
        // פתיחת מצלמה
        private void btnCamera_Click(object sender, EventArgs e)
        {
            if (StartCamera())
            {
                btnCamera.Visible = false;
                btnTakePicture.Visible = true;
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


        //צילום תמונה
        private void btnPictureTakingImage_Click(object sender, EventArgs e)
        {
            videoCapture?.SignalToStop();
            btnCamera.Visible = true;
            btnTakePicture.Visible = false;
            try { empPicture = new Bitmap(pictureBox1.Image).Rescale(Config.FRImmageWidth, Config.FRImmageHeight); }
            catch { MessageBox.Show("Image could not be captured!"); }
        }
        #endregion

        private void UpdatePersonalDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            videoCapture?.SignalToStop();
            btnCamera.Visible = true;
            btnTakePicture.Visible = false;
        }

        private void btnUnemploy_Click(object sender, EventArgs e)
        {
            if (EMS_ClientMainScreen.employee != null)
            {
                if (Requests.DeleteImage(EMS_ClientMainScreen.employee.IntId)[0] == "Picture deleted." &&
                    Requests.RequestFromServer(Requests.UpdateEmployee(new Dictionary<string, string> { { "_employmentStatus", "0" } }, new Dictionary<string, string> { { "_intId", EMS_ClientMainScreen.employee.IntId.ToString() } }), 3)[0] == "1")
                {
                    MessageBox.Show("Employee has bee sent to fuck himself :)");
                }
            }  
            else MessageBox.Show("Please select a employee");
        }

      
    }
}