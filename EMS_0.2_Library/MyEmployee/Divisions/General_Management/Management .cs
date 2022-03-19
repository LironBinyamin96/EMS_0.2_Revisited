using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_Library.MyEmployee.Divisions
{
    public abstract class Management : Employee
    {
        protected Management(string data) : base(data)
        {
        }

        protected Management(object[] data) : base(data)
        {
        }

        protected Management(Type type, int intId, string stateID, string fName, string lName, string mName, string password, string email, string gender, DateTime birthDate, DateTime created, string employmentStatus, double baseSalary, double salaryModifire, string phoneNumber, string address) : base(type, intId, stateID, fName, lName, mName, password, email, gender, birthDate, created, employmentStatus, baseSalary, salaryModifire, phoneNumber, address)
        {
        }
    }
}
