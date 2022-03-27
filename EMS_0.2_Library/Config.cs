namespace EMS_Library
{
    public static class Config
    {
        #region Server_Config
        public const string ServerIP = "127.0.0.1";
        public const int ServerPort = 13000;
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
        public const string SQLDatabaseName = "EmployeeManagmentDataBase";
        public const string DefaultId = "111111111";
        public const string DefaultPassword = "111111111";


        //Variables
        public static byte ServerNamesIterator = 0;
        public static string SQLConnectionString = default;
        #endregion

        #region Employee_config
        public static string EmployeeFilesDir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\EMS_Root";
        #endregion

        public const bool flag = true;
    }
}