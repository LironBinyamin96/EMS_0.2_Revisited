using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS_Library;
using EMS_Library.MyEmployee.Divisions;


namespace EMS_Library.MyEmployee
{
    /// <summary>
    /// Base class for all employees
    /// </summary>
    public abstract class Employee
    {
        #region Employee Fields
        private readonly Type _type;
        private readonly int _intId;
        private string _stateId;
        private string _fName;
        private string _lName;
        private string _mName;
        private string _email;
        private string _password;
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
        public string Email { get => _email; set => _email = value; }
        public string Password { get => _password; set => _password = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public DateTime BirthDate { get => _birthDate; set => _birthDate = value; }
        public DateTime Created { get => _created; set => _created = value; }
        public string EmploymentStatus { get => _employmentStatus; set => _employmentStatus = value; }
        public double BaseSalary { get => _baseSalary; set => _baseSalary = value; }
        public double SalaryModifire { get => _salaryModifire; set => _salaryModifire = value; }
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public string Address { get => _address; set => _address = value; }
        public EmployeeDirectory GetDirectory => new EmployeeDirectory(_intId);
        #endregion
        public Employee(Type type, int intId, string stateID, string fName, string lName, string mName, string password, string email, string gender, DateTime birthDate, DateTime created, string employmentStatus, double baseSalary, double salaryModifire, string phoneNumber, string address)
        {
            _type = type;
            _intId = intId;
            _stateId = stateID;
            _fName = fName.CapitalizeFirst().Replace(" ", "_");
            _lName = lName.CapitalizeFirst().Replace(" ", "_");
            _mName = mName.CapitalizeFirst().Replace(" ", "_");
            _email = email;
            _password = password;
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
            _email = temp[counter++];
            _password = temp[counter++];
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

        /// <summary>
        /// Creates an instance of Employee of specific subtype.
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Employee or null if cration failed.</returns>
        public static Employee ActivateEmployee(object[] data)
        {
            string[] hold = Array.ConvertAll(data, x => x.ToString());
            string temp = "";
            foreach (var item in hold)
                temp += item.Trim() + ",";
            try { return Activator.CreateInstance(Type.GetType("EMS_Library.MyEmployee.Divisions." + hold[0]), temp.Trim()) as Employee; }
            catch { return null; }
        }

        /// <summary>
        /// Provides string representing the employee.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Provides dictionary of fields and their values.
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string> ProvideFieldsAndValues()
        {
            return new Dictionary<string, string>() {
                {"type", _type.Name},
                { "_intId", _intId.ToString()},
                {"_stateId", _stateId},
                {"_fName", _fName },
                {"_lName", _lName},
                {"_mName", _mName },
                {"_email", _email},
                {"_password", _password},
                {"_gender", _gender},
                {"_birthDate", _birthDate.ToString()},
                {"_created", _created.ToString()},
                {"_employmentStatus", _employmentStatus},
                {"_baseSalary", _baseSalary.ToString()},
                {"_salaryModifire", _salaryModifire.ToString()},
                {"_phoneNumber",_phoneNumber },
                {"_address",_address },
            };
        }
    }
}
