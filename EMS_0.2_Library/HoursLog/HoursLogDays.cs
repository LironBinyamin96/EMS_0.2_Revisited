using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_Library.MyEmployee.HoursLog
{
    /// <summary>
    /// Handling of daily entries in the log.
    /// </summary>
    public class HoursLogDays
    {
        int _day;
        List<DateTime[]> _inOuts = new List<DateTime[]>();
        public HoursLogDays(int day) { _day = day; _inOuts.Add(new DateTime[2]); }
        public HoursLogDays(string log)
        {
            try
            {
                if (log.Length > 10)
                {
                    _day = int.Parse(log.Substring(log.IndexOf('#') + 1, log.IndexOf(':') - log.IndexOf('#') - 1));
                    log = log.Replace(log.Substring(0, log.IndexOf(':') + 1), "");
                    string[] hold = log.Split('|');
                    foreach (string a in hold)
                        if (a.Length > 0 && a != "\r")
                            _inOuts.Add(new DateTime[]
                            {
                                DateTime.Parse(a.Substring(0, a.IndexOf(", "))),
                                DateTime.Parse(a.Substring(a.IndexOf(", ") + 1))
                            });
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
                return;
            }
        }
        public void AddEntry(DateTime curTime) => _inOuts.Add(new DateTime[] { curTime, default });
        public void AddExit(DateTime curTime)
        {
            if (_inOuts.Count > 0) _inOuts.Last()[1] = curTime;
            else _inOuts.Add(new DateTime[] { default, curTime });
        }
        public TimeSpan GetDailyHoursReport()
        {
            TimeSpan sum = new TimeSpan();
            foreach (DateTime[] a in _inOuts)
                if (a[0] != default && a[1] != default)
                    sum += a[1] - a[0];
            return sum;
        }
        public override string ToString()
        {
            string output = $"day #{_day}:";
            foreach (DateTime[] item in _inOuts)
                output += $"{item[0]}, {item[1]}|";
            output = output.Remove(output.Length - 1);
            return output;
        }
    }
}
