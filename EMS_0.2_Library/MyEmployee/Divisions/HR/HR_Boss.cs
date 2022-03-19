using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_Library.MyEmployee.Divisions
{
    public class HR_Boss : HumanResources, IAccess.IExtendedAccess
    {
        public HR_Boss(string data) : base(data)
        {
        }

        public HR_Boss(object[] data) : base(data)
        {
        }

        public HR_Boss(int intId, string stateID, string fName, string lName, string mName, string password, string email, string gender, DateTime birthDate, DateTime created, string employmentStatus, double baseSalary, double salaryModifire, string phoneNumber, string address) : base(typeof(HR_Boss), intId, stateID, fName, lName, mName, password, email, gender, birthDate, created, employmentStatus, baseSalary, salaryModifire, phoneNumber, address)
        {
        }
    }
}
