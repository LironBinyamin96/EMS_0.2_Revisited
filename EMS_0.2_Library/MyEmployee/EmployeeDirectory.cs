using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Drawing;

namespace EMS_Library.MyEmployee
{
    public class EmployeeDirectory
    {
        DirectoryInfo _dir;
        DirectoryInfo _trainingImmagesDir;
        DirectoryInfo _hoursLog;
        DirectoryInfo _mainImmage; 
        public EmployeeDirectory(int employeeIntId)
        {
            _dir = Directory.CreateDirectory(Config.EmployeeFilesDir + "\\" + employeeIntId);
            _trainingImmagesDir = Directory.CreateDirectory(_dir.FullName + "\\Training Immages");
            _hoursLog = Directory.CreateDirectory(_dir.FullName + "\\Hours Log");
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
        public DirectoryInfo GetLogDirectory { get => _hoursLog; } 
    }
}
