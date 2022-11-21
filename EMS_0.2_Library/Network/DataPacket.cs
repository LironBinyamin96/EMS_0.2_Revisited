using System.Net.Sockets;
using System.Text;

namespace EMS_Library.Network
{
    public struct DataPacket
    {
        public readonly DataPacketHeader _header;
        public readonly string StringData;
        readonly byte[] _byteData;

        /// <summary>
        /// בנאי שמקבל זרם נתונים ובונה מהם חבילת מידע
        /// Reconstructs recieved data as DataPacket
        /// </summary>
        /// <param name="stream"></param>
        public DataPacket(NetworkStream stream)
        {
            try
            {
                byte[] temp = new byte[]
                {
                    (byte)stream.ReadByte(),
                    (byte)stream.ReadByte(),
                    (byte)stream.ReadByte(),
                    (byte)stream.ReadByte()
                };
                int length;
                try { length = BitConverter.ToInt32(temp, 0); }
                catch (ArgumentOutOfRangeException) { length = int.MaxValue; Console.WriteLine($"DataPacket length {BitConverter.ToInt32(temp, 0)}! setting to {int.MaxValue}"); }
                _header = new DataPacketHeader(length, (byte)stream.ReadByte());
                _byteData = new byte[_header.DataIntLength];

                int i = 0;
                while (i < _header.DataIntLength)
                {
                    if (stream.DataAvailable) _byteData[i++] = (byte)stream.ReadByte();
                }

                StringData = Encoding.UTF8.GetString(_byteData, 0, _header.DataIntLength);
                if (Config.DevelopmentMode)
                {
                    Console.WriteLine($"Read {i} bytes of {_header.DataIntLength}");
                    Console.WriteLine("Creation complete!\n" + ToString());
                }
            }
            catch
            {
                throw new Exception($"Failed to create data packet!");
            }

        }
        /// <summary>
        /// בנאי שמקבל מחרוזת ובונה ממנו חבילת מידע
        /// Constructs a Data Packet to be sent to the server
        /// </summary>
        /// <param name="header"></param>
        /// <param name="data"></param>
        /// <exception cref="Exception"></exception>
        public DataPacket(string data, byte func = 255)
        {
            if (data.Length > Math.Pow(255, 4) - 20) throw new Exception("Data is too long! 4294967296 max! Length was " + data.Length);
            if (data.Length == 0) data = " ";
            _header = new DataPacketHeader(data.Length, func);
            StringData = data;
            _byteData = Encoding.UTF8.GetBytes(data);
            if (Config.DevelopmentMode)
                Console.WriteLine("Creation complete!\n" + ToString());
        }

        /// <summary>
        /// Constructs data packet out of byte array. (used for transfering pictures) 
        /// בונה חבילת נתונים מתוך מערך בתים. (משמש להעברת תמונות)
        /// </summary>
        /// <param name="data"></param>
        /// <param name="func"></param>
        public DataPacket(byte[] data, byte func = 255)
        {
            _header = new DataPacketHeader(data.Length, func);
            _byteData = data;
            StringData = Encoding.UTF8.GetString(data);
            if (Config.DevelopmentMode)
            {
                Console.WriteLine("Creation complete!\n" + ToString());
            }
        }

        /// <summary>
        /// Provides data in format that is suitable for writing into the network stream.
        /// מספק נתונים בפורמט המתאים לכתיבה לזרם הרשת.
        /// </summary>
        /// <returns></returns>
        public byte[] Write() => _header.GetHeader().Concat(_byteData).ToArray();

        /// <summary>
        /// Returns a Copy of the byte array.
        /// מחזירה עותק של מערך הבתים.
        /// </summary>
        public byte[] ByteData
        {
            get
            {
                byte[] hold = new byte[_byteData.Length];
                _byteData.CopyTo(hold, 0);
                return hold;
            }
        }


        /// <summary>
        /// Calculates total size of data to be transfered. (including the header)
        /// מחשב את הגודל הכולל של הנתונים שיש להעביר. (כולל הכותרת)
        /// </summary>
        /// <returns></returns>
        public int GetTotalSize() => _header.DataIntLength + _header.HeaderSize;

        /// <summary>
        /// Provides string representing the DataPacket object. (Won't provide data if it's longer than 1000 characters.)
        /// מספק מחרוזת המייצגת את האובייקט DataPacket. (לא יספק נתונים אם הם ארוכים מ-1000 תווים.)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (StringData.Length < 1000) return $"Header: [{_header}], Data: [{StringData}]";
            else return $"Header: [{_header}]";
        }
    }
}
