using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_Library.MyEmployee.HoursLog
{
    public class HoursLogDay
    {
        HoursLogEntry[] _entries;

        public TimeSpan Total
        {
            get
            {
                TimeSpan sum = TimeSpan.Zero;
                foreach (HoursLogEntry entry in _entries)
                    sum += entry.Total;
                return sum;
            }
        }
        public TimeSpan TotalOvertime => Total - Config.NormalShiftLength > TimeSpan.Zero ? Total - Config.NormalShiftLength : TimeSpan.Zero;
        public HoursLogEntry[] Entries { get => _entries; set => _entries = value; }


        public HoursLogDay(HoursLogEntry[] entries)
        {
            _entries = entries;
        }
        public override string ToString()
        {
            if (_entries==null || _entries.Length==0) return "";
            string hold = "";
            foreach (HoursLogEntry entry in _entries)
                hold+=entry.ToString()+'|';
            return hold.Remove(hold.Length-1);
        }
        public string JSON()
        {
            TimeSpan overtime = Total - Config.NormalShiftLength > TimeSpan.Zero ? (Total - Config.NormalShiftLength) : TimeSpan.Zero;
            string hold = $"{{\"Total\": \"{Total}\"," +
                $" \"Overtime\": \"{overtime}\"," +
                $" \"Entries\": [";
            if (_entries.Length > 0)
            {
                foreach (HoursLogEntry entry in _entries)
                    hold += entry.JSON() + ',';
                Console.WriteLine(hold);
                hold=hold.TrimEnd(',');
                Console.WriteLine(hold);
            }
            
            hold += "]}";
            return hold;
        }

    }
}
