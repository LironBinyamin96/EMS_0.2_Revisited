using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EMS_Library;

namespace EMS_Server
{
    internal class SQLBridge
    {
        public static bool SQLConnected = false;
        private static object LOCK = new object();
        public static string OneWayCommand(string IncomingCommand)
        {
            lock (LOCK)
            {
                SqlConnection Connection = new SqlConnection(EMS_Library.Config.SQLConnectionString);
                SqlCommand Command = Connection.CreateCommand();
                Command.CommandText = IncomingCommand;
                try
                {
                    if (Connection.State != System.Data.ConnectionState.Open) Connection.Open();
                    int responce = Command.ExecuteNonQuery();
                    Connection.Close();
                    return responce.ToString();
                }
                catch (SqlException ex) { return ex.Message + Environment.NewLine + IncomingCommand; }
            }
        }
        /// <summary>
        /// שאילתה דו כיווני
        /// Sends provided querry to the server.
        /// </summary>
        /// <returns> Responce from the server (string where each object is separated by | ). </returns>
        public static string TwoWayCommand(string IncomingCommand)
        {
            lock (LOCK)
            {
                try
                {
                    SqlConnection Connection = new SqlConnection(Config.SQLConnectionString);
                    SqlCommand Command = Connection.CreateCommand();
                    Command.CommandText = IncomingCommand;
                    if (Connection.State != System.Data.ConnectionState.Open) Connection.Open();
                    SqlDataReader DataReader = Command.ExecuteReader();
                    StringBuilder stringBuilder = new StringBuilder();
                    while (DataReader.Read())
                    {
                        object[] temp = new object[DataReader.FieldCount];
                        DataReader.GetValues(temp);
                        foreach (object s in temp)
                        {
                            if (s is DBNull) stringBuilder.Append("NULL,");
                            else stringBuilder.Append(s.ToString().Trim() + ',');
                        }
                        stringBuilder.Remove(stringBuilder.Length - 1, 1);
                        stringBuilder.Append('|');
                    }
                    Connection.Close();
                    return stringBuilder.Length > 0 ? stringBuilder.ToString().Remove(stringBuilder.Length - 1) : "-1";
                }
                catch (SqlException ex) { return ex.Message + Environment.NewLine + IncomingCommand; }
            }
        }
        public static string GetFreeID()
        {
            Random random = new Random();
            int id = random.Next(100000000, 1000000000);
            while (TwoWayCommand($"select _intId from {Config.EmployeeDataTable} where _intId={id};")[0] == -1)
                id = random.Next(100000000, 1000000000);
            return id.ToString();
        }
        public static string Select(string clientQuerry)
        {
            string[] clause = clientQuerry.Substring(clientQuerry.IndexOf('#') + 1).Split(',');
            string final = "select * from " + Config.EmployeeDataTable;
            if (clause.Length > 0 && clause[0] != "")
            {
                final += " where";
                foreach (string item in clause)
                    final += " " + item;
            }
            return final;
        }
        public static string Add(string clientQuerry) => $"insert into {Config.EmployeeDataTable} values ({clientQuerry.Substring(clientQuerry.IndexOf('#') + 1)});";
        public static string Update(string clientQuerry)
        {
            string final = $"update {Config.EmployeeDataTable} set ";
            final += clientQuerry.Substring(clientQuerry.IndexOf('#') + 1) + ' ';
            final += clientQuerry.Substring(clientQuerry.IndexOf("where"), clientQuerry.IndexOf('#') - clientQuerry.IndexOf("where")) + ';';
            return final;
        }
        public static string DeleteEmployee(string clientQuerry)
        {
            string id = clientQuerry.Substring(clientQuerry.IndexOf('#') + 1);
            return
                $"delete from {Config.EmployeeHourLogsTable} where _intId={id};" +
                $"delete from {Config.EmployeeDataTable} where _intId={id};";
        } //delete #_intId
        public static string GetMonthLog(string clientQuerry) //get log #_intId, year, month
        {
            string[] data = clientQuerry.Substring(clientQuerry.IndexOf('#') + 1).Split(',');
            DateTime time = DateTime.Parse($"{data[1].Trim()}-{data[2].Trim()}-01");
            string debug =
                $"select * from HourLogs" +
                $" where " +
                $"((_entry between '{data[1]}-{data[2]}-01' and '{data[1]}-{data[2]}-{DateTime.DaysInMonth(int.Parse(data[1]), int.Parse(data[2]))}') or" +
                $"(_exit between '{data[1]}-{data[2]}-01' and '{data[1]}-{data[2]}-{DateTime.DaysInMonth(int.Parse(data[1]), int.Parse(data[2]))}'))" +
                $" and _intId = {data[0]}; ";
            return debug;
        }
        public static string Departure(string _intId)
        {
            string lastArrival = TwoWayCommand($"select top (1) _entry from HourLogs where _intId = {_intId} and _entry is not NULL order by _entry DESC");
            DateTime lastArrTime = DateTime.Parse(lastArrival);
            try
            {
                DateTime arrivalDate = DateTime.Parse(lastArrival);
                if (arrivalDate.Day == DateTime.Now.Day)
                    return $"update HourLogs" +
                           $" set _exit='{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}' " +
                           $"where _intId={_intId} and _entry = '{lastArrTime.ToString("yyyy-MM-dd HH:mm:ss")}';";
                else
                    return $"insert into HourLogs (_intId, _exit)" +
                           $" values ({_intId}, '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}');";
            }
            catch (Exception ex) { return ex.Source + Environment.NewLine + ex.Message; }
        }
        public static string Arrival(string _intId) => $"insert into {Config.EmployeeHourLogsTable} (_intId ,_entry) values ({_intId},'{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}');";
        public static void TimestampCheck(KeyValuePair<EMS_Library.MyEmployee.Employee, DateTime> data)
        {

        }
        public static string UpdateEntry(string clientQuerry)
        {
            string[] querryData = clientQuerry.Substring(clientQuerry.IndexOf('#')+1).Split(',');
            int responce = 0;
            if (querryData.Length != 3) 
                return new ArgumentException("Invalid querry format.").Message;
            {
                string res = OneWayCommand($"delete from {Config.EmployeeHourLogsTable} where _intId={querryData[0]} and (_entry='{querryData[1]}' or _exit='{querryData[2]}');");
                if (int.TryParse(res, out int resInt))
                    responce += resInt;
            }
            {
                string res = OneWayCommand($"insert into {Config.EmployeeHourLogsTable} values({querryData[0]},'{querryData[1]}','{querryData[2]}');");
                if (int.TryParse(res, out int resInt))
                    responce += resInt;
            }
            return responce.ToString();
        }
        public static string GetAllExceptions(string clientQuerry) => $"select * from {Config.EmployeeHourLogsTable} where _entry<'{Config.MinDate}' or _exit<'{Config.MinDate}' or _exit<_entry";
    }
}
