using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_Library.MyEmployee.Divisions
{
    public class HR_Grunt : HumanResources
    {
        public HR_Grunt(string data) : base(data)
        {
        }

        public HR_Grunt(object[] data) : base(data)
        {
        }

        public HR_Grunt( int intId, string stateID, string fName, string lName, string mName, string password, string email, string gender, DateTime birthDate, DateTime created, string employmentStatus, double baseSalary, double salaryModifire, string phoneNumber, string address) : base(typeof(HR_Grunt), intId, stateID, fName, lName, mName, password, email, gender, birthDate, created, employmentStatus, baseSalary, salaryModifire, phoneNumber, address)
        {
        }
    }
}
