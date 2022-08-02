
namespace EMS_Library
{
    public static class Config
    {
        #region Server_Config
        
        public const int ServerPort = 13000;
        public static string ServerIP = default;
        public static string RootDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\EMS_Root";
        public static string FR_Location = RootDirectory + "\\FR_Boot.cmd";
        public static string FR_Images = RootDirectory + "\\Images";
        #endregion

        #region SQL_server_config
        public static string SQLServerName => SQLServerNames[ServerNamesIterator++ % SQLServerNames.Length];
        public static string[] SQLServerNames =
        {
            "DESKTOP-BVFPCJ9\\SQLEXPRESS",
            "LEV-STATPC\\LEVPCMSSQLSERVER",
            "DESKTOP-A6E5597\\SQLEXPRESS",
            "DESKTOP-LL8D68S",
        };

        public const string DefaultId = "111111111";
        public const string DefaultPassword = "111111111";

        //Variables
        public static byte ServerNamesIterator = 0;
        public static string SQLConnectionString = default;
        #endregion

        #region SQL_DB_config
        public const string SQLDatabaseName = "EmployeeManagmentDataBase";
        public const string EmployeeDataTable = "Employees";
        public const string EmployeeHourLogsTable = "HourLogs";

        public static string PythonDBConnection = "";
        #endregion

        #region Legal
        public static TimeSpan NormalShiftLength = new TimeSpan(0, 8, 0, 0);
        public static TimeSpan MaxShiftLength = new TimeSpan(0, 12, 0, 0);
        public static string[] NullableEmployeeData = { "MName", "MiddleName", "_mName", "Gender", "_gender" };
        #endregion

        #region FR & Imaging
        public const int FRImmageHeight = 164;
        public const int FRImmageWidth = 164;
        public const string ImageFormat = ".jpg";
        #endregion

        //Development Mode
        public const bool DevelopmentMode = true;
    }
}