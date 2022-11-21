namespace EMS_Library.MyEmployee.HoursLog
{
    /// <summary>
    /// Handling of daily entries in the log.
    /// בניית פורמט כניסה ויציאה של עובד
    /// </summary>
    public class HoursLogEntry
    {
        int _IntId;
        DateTime _start;
        DateTime _end;
        public int IntId { get => _IntId; set => _IntId = value; }
        public DateTime Start { get => _start; set => _start = value; }
        public DateTime End { get => _end; set => _end = value; }
        public TimeSpan Total => (_end - _start) > TimeSpan.Zero ? (_end - _start) : TimeSpan.Zero;

        public HoursLogEntry(string data)
        {
            string[] hold = data.Split(',');
            { if (int.TryParse(hold[0], out int x)) _IntId = x; }
            { if (DateTime.TryParse(hold[1], out DateTime x)) _start = x; }
            { if (DateTime.TryParse(hold[2], out DateTime x)) _end = x; }
        }
        public override string ToString() => $"Start: {_start}, End: {_end}, Total: {Total}";
        public string JSON() => $"{{\"Date\": \"{_start.Date}\", \"Start\": \"{_start.TimeOfDay}\", \"End\": \"{_end.TimeOfDay}\"}}";
    }
}
