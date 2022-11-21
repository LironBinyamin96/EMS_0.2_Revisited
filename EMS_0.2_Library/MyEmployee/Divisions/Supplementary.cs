namespace EMS_Library.MyEmployee.Divisions
{
    public abstract class Supplementary : Employee
    {
        protected Supplementary(string data) : base(data)
        {
        }

        protected Supplementary(object[] data) : base(data)
        {
        }

        protected Supplementary(int intId, string stateID, string fName, string lName, string mName, string password, string email, string gender, DateTime birthDate, DateTime created, string employmentStatus, double baseSalary, double salaryModifire, string phoneNumber, string address) : base(typeof(Supplementary), intId, stateID, fName, lName, mName, password, email, gender, birthDate, created, employmentStatus, baseSalary, salaryModifire, phoneNumber, address)
        {
        }
    }
}
