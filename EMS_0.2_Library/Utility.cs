using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_Library
{
    public static class Utility
    {
        private static Random rnd = new Random();
        public static int RandomInt(int floor, int ceiling) => rnd.Next(floor, ceiling);
        public static int RandomInt(int numOfDigits) => rnd.Next((int)(1 * Math.Pow(10, numOfDigits - 1)), (int)(1 * Math.Pow(10, numOfDigits)));
        public static bool RandomBool() => rnd.Next(2) == 1;
        public static char RandomChar() => (char)rnd.Next((int)'a', (int)'z' + 1);
        public static char RandomNumericChar() => (char)rnd.Next((int)'0', (int)'9' + 1);
        public static string RandomString(int len)
        {
            string str = "";
            for (int i = 0; i < len; i++)
                str += RandomChar();
            return str;
        }
        public static string RandomNumericString(int len)
        {
            string str = "";
            for (int i = 0; i < len; i++)
                str += RandomNumericChar();
            return str;

        }
        public static DateTime RandomDateTime() => new DateTime(RandomInt(1, 2022), RandomInt(1, 13), RandomInt(1, 29));
        
    }
}
