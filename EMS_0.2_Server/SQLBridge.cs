using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EMS_Server
{
    internal class SQLBridge
    {
        public static string OneWayCommand(string IncomingCommand)
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
            catch (SqlException ex) { return ex.Message; }
        }

        /// <summary>
        /// שאילתה דו כיווני
        /// Sends provided querry to the server.
        /// </summary>
        /// <returns> Responce from the server (Listof objects or an object depending on the querry). </returns>
        public static string TwoWayCommand(string IncomingCommand)
        {
            try
            {
                SqlConnection Connection = new SqlConnection(EMS_Library.Config.SQLConnectionString);
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
                        stringBuilder.Append(s.ToString().Trim() + ',');
                    stringBuilder.Remove(stringBuilder.Length - 1, 1);
                    stringBuilder.Append('|');
                }
                Connection.Close();
                return stringBuilder.Length > 0 ? stringBuilder.ToString() : "-1";
            }
            catch (SqlException ex) { return ex.Message; }
        }

        public static string Select(string clientQuerry)
        {
            string[] clause = clientQuerry.Substring(clientQuerry.IndexOf('#') + 1).Split(',');
            string final = "select * from Employees";
            if (clause.Length > 0)
            {
                final += " where";
                foreach (string item in clause)
                    final += " " + item;
            }
            return final;
        }
    }
}
