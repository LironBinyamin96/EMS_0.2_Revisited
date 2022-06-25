using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

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


        public static DateTime RandomDateTime() => new DateTime(RandomInt(1800, 2022), RandomInt(1, 13), RandomInt(1, 29), RandomInt(0,24), RandomInt(0, 60), RandomInt(0, 60));
    }
    public static class Extensions
    {
        /// <summary>
        /// Converts an object to a byte array.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static byte[] ObjectToByteArray(this object obj)
        {
            if (!Attribute.IsDefined(obj.GetType(), typeof(SerializableAttribute)))
                throw new ArgumentException("The object must have the Serializable attribute.", "obj");
            BinaryFormatter bf = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        /// <summary>
        /// Checks if enumerable collection consists of only it's default values.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static bool IsEmpty<T>(this IEnumerable<T> collection)
        {
            if(collection == null || collection.Count()==0) return true;
            if(default(T) == null) return collection.Contains(default);
            byte[] def = default(T).ObjectToByteArray();
            foreach (T item in collection)
            { 
                byte[] data = item.ObjectToByteArray();
                bool check = true;
                for (int i = 0; i < data.Length; i++)
                    if(data[i] != def[i]) return false;
            }
            return true;
        }
    }
    
}
