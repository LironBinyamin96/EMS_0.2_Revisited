using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_Server
{
    internal class MyRouter
    {
        public string Router(EMS_Library.Network.DataPacket data)
        {
            switch (data._header.Act)
            {
                default: { throw new Exception($"Requested action was not found! Check DataPacket._header.Act!\n_header={data._header}\nAct={data._header.Act}"); }
                case 20: { return null; }
                case 253: { return SQLBridge.OneWayCommand(data.StringData); }
                case 254: { return SQLBridge.TwoWayCommand(data.StringData); }
                case 255: { return data.StringData; }
            }
        }
    }
}
