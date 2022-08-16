using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace EMS_Library.Network
{
    public struct DataPacket
    {
        private static int counter = 0;
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
                //int dataAmountRead = stream.Read(_byteData, 0, _header.DataIntLength);
                int i = 0;
                while(i<_header.DataIntLength)
                {
                    if(stream.DataAvailable) _byteData[i++] = (byte)stream.ReadByte();
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
        /// בנאי שמקבל סטרינג ובונה ממנו חבילת מידע
        /// Constructs a Data Packet to be sent to the server
        /// </summary>
        /// <param name="header"></param>
        /// <param name="data"></param>
        /// <exception cref="Exception"></exception>
        public DataPacket(string data, byte func=255)
        {
            if (data.Length > Math.Pow(255, 4) - 20) throw new Exception("Data is too long! 4294967296 max! Length was " + data.Length);
            if (data.Length == 0) data = " ";
            _header = new DataPacketHeader(data.Length, func);
            StringData = data;
            _byteData = Encoding.UTF8.GetBytes(data);
            if (Config.DevelopmentMode)
                Console.WriteLine("Creation complete!\n" + ToString());
        }
        public DataPacket(DataPacket data)
        {
            _header = data._header;
            _byteData = data.ByteData;
            StringData = data.StringData;
        }
        public DataPacket(byte[] data, byte func=255)
        {
            _header = new DataPacketHeader(data.Length, func);
            _byteData = data;
            StringData = Encoding.UTF8.GetString(data);
            if (Config.DevelopmentMode)
            {
                Console.WriteLine("Creation complete!\n" + ToString());
            }
        }
        public byte[] Write() => _header.GetHeader().Concat(_byteData).ToArray();

        public void WriteToStream(NetworkStream stream)
        {
            for (int i = 0; i < _header.DataIntLength; i++)
                stream.WriteByte(_byteData[i]);
        }


        /// <summary>
        /// Returns a Copy of the byte array.
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

        public int GetTotalSize() => _header.DataIntLength + _header.HeaderSize;
        public override string ToString() 
        {
            if(StringData.Length<1000) return $"Header: [{_header}], Data: [{StringData}]";
            else return $"Header: [{_header}]";
        }

        private void PrintDebug()
        {
            foreach (byte a in _byteData)
                Console.Write((char)a);
            Console.WriteLine();
        }
    }
}
