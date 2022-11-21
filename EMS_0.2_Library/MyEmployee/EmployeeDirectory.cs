namespace EMS_Library.MyEmployee
{
    public class EmployeeDirectory
    {
        DirectoryInfo _dir;
        DirectoryInfo _trainingImmagesDir;
        DirectoryInfo _mainImmage;
        int _intId;
        public int IntId => _intId;
        public DirectoryInfo Dir => _dir;
        public DirectoryInfo TrainingImmagesDir => _trainingImmagesDir;
        public DirectoryInfo MainImmage => _mainImmage;
        public EmployeeDirectory(int employeeIntId)
        {
            _intId = employeeIntId;
            _dir = Directory.CreateDirectory(Config.RootDirectory + "\\" + employeeIntId);
            _trainingImmagesDir = Directory.CreateDirectory(_dir.FullName + "\\Training Immages");
            _mainImmage = Directory.CreateDirectory(_dir.FullName);
        }
        public Bitmap GetMainImmage(Employee emp) => new Bitmap(_mainImmage.FullName);
        public Bitmap[] GetTrainingImmages()
        {
            string[] dirs = Directory.EnumerateFiles(_trainingImmagesDir.FullName).ToArray();
            List<Bitmap> images = new List<Bitmap>();
            foreach (string path in dirs)
                images.Add(new Bitmap(path));
            return images.ToArray();
        }
    }
}
