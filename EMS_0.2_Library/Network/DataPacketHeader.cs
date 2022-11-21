namespace EMS_Library.Network
{
    public struct DataPacketHeader
    {
        public readonly int HeaderSize = 5;
        public readonly int DataIntLength = 0;
        public readonly byte[] DataByteLength = new byte[4];
        public readonly byte Act;

        /// <summary>
        /// Constructor | בנאי
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
        /// []byte מספק כותרת בפורמט .
        /// </summary>
        /// <returns></returns>
        public byte[] GetHeader() => BitConverter.GetBytes(DataIntLength).Concat(new byte[] { Act }).ToArray();

        /// <summary>
        /// Provides string representing the header.
        /// מספק מחרוזת המייצגת את הכותרת.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"Size: {DataIntLength}Bytes, Routing: {Act}";
    }
}
