using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_Client
{
    public class Checks
    {
        // אורך מחרוזת - בדיקה לשם פרטי\שם משפחה\כתובת
        public bool StringLength(string str) => str.Trim().Length > 2;
        // בדיקה למספר פלאפון
        public bool PhoneNumber(string number) => (number.Length == 10) && (number.StartsWith("0")) && number.All(char.IsDigit);
        // בדיקה למייל
        public bool IsValidEmail(string email)
        {
            if (!email.Contains(".") || email.Trim().EndsWith("."))
                return false;
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
            }
            catch
            {
                return false;
            }
            return true;
        }
        // בדיקת מספר זהות
        public bool IdNumber(string id) => id.Trim().Length == 9 && id.Trim().All(char.IsDigit);
        // בדיקת מספר
        public bool IsNumber(string str) => int.TryParse(str, out _);
        //בדיקת תאריך => 'yyyy-mm-d','dd/mm/yyyy','d.mm.yy'
        public bool ItsDate(string date) =>  (DateTime.TryParse(date, out _));
        //בדיקת תפקיד מיועד
        public bool SelectedPosition(ComboBox position) => position.Text != ""; 
        // בדיקת תמונה
        public bool picture(Bitmap employeeImage) => employeeImage != null;

        
    }
}
