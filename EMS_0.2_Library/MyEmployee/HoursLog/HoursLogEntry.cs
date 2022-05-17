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
    public class HoursLogEntry
    {
        int _IntId;
        DateTime _start;
        DateTime _end;
        public int IntId { get => _IntId; set => _IntId = value; }
        public DateTime Start { get => _start; set => _start = value; }
        public DateTime End { get => _end; set => _end = value; }
        public TimeSpan Total => _end -_start;
        public HoursLogEntry(string data)
        {
            string[] hold = data.Split(',');
            _IntId = int.Parse(hold[0]);
            _start = DateTime.Parse(hold[1]);
            _end = DateTime.Parse(hold[2]);
        }
        public override string ToString() => $"Start: {_start}, End: {_end}, Total: {Total}";
        public string JSON() => $"{{\"Date\": \"{_start.Date}\", \"Start\": \"{_start.TimeOfDay}\", \"End\": \"{_end.TimeOfDay}\"}}";
    }
}
