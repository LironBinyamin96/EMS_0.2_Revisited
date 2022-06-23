using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EMS_Library.MyEmployee.HoursLog;

namespace EMS_Client.Forms
{
    public partial class AttendanceTable : Form
    {
        #region Variables
        public static bool fill = false;
        public HoursLogMonth log;
        #endregion
        public AttendanceTable()
        {
            InitializeComponent();
        }

        public void Fill()
        {
            txtName.Text = EMS_ClientMainScreen.employee.LName.ToString() +" "+ EMS_ClientMainScreen.employee.FName.ToString();
            txtID.Text = EMS_ClientMainScreen.employee.IntId.ToString();

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            selectEmployee select_Employee = new selectEmployee(this);
            select_Employee.ShowDialog();
            Fill();

        }

        private void AttendanceTable_Activated(object sender, EventArgs e)
        {
            MessageBox.Show("Activated");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            BuildLog();
            if(log != null)
            {
                string logJson = log.JSON();
                File.WriteAllText(EMS_Library.Config.RootDirectory + "\\log.json", logJson);
            }
            
        }

        private void BuildLog()
        {
            if (EMS_ClientMainScreen.employee == null) 
            { 
                MessageBox.Show("Please select a employee");
                return; 
            }
            List<string> buffer = new List<string>();
            DateTime temp = DateTime.Parse( "01/"+dateTime.Text);
            MessageBox.Show(temp.ToString());
            string querry = Requests.GetHourLogs(EMS_ClientMainScreen.employee.IntId, temp.Year, temp.Month);
            Action action = Requests.BuildAction(this, new EMS_Library.Network.DataPacket(querry, 5), buffer, false);

            action.Invoke();
            if(buffer[0]!="-1")
                log = new HoursLogMonth(buffer[0], EMS_ClientMainScreen.employee);
        }
        private void btnShowHours_Click(object sender, EventArgs e)
        {
            BuildLog();
            string[][] tmpGetAttendanceTable = log.getAttendanceTable;
            foreach(string[] item in tmpGetAttendanceTable)
            {
                GridViewAttrndance.Rows.Add(item[0], item[1], item[2], item[3], item[4]);
            }
        }
    }
}
