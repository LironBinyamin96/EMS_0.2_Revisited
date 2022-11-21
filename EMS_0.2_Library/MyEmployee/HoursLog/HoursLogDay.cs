namespace EMS_Library.MyEmployee.HoursLog
{
    /// <summary>
    /// Class describing day part of hours logs.
    /// בניית פורמט נוכחות יומי של עובד
    /// </summary>
    public class HoursLogDay
    {
        HoursLogEntry[] _entries;
        DateTime _date;

        /// <summary>
        /// Gets total hours worked in that day.
        /// קבלת סכום שעות יומי מצטבר של העובד
        /// </summary>
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

        /// <summary>
        /// Gets total overtime hours worked in that day.
        ///  קבלת סכום שעות נוספות יומי מצטבר של העובד
        /// </summary>
        public TimeSpan TotalOvertime => Total - Config.NormalShiftLength > TimeSpan.Zero ? Total - Config.NormalShiftLength : TimeSpan.Zero;

        /// <summary>
        /// Get array of entryes from that day.
        /// קבלת מערך כניסות ויציאות של יום אחד
        /// </summary>
        public HoursLogEntry[] Entries { get => _entries; set => _entries = value; }
        public DateTime Date => _date;

        public HoursLogDay(HoursLogEntry[] entries, DateTime date)
        {
            _entries = entries;
            _date = date;
        }

        /// <summary>
        /// Adds an entry to daily log.
        /// הוספת זמן כניסה ליום
        /// </summary>
        /// <param name="entry"></param>
        public void Add(HoursLogEntry entry)
        {
            HoursLogEntry[] temp = new HoursLogEntry[_entries.Length + 1];
            Array.Copy(_entries, temp, _entries.Length);
            temp[temp.Length - 1] = entry;
            _entries = temp;
        }
        public override string ToString()
        {
            if (_entries == null || _entries.Length == 0) return "";
            string hold = "";
            foreach (HoursLogEntry entry in _entries)
                hold += entry.ToString() + '|';
            return hold.Remove(hold.Length - 1);
        }

        /// <summary>
        /// Get JSON representation of the log.
        ///של יום  JSON בניית פורמט 
        /// </summary>
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
                hold = hold.TrimEnd(',');
                Console.WriteLine(hold);
            }

            hold += "]}";
            return hold;
        }
    }
}
