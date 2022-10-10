
namespace EMS_Library
{
    /// <summary>
    /// Class containing user defined configurations for the programm.
    /// מחלקה המכילה תצורות מוגדרות על ידי המשתמש עבור התוכנית.
    /// </summary>
    public static class Config
    {
        #region Server_Config
        //Do not forget to open thouse ports in server side firewall settings!
        public const int ServerPort = 13000; 

        public static string ServerIP = default;
        public static readonly string RootDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\EMS_Root";
        public static readonly string FR_Location = RootDirectory + "\\FR_Boot.cmd";
        public static readonly string FR_Images = RootDirectory + "\\Images";
        public const int ClientRequestTimeout = 10000; //In milliseconds.
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

        public const string DefaultId = "316472570";
        public const string DefaultPassword = "1234";

        //Variables | משתנים
        public static byte ServerNamesIterator = 0;
        public static string SQLConnectionString = default;
        #endregion

        #region SQL_DB_config
        public const string SQLDatabaseName = "EmployeeManagmentDataBase";
        public const string EmployeeDataTable = "Employees";
        public const string EmployeeHourLogsTable = "HourLogs";

        public static string PythonDBConnection = "";
        #endregion

        #region General
        public const int InternalIDDigitAmount = 9; //represents amount of didgits in ID number (must be above 0)
        public static int[] WorkDaysInWeek = { 1, 2, 3, 4, 5 };
        public const int MinEmployeeAge = 18;
        public static readonly TimeSpan NormalShiftLength = new TimeSpan(0, 8, 0, 0);
        public static readonly TimeSpan MaxShiftLength = new TimeSpan(0, 12, 0, 0);
        public static readonly string[] NullableEmployeeData = { "MName", "MiddleName", "_mName", "Gender", "_gender" };
        public static readonly DateTime MinDate = DateTime.Parse("2000-01-01 00:00:00");

        #endregion

        #region FR & Imaging
        public const int FRImmageHeight = 164;
        public const int FRImmageWidth = 164;
        public const string ImageFormat = ".jpg";
        public const bool AutoStartFR = true;
        #endregion

        #region Email config
        public const string EMS_EmailAddress = "employee.management.system010@gmail.com";
        public const string EMA_EmailPassword = "wcvyicyfscoiqfgr";

        #endregion

        //Development Mode | מצב פיתוח
        public const bool DevelopmentMode = true;
    }
}