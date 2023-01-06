using EMS_Library;
using EMS_Library.MyEmployee.HoursLog;
using System.Diagnostics;

namespace EMS_Client.Forms
{
    public partial class AttendanceTable : Form
    {
        #region Variables
        public static bool fill = false;
        public HoursLogMonth log; //Reference to selected employee log
        private string[][] hoursLogTableStructure; //Log structure adgusted for WinForms DataGridView table
        #endregion

        public AttendanceTable()
        {
            InitializeComponent();
        }

        // בדאבל קליל - נפתח חלון עריכת שעות עבודה
        public void GridViewAttrndance_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (hoursLogTableStructure == null) return;
            //Reconstructing Entry object from celected cell data | בונה מחדש אובייקט כניסה מנתוני התא שנבחרו 
            Point coordinates = GridViewAttrndance.CurrentCellAddress;
            string entryData = EMS_ClientMainScreen.employee.IntId.ToString();
            if (GridViewAttrndance.CurrentCell.OwningColumn.HeaderText == "Entry")
                entryData += $", " +
                    $"{log.Days[coordinates.Y].Date.ToString().Split(' ')[0]} {hoursLogTableStructure[coordinates.Y][coordinates.X]}, " +
                    $"{log.Days[coordinates.Y].Date.ToString().Split(' ')[0]} {hoursLogTableStructure[coordinates.Y][coordinates.X + 1]}";
            else if (GridViewAttrndance.CurrentCell.OwningColumn.HeaderText == "Exit")
                entryData += $", " +
                    $"{log.Days[coordinates.Y].Date.ToString().Split(' ')[0]} {hoursLogTableStructure[coordinates.Y][coordinates.X - 1]}, " +
                    $"{log.Days[coordinates.Y].Date.ToString().Split(' ')[0]} {hoursLogTableStructure[coordinates.Y][coordinates.X]}";

            //Checking if reconstruction failed | בודק אם השחזור נכשל
            if (entryData.Length > Config.InternalIDDigitAmount)
            {
                EditHours editHours = new EditHours(new HoursLogEntry(entryData));
                editHours.ShowDialog();
                btnShowHours.PerformClick();
            }
        }

        #region Buttons
        //Methods called by buttons

        /// <summary>
        /// Opens employee selection screen
        /// פתיחת מסך בחירת עובד
        /// </summary>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            selectEmployee select_Employee = new selectEmployee(this);
            select_Employee.ShowDialog();
            Fill();
        }

        /// <summary>
        /// Fills the table with data
        /// מילוי הטבלה במידע
        /// </summary>
        private void btnShowHours_Click(object sender, EventArgs e)
        {
            GridViewAttrndance.Rows.Clear();
            BuildLog();
            if (log != null)
            {
                hoursLogTableStructure = log.GetHoursLogTableStructure();
                if (hoursLogTableStructure != null)
                    foreach (string[] item in hoursLogTableStructure)
                        GridViewAttrndance.Rows.Add(item);
            }
        }

        /// <summary>
        /// Creates and opens the log in PDF format
        /// PDF יצירה ופתיחה של דוח נוכחות בפורמט 
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            if (EMS_ClientMainScreen.employee == null)
            { MessageBox.Show("Please select a employee"); return; }

            BuildLog();
            if (log != null)
                File.WriteAllText(Config.RootDirectory + "\\log.json", log.JSON());
            GenerateXlsxLog();
        }

        /// <summary>
        /// Opens exceptions screen
        /// פתיחת מסך חריגים
        /// </summary>
        private void btnExceptions_Click(object sender, EventArgs e)
        {
            ExceptionsScreen exception = new ExceptionsScreen();
            exception.Location = new Point(Parent.Parent.Location.X + Parent.Parent.Size.Width, Parent.Parent.Location.Y);
            exception.Show();
        }
        #endregion

        #region Supplemental
        /// <summary>
        /// Fills appropriate fields with chosen employee data.
        /// מילוי שדות נתונים של עובד שנבחר
        /// </summary>
        public void Fill()
        {
            if (EMS_ClientMainScreen.employee != null)
            {
                txtName.Text = EMS_ClientMainScreen.employee.LName.ToString() + " " + EMS_ClientMainScreen.employee.FName.ToString();
                txtID.Text = EMS_ClientMainScreen.employee.IntId.ToString();
            }
        }

        /// <summary>
        /// Builds hour logs for chosen employee
        /// בונה נתוני שעות עבור עובד שנבחר
        /// </summary>
        private void BuildLog()
        {
            DateTime temp = DateTime.Parse("01/" + dateTime.Text);
            string querry = Requests.GetHourLogs(EMS_ClientMainScreen.employee.IntId, temp.Year, temp.Month);
            string[] buffer = Requests.RequestFromServer(querry, 5);
            if (buffer[0] != "-1")
            {
                log = new HoursLogMonth(buffer.ToArray(), EMS_ClientMainScreen.employee);
                lblNoData.Visible = false;
            }
            else
            {
                log = null;
                lblNoData.Visible = true;
            }
        }

        /// <summary>
        /// Generates and opens hours log in Excel format.
        /// יצירת ופתיחת דוח נוכחות באקסל
        /// </summary>
        public void GenerateXlsxLog()
        {
            if (log == null) return;
            Thread xlsxBuilder = new Thread(() =>
            {
                File.WriteAllText(Directory.GetCurrentDirectory() + "\\TempClientConfig.txt", $"HoursLog.xlsx_output_directory={EMS_Library.Config.RootDirectory}");

                Process writingXlsx = new Process();
                writingXlsx.StartInfo.FileName = "main.py";
                writingXlsx.StartInfo.UseShellExecute = true;
                writingXlsx.Start();
                while (!writingXlsx.HasExited) { }

                Process PDFProcess = new Process();
                PDFProcess.StartInfo.FileName = $"{EMS_Library.Config.RootDirectory}\\{EMS_ClientMainScreen.employee.IntId}.pdf";
                PDFProcess.StartInfo.UseShellExecute = true;
                PDFProcess.Start();

                while (!writingXlsx.HasExited) { }

                //Release of resouces | שחרור משאבים
                writingXlsx.Dispose();
                PDFProcess.Dispose();
            });
            xlsxBuilder.Start();
        }
        #endregion

    }
}
