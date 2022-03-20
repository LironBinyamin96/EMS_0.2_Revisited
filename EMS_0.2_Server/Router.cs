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
                /*Select employee*/case 1: { return SQLBridge.TwoWayCommand(SQLBridge.Select(data.StringData)); }
                /*Add employee*/   case 2: { return SQLBridge.OneWayCommand(SQLBridge.Add(data.StringData)); }
                /*Update employee*/case 3: { return SQLBridge.OneWayCommand(SQLBridge.Update(data.StringData)); }
                /*Delete employee*/case 4: { return SQLBridge.OneWayCommand(SQLBridge.Delete(data.StringData)); }
                /*Direct querry*/  case 253: { return SQLBridge.OneWayCommand(data.StringData); }
                /*Direct querry*/  case 254: { return SQLBridge.TwoWayCommand(data.StringData); }
                /*Ping*/           case 255: { return data.StringData; }
            }
        }
    }
}
