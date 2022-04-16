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
    public class HoursLogMonth
    {
        int _intId;
        int _month;
        HoursLogDay[] _days;
        public HoursLogDay[] GetDays => _days;
        public int IntId => _intId;
        public int Month => _month;
        public HoursLogMonth(string data)
        {
            string[] dataArr = data.Split('|');
            string[] day = dataArr[0].Split(',');
            _intId = int.Parse(day[0]);
            _month = DateTime.Parse(day[1]).Month;
            _days = (Array.ConvertAll(dataArr, x => new HoursLogDay(x)));
        }
        public HoursLogMonth(int _intId, string[] days)
        {
            this._intId= _intId;
            _days = Array.ConvertAll(days, x => new HoursLogDay(x));
            _month = _days[0].Start.Month;
        }
        public HoursLogMonth(int _intId, HoursLogDay[] days)
        {
            this._intId = _intId;
            _days = new HoursLogDay[days.Length];
            Array.Copy(days, _days, days.Length);
            _month = _days[0].Start.Month;
        }
        
    }
}
