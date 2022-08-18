using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using EMS_Library.MyEmployee.HoursLog;
using EMS_Library;

namespace EMS_Client.Forms
{
    public partial class GeneralData : Form
    {
        private ProgressBar[] progressBars;
        private HoursLogMonth[] data;
        private bool employeeChanged=false;
        private bool firtsOpen = true;

        /// <summary>
        /// Constructor for GeneralData screen.
        /// </summary>
        public GeneralData()
        {
            InitializeComponent();
            progressBars = new ProgressBar[] {monthBar0, monthBar1 , monthBar2 , monthBar3 , monthBar4 , monthBar5 , monthBar6 , monthBar7 , monthBar8 , monthBar9, monthBar10, monthBar11 };
            List<int> years = new List<int>();
            for (int i = Config.MinDate.Year; i <= DateTime.Now.Year; i++)
                years.Add(i);
            yearPicker.DataSource = years;
            yearPicker.SelectedIndex = years.Count-1;
            firtsOpen = false;
        }

        /// <summary>
        /// Button for selecting employee.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            selectEmployee select_Employee = new selectEmployee(this);
            select_Employee.Show();
            employeeChanged = true;
        }

        /// <summary>
        /// Triggered when selecting a year.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void yearPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!firtsOpen) Fill();
        }

        /// <summary>
        /// Fills the screen with apropriate data.
        /// </summary>
        public void Fill()
        {
            // Retrieves selected employee data from the server
            if (EMS_ClientMainScreen.employee == null) { MessageBox.Show("No employee selected!"); return; }
            data = new HoursLogMonth[12];
            for (int i = 1; i <= 12; i++)
            {
                string[] responce = Requests.RequestFromServer(Requests.GetHourLogs(EMS_ClientMainScreen.employee.IntId, (int)yearPicker.SelectedValue, i), 5);
                if (responce[0] != "-1") data[i] = new HoursLogMonth(responce, EMS_ClientMainScreen.employee);
            }

            //Fill controls
            if (data == null) { MessageBox.Show("No data available!"); return; }
            for (int i = 0; i < progressBars.Length; i++)
            {
                if (data[i] != null)
                    // = total hours worked / (Max work hours in month / 100%)
                    progressBars[i].Value = (int)(data[i].Total.TotalHours / (Config.MaxShiftLength.TotalHours * Config.WorkDaysInWeek * (DateTime.DaysInMonth(data[i].Year, data[i].Month) / 7) / 100));
                else progressBars[i].Value = 0;
            }

            string empData = $"{EMS_ClientMainScreen.employee.LName} " +
                $"{EMS_ClientMainScreen.employee.FName}:\n" +
                $"Total: {(float)data.Sum(x => x?.Average.Hours):F2}\n" +
                $"Daily average: {(float)data.Sum(x => x?.Average.Hours) / 12:F2} hours";
            lblEmpData.Text = empData;
            if (employeeChanged) //Only request picture if employee changed to reduce traffic
            {
                pictureBox1.Image = (Bitmap)new ImageConverter().ConvertFrom(Requests.GetImage(new EMS_Library.Network.DataPacket(EMS_ClientMainScreen.employee.IntId.ToString(), 6)));
                employeeChanged = false;
            }
        }
    }
}
