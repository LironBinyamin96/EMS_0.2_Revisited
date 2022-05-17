using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace EMS_Library.MyEmployee.HoursLog
{
    /// <summary>
    /// Monthly work-hours log handling.
    /// </summary>
    public class HoursLogMonth
    {
        Employee _employee;
        int _month;
        int _year;
        HoursLogDay[] _days;

        public HoursLogDay[] Days { get => _days; set => _days = value; }
        public int Month { get => _month; set => _month = value; }
        public TimeSpan Total
        {
            get
            {
                TimeSpan sum = TimeSpan.Zero;
                foreach (HoursLogDay day in Days)
                    if(day!=null)
                        sum+=day.Total;
                return sum;
            }
        }
        public TimeSpan TotalOvertime 
        { 
            get 
            {
                TimeSpan sum = TimeSpan.Zero;
                foreach (HoursLogDay day in Days)
                    if (day != null)
                        sum += day.TotalOvertime;
                return sum;
            } 
        }
        
        public HoursLogMonth(string data, Employee employee)
        {
            _employee = employee;
            HoursLogEntry[] entries = Array.ConvertAll(data.Split('|'), x => new HoursLogEntry(x));
            DateTime tempDate = entries[0].Start;
            _month = tempDate.Month;
            _year = tempDate.Year;
            int daysInMonth = DateTime.DaysInMonth(_year, _month);
            _days = new HoursLogDay[daysInMonth];

            for (int i = 0; i < daysInMonth; i++)
                _days[i] = new HoursLogDay(Array.FindAll(entries, x => x.Start.Day==i));
        }

        public string JSON()
        {
            string hold = $"{{" +
                $"\"InternalID\": \"{_employee.IntId}\"," +
                $"\"StateID\": \"{_employee.StateId}\"," +
                $"\"Full Name\":\"{_employee.FName} {_employee.LName}\"," +
                $"\"Year\":\"{_year}\"," +
                $"\"Month\":\"{_month}\"," +
                $"\"MonthlyHours\":\"{Total}\"," +
                $"\"TotalOvertime\":\"{Config.NormalShiftLength}\"," +
                $"\"Days\":[";
            foreach (HoursLogDay day in _days) 
                hold+=(day!=null?day.JSON():"{}")+',';
            hold=hold.Remove(hold.Length - 1);
            hold += "]}";
            return hold;
        }
    }
}
