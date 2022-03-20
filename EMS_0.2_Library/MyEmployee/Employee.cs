using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EMS_Library.MyEmployee
{
    /// <summary>
    /// Base class for all employees
    /// </summary>
    public class Employee
    {
        #region Employee Fields
        private readonly Type _type;
        private readonly int _intId;
        private string _stateId;
        private string _fName;
        private string _lName;
        private string _mName;
        private string _password;
        private string _email;
        private string _gender;
        private DateTime _birthDate;
        private DateTime _created;
        private string _employmentStatus; //0)fired/left 1)Employed+Not on premises 2)Employed+On premises
        private double _baseSalary;
        private double _salaryModifire = 1;
        private string _phoneNumber;
        private string _address;
        #endregion
        #region Employee properties
        public Type Type => _type;
        public int IntId => _intId;
        public string StateId { get => _stateId; set => _stateId = value; }
        public string FName { get => _fName; set => _fName = value; }
        public string LName { get => _lName; set => _lName = value; }
        public string MName { get => _mName; set => _mName = value; }
        public string Password { get => _password; set => _password = value; }
        public string Email { get => _email; set => _email = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public DateTime BirthDate { get => _birthDate; set => _birthDate = value; }
        public DateTime Created { get => _created; set => _created = value; }
        public string EmploymentStatus { get => _employmentStatus; set => _employmentStatus = value; }
        public double BaseSalary { get => _baseSalary; set => _baseSalary = value; }
        public double SalaryModifire { get => _salaryModifire; set => _salaryModifire = value; }
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public string Address { get => _address; set => _address = value; }
        #endregion


        public Employee(Type type, int intId, string stateID, string fName, string lName, string mName, string password, string email, string gender, DateTime birthDate, DateTime created, string employmentStatus, double baseSalary, double salaryModifire, string phoneNumber, string address)
        {
            _type = type;
            _intId = intId;
            _stateId = stateID;
            _fName = ToUpperFirst(fName).Replace(" ", "_");
            _lName = ToUpperFirst(lName).Replace(" ", "_");
            _mName = ToUpperFirst(mName).Replace(" ", "_");
            _password = password;
            _email = email;
            _gender = gender.Replace(" ", "_");
            _birthDate = birthDate;
            _created = created;
            _employmentStatus = employmentStatus;
            _baseSalary = baseSalary;
            _salaryModifire = salaryModifire;
            _phoneNumber = phoneNumber;
            _address = address.Replace(" ", "_");
        }
        public Employee(string data)
        {
            string[] temp = data.Split(',');
            int counter = 0;
            _type = Type.GetType("EMS_Library.MyEmployee.Divisions." + temp[counter++]);
            _intId = int.Parse(temp[counter++]);
            _stateId = temp[counter++];
            _fName = temp[counter++];
            _lName = temp[counter++];
            _mName = temp[counter++];
            _password = temp[counter++];
            _email = temp[counter++];
            _gender = temp[counter++];
            _birthDate = DateTime.Parse(temp[counter++]);
            _created = DateTime.Parse(temp[counter++]);
            _employmentStatus = temp[counter++];
            _baseSalary = double.Parse(temp[counter++]);
            _salaryModifire = double.Parse(temp[counter++]);
            _phoneNumber = temp[counter++];
            _address = temp[counter++];
        }
        public Employee(object[] data)
        {
            string[] hold = Array.ConvertAll(data, x => x.ToString());
            _type = Type.GetType("EMS_Library.MyEmployee.Divisions." + data[0]);
            _intId = int.Parse(hold[1]);
            _stateId = hold[2];
            _fName = hold[3];
            _lName = hold[4];
            _mName = hold[5];
            _password = hold[6];
            _email = hold[7];
            _gender = hold[8];
            _birthDate = DateTime.Parse(hold[9]);
            _created = DateTime.Parse(hold[10]);
            _employmentStatus = hold[11];
            _baseSalary = int.Parse(hold[12]);
            _salaryModifire = int.Parse(hold[13]);
            _phoneNumber = hold[14];
            _address = hold[15];
        }

        public static string ToUpperFirst(string s)
        {
            if (string.IsNullOrEmpty(s)) throw new ArgumentNullException("ToUpperCase: string was empty or null");
            StringBuilder sb = new StringBuilder(s);
            if (sb[0] > 'a' && sb[0] < 'z')
                sb[0] = (char)(sb[0] - 32);
            return sb.ToString();
        }
        /// <summary>
        /// Gets string representing Enployee
        /// </summary>
        /// <returns>type name, internal id, first name, last name.</returns>
        public override string ToString()
        {
            return $"" +
               $"'{this.GetType().Name}'," +
               $"{_intId}," +
               $"'{_stateId}'," +
               $"'{_fName}'," +
               $"'{_lName}'," +
               $"'{_mName}'," +
               $"'{_password}'," +
               $"'{_email}'," +
               $"'{_gender}'," +
               $"'{_birthDate}'," +
               $"'{_created}'," +
               $"'{_employmentStatus}'," +
               $"{_baseSalary}," +
               $"{_salaryModifire}," +
               $"'{_phoneNumber}'," +
               $"'{_address}'";
        }
        public static Employee ActivateEmployee(object[] data)
        {
            string[] hold = Array.ConvertAll(data, x => x.ToString());
            string temp = "";
            foreach (var item in hold)
                temp += item.Trim() + ",";
            try { return Activator.CreateInstance(Type.GetType("EMS_Library.MyEmployee.Divisions." + hold[0]), temp.Trim()) as Employee; }
            catch { return null; }
        }
        public static Employee GetStockEmployee()
        {
            return new Divisions.IT_Boss(
                int.MaxValue / 10,
                "689175846",
                "Fstock",
                "Lstock",
                "Mstock",
                "123",
                "email@gmail.com",
                "Four-dimensional bullshit",
                DateTime.Parse("01/02/0003"),
                DateTime.Now,
                "1",
                69.96,
                1.5,
                "0983246875",
                "Lala Land"
                );
        }
        public EmployeeDirectory GetDirectory => new EmployeeDirectory(_intId);
    }
}
