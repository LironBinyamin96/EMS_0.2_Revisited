using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_Library.MyEmployee.HoursLog
{
    /// <summary>
    /// Yearly work-hours log handling.
    /// </summary>
    public class HoursLogYears
    {
        int _intId;
        List<HoursLogMonths> _hoursLog = new List<HoursLogMonths>();
        DirectoryInfo _directoryInfo;

        public HoursLogYears(Employee emp)
        {
            _directoryInfo = Directory.CreateDirectory(emp.GetDirectory.GetLogDirectory.FullName + $"\\{DateTime.Now.Year}");
            _intId = emp.IntId;
            string[] files = Directory.GetFiles(_directoryInfo.FullName);
            foreach (string file in files)
                _hoursLog.Add(new HoursLogMonths(emp, DateTime.Now));
        }

        public void SaveLog() { foreach (HoursLogMonths log in _hoursLog) log.SaveLog(); }
        public void GetMonth(int monthNumber) => _hoursLog.Find(x => x.Month == monthNumber);

        public TimeSpan GetYearlyHoursReport()
        {
            TimeSpan time = new TimeSpan();
            foreach (HoursLogMonths log in _hoursLog)
                time += log.GetMonthlyHoursReport();
            return time;
        }
    }
}
