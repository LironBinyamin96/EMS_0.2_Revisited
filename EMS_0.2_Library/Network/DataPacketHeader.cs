using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_Library.Network
{
    public struct DataPacketHeader
    {
        public readonly int HeaderSize = 5;
        public readonly int DataIntLength = 0;
        public readonly byte[] DataByteLength = new byte[4];
        public readonly byte Act;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="length"></param>
        /// <param name="act"></param>
        public DataPacketHeader(int length, byte act)
        {
            DataIntLength = length;
            DataByteLength = BitConverter.GetBytes(DataIntLength);
            Act = act;
        }

        /// <summary>
        /// Provides header in byte[] format.
        /// </summary>
        /// <returns></returns>
        public byte[] GetHeader() => BitConverter.GetBytes(DataIntLength).Concat(new byte[] { Act }).ToArray();

        /// <summary>
        /// Provides string representing the header.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => DataIntLength + " " + Act.ToString();
    }
}
