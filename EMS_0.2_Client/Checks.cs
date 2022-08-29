using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_Client
{

    /// <summary>
    /// Depricated. Use propper type extonsions.
    /// </summary>
    public class Checks
    {
        // אורך מחרוזת - בדיקה לשם פרטי\שם משפחה\כתובת
        public bool StringLength(string str) => str.Trim().Length > 2;

        // בדיקת תקינות תעודת זהות

        public bool IsVaildId(string id)
        {
            int[] id_12_digits = { 1, 2, 1, 2, 1, 2, 1, 2, 1 };
            int count = 0;

            if (id == null || id == default || id.Length>9)  return false;
            id = id.PadLeft(9, '0'); // מוסיף את הספרה 0 מצד שמאל עד לאורך 9 ספרות
            for (int i = 0; i < 9; i++)
            {
                int num = Int32.Parse(id.Substring(i, 1)) * id_12_digits[i];

                if (num > 9)
                    num = (num / 10) + (num % 10);
                count += num;
            }
            return count % 10 == 0;
        }
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
                //System.Net.Mail.MailAddress.TryCreate(email, out _);
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
