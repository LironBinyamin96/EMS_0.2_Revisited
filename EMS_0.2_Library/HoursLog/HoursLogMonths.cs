using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_Library.MyEmployee.HoursLog
{
    /// <summary>
    /// Monthly work-hours log handling.
    /// </summary>
    public class HoursLogMonths
    {
        int _intId;
        int _month;
        HoursLogDays[] _hoursLog = new HoursLogDays[31];
        FileInfo _log;

        public HoursLogDays[] GetHoursLog { get => _hoursLog; }
        public int GetIntId { get => _intId; }
        public int Month { get => _month; set => _month = value; }

        public HoursLogMonths(Employee emp) => Creator(emp, DateTime.Now);
        public HoursLogMonths(Employee emp, DateTime date) => Creator(emp, date);

        private void Creator(Employee emp, DateTime date)
        {
            _intId = emp.IntId;
            _month = date.Month;
            DirectoryInfo dir = emp.GetDirectory.GetLogDirectory;
            Directory.CreateDirectory($"{ dir.FullName}\\{ date.Year}");
            string temp = ($"{dir.FullName}\\{date.Year}\\{date.Month}.txt");

            if (!File.Exists(temp)) File.Create(temp).Close();
            _log = new FileInfo(temp);

            StreamReader file = new StreamReader(_log.FullName);
            string[] lines = file.ReadToEnd().Split('\n');
            for (byte i = 0; i < _hoursLog.Length && i < lines.Length; i++)
                _hoursLog[i] = new HoursLogDays(lines[i]);
            file.Close();

        }
        public void SaveLog() => File.WriteAllLines(_log.FullName, Array.ConvertAll(_hoursLog, x => x != null ? x.ToString() : null));
        public void UpdateLog(bool arrived, DateTime curTime)
        {
            HoursLogDays log = _hoursLog[curTime.Day] != null ? _hoursLog[curTime.Day] : new HoursLogDays(curTime.Day);
            if (arrived) log.AddEntry(curTime);
            else log.AddExit(curTime);
            _hoursLog[curTime.Day] = log;
            SaveLog();
        }
        public TimeSpan GetMonthlyHoursReport()
        {
            TimeSpan hold = new TimeSpan();
            foreach (HoursLogDays log in _hoursLog)
                hold += log.GetDailyHoursReport();
            return hold;
        }
        public override string ToString()
        {
            string report = "";
            foreach (var a in _hoursLog)
                if (a != null)
                    report += a.ToString() + '\n';
            return report;
        }

    }
}
