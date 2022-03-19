using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_Library.MyEmployee.Divisions
{
    public class IT_Grunt : IT, IAccess.IRootAccess
    {
        public IT_Grunt(string data) : base(data)
        {
        }

        public IT_Grunt(object[] data) : base(data)
        {
        }

        public IT_Grunt( int intId, string stateID, string fName, string lName, string mName, string password, string email, string gender, DateTime birthDate, DateTime created, string employmentStatus, double baseSalary, double salaryModifire, string phoneNumber, string address) : base(typeof(IT_Grunt), intId, stateID, fName, lName, mName, password, email, gender, birthDate, created, employmentStatus, baseSalary, salaryModifire, phoneNumber, address)
        {
        }
    }
}
