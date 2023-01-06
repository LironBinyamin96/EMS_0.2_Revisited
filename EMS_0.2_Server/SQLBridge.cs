using EMS_Library;
using System.Data.SqlClient;
using System.Text;

namespace EMS_Server
{
    internal class SQLBridge
    {
        public static bool SQLConnected = false;
        private static object LOCK = new object();

        /// <summary>
        /// Method used to pass one way command to the SQL DB.
        /// פונקציה המשמשת להעברת פקודה חד כיוונית לבסיס נתונים
        /// </summary>
        /// <param name="IncomingCommand"></param>
        /// <returns></returns>
        public static string OneWayCommand(string querry)
        {
            lock (LOCK)
            {
                SqlConnection Connection = new SqlConnection(EMS_Library.Config.SQLConnectionString);
                SqlCommand Command = Connection.CreateCommand();
                Command.CommandText = querry;
                try
                {
                    if (Connection.State != System.Data.ConnectionState.Open) Connection.Open();
                    int responce = Command.ExecuteNonQuery();
                    Connection.Close();
                    return responce.ToString();
                }
                catch (SqlException ex) { return ex.Message + Environment.NewLine + querry; }
            }
        }

        /// <summary>
        /// Sends provided querry to the server.
        ///  פונקציה המשמשת להעברת פקודה דו כיוונית לבסיס נתונים
        /// </summary>
        /// <returns> Responce from the server (string where each object is separated by | ). </returns>
        public static string TwoWayCommand(string querry)
        {
            lock (LOCK)
            {
                try
                {
                    SqlConnection Connection = new SqlConnection(Config.SQLConnectionString);
                    SqlCommand Command = Connection.CreateCommand();
                    Command.CommandText = querry;
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
                catch (SqlException ex) { return ex.Message + Environment.NewLine + querry; }
            }
        }

        /// <summary>
        /// Generates randomized free id for a new employee.
        /// יצירת מספר זהות אקראי וייחודי לעובד חדש
        /// </summary>
        /// <returns></returns>
        public static string GetFreeID()
        {
            Random random = new Random();
            int id = random.Next(100000000, 1000000000);
            while (TwoWayCommand($"select _intId from {Config.EmployeeDataTable} where _intId={id};")[0] == -1)
                id = random.Next(100000000, 1000000000);
            return id.ToString();
        }

        /// <summary>
        /// Generates a "select" querry from provided data.
        /// יוצר שאילתת "בחירה" מהנתונים שסופקו
        /// </summary>
        /// <param name="clientQuerry"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Generates a "add" querry from provided data.
        ///  יוצר שאילתת "הוספה" מהנתונים שסופקו
        /// </summary>
        /// <param name="clientQuerry"></param>
        /// <returns></returns>
        public static string Add(string clientQuerry) => $"insert into {Config.EmployeeDataTable} values ({clientQuerry.Substring(clientQuerry.IndexOf('#') + 1)});";

        /// <summary>
        /// Generates a "update" querry from provided data.
        ///  יוצר שאילתת "עדכון" מהנתונים שסופקו
        /// </summary>
        /// <param name="clientQuerry"></param>
        /// <returns></returns>
        public static string Update(string clientQuerry)
        {
            string final = $"update {Config.EmployeeDataTable} set ";
            final += clientQuerry.Substring(clientQuerry.IndexOf('#') + 1) + ' ';
            final += clientQuerry.Substring(clientQuerry.IndexOf("where"), clientQuerry.IndexOf('#') - clientQuerry.IndexOf("where")) + ';';
            return final;
        }

        /// <summary>
        /// Generates a "delete" querry from provided data.
        ///  יוצר שאילתת "מחיקה" מהנתונים שסופקו
        /// </summary>
        /// <param name="clientQuerry"></param>
        /// <returns></returns>
        public static string DeleteEmployee(string clientQuerry)
        {
            string id = clientQuerry.Substring(clientQuerry.IndexOf('#') + 1);
            return
                $"delete from {Config.EmployeeHourLogsTable} where _intId={id};" +
                $"delete from {Config.EmployeeDataTable} where _intId={id};";
        } //delete #_intId

        /// <summary>
        /// Generates a querry for retrieving hour logs.
        /// יוצר שאילתה ליצירת יומן שעות נוכחות
        /// </summary>
        /// <param name="clientQuerry"></param>
        /// <returns></returns>
        public static string GetMonthLog(string clientQuerry) //get log #_intId, year, month
        {
            string[] data = clientQuerry.Substring(clientQuerry.IndexOf('#') + 1).Split(',');
            return $"select * from {Config.EmployeeHourLogsTable}" +
                   $" where " +
                   $"((_entry between '{data[1]}-{data[2]}-01' and '{data[1]}-{data[2]}-{DateTime.DaysInMonth(int.Parse(data[1]), int.Parse(data[2]))}') or" +
                   $"(_exit between '{data[1]}-{data[2]}-01' and '{data[1]}-{data[2]}-{DateTime.DaysInMonth(int.Parse(data[1]), int.Parse(data[2]))}'))" +
                   $" and _intId = {data[0]}; ";
        }

        /// <summary>
        /// Generates a querry for updating entries from provided data.
        /// יוצר שאילתה לעדכון ערכים מהנתונים שסופקו
        /// </summary>
        /// <param name="clientQuerry"></param>
        /// <returns></returns>
        public static string UpdateEntry(string clientQuerry)
        {
            string[] querryData = clientQuerry.Substring(clientQuerry.IndexOf('#') + 1).Split(',');
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

        /// <summary>
        /// Generates a querry for retrieving entries with the wrong format. The parameter is unnecesery and is there only for consistency across the class.
        /// יוצר שאילתה שמחזירה את כל שעות הכניסה והיציאה שבפורמט לא תקין או שחסרות 
        /// </summary>
        /// <param name="clientQuerry"></param>
        /// <returns></returns>
        public static string GetAllExceptions(string clientQuerry = "") => $"select * from {Config.EmployeeHourLogsTable} where _entry<'{Config.MinDate}' or _exit<'{Config.MinDate}' or _exit<_entry or DATEDIFF(HOUR, _entry, _exit)>'{Config.MaxShiftLength.Hours}' or _entry is NULL or _exit is NULL";

        /// <summary>
        /// Retrieves yearly hour logs info.
        /// </summary>
        public static string GetYearLog(string clientQuerry) //get log #_intId, year
        {
            string[] data = clientQuerry.Substring(clientQuerry.IndexOf('#') + 1).Split(',');
            return $"select * from {Config.EmployeeHourLogsTable} where " +
                   $"((_entry between '{data[1]}-01-01' and '{int.Parse(data[1]) + 1}-01-01') or " +
                   $"(_exit between '{data[1]}-01-01' and '{int.Parse(data[1]) + 1}-01-01'))" +
                   $" and _intId = {data[0]} order by _entry ASC;";
        }
    }
}
