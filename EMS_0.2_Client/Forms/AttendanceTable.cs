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
            string querry = Requests.GetHourLogs(EMS_ClientMainScreen.CurEmployee.IntId, DateTime.Now.Year, DateTime.Now.Month);
            List<string> buffer = new List<string>();
            Action action = Requests.BuildAction(this, new EMS_Library.Network.DataPacket(querry, 5), buffer, true);
            new StandbyScreen(action).ShowDialog();
            HoursLogDay[] hoursLogDays = Array.ConvertAll(buffer.ToArray(), x => new HoursLogDay(x));
            log = new HoursLogMonth(EMS_ClientMainScreen.CurEmployee.IntId, hoursLogDays);
            Console.WriteLine();
            foreach (var a in log.GetDays)
                Console.WriteLine(a);
            GridViewAttrndance.DataSource = log;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            selectEmployee select_Employee = new selectEmployee(this);
            select_Employee.ShowDialog();
            Fill();

        }

        private void AttendanceTable_Activated(object sender, EventArgs e)
        {
            //MessageBox.Show("Activated");
            //Fill();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
                string logJson = log.JSON();
            System.IO.File.WriteAllText(EMS_Library.Config.RootDirectory+"\\log.json", logJson);
            
            Fill();
        }
    }
}
