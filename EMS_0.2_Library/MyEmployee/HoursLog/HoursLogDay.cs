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
    public class HoursLogDay
    {
        DateTime _start;
        DateTime _end;
        TimeSpan _totalHours;
        public HoursLogDay(DateTime entry, DateTime exit)
        {
            _start = entry;
            _end = exit;
            _totalHours = exit - entry;
        }
        public HoursLogDay(string data)
        {
            try
            {
                string[] times = data.Split();
                _start = DateTime.Parse(times[1]);
                _end = DateTime.Parse(times[2]);
                _totalHours = _end - _start;
            }
            catch { return; }
        }
        public DateTime Start { get => _start; set => _start = value; }
        public DateTime End { get => _end; set => _end = value; }
        public TimeSpan TotalHours { get => _totalHours; set => _totalHours = value; }
        public override string ToString() => $"Start: {_start}, End: {_end}, Total: {_totalHours}.";
        public string JSON() => '{' + $"\"Start\": \"{_start}\", \"End\": \"{_end}\", \"Total\": \"{_totalHours}\"" + '}'; 
    }
}
