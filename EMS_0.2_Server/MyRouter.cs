using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS_Library.Network;

namespace EMS_Server
{
    internal class MyRouter
    {
        /// <summary>
        /// Requests router
        /// </summary>
        /// <param name="data"></param>
        /// <exception cref="Exception"></exception>
        public DataPacket Router(DataPacket data)
        {
            switch (data._header.Act)
            {
                default: { throw new Exception($"Requested action was not found! Check DataPacket._header.Act!\n_header={data._header}\nAct={data._header.Act}"); }
                /*Select employee*/ case 1: { return new DataPacket(SQLBridge.TwoWayCommand(SQLBridge.Select(data.StringData)), 255); }
                /*Add employee*/    case 2: { return new DataPacket(SQLBridge.OneWayCommand(SQLBridge.Add(data.StringData)), 255); }
                /*Update employee*/ case 3: { return new DataPacket(SQLBridge.OneWayCommand(SQLBridge.Update(data.StringData)), 255); }
                /*Delete employee*/ case 4: { return new DataPacket(SQLBridge.OneWayCommand(SQLBridge.DeleteEmployee(data.StringData)), 255); }
                /*Get employee log*/case 5: { return new DataPacket(SQLBridge.TwoWayCommand(SQLBridge.GetMonthLog(data.StringData)), 255);}
                /*Get Picture*/     case 6: { return new DataPacket(GetPicture(), 255); }
                /*Update entry*/    case 7: { return new DataPacket(SQLBridge.UpdateEntry(data.StringData), 255); };
                /*Get free ID*/     case 252: { return new DataPacket(SQLBridge.GetFreeID(), 255); }
                /*Direct querry*/   case 253: { return new DataPacket(SQLBridge.OneWayCommand(data.StringData), 255); }
                /*Direct querry*/   case 254: { return new DataPacket(SQLBridge.TwoWayCommand(data.StringData), 255); }
                /*Ping*/            case 255: { return new DataPacket(data.StringData, 255); }
            }
            
            //Retrieves picture and returns it as byte[]
            byte[] GetPicture()
            {
                //"get picture of #_intid"
                if (int.TryParse(data.StringData.Substring(data.StringData.IndexOf('#') + 1), out int id))
                {
                    string imagePath = EMS_Library.Config.FR_Images + $"\\{id}{EMS_Library.Config.ImageFormat}";
                    if (File.Exists(imagePath))
                        return File.ReadAllBytes(imagePath);
                    else return new byte[0];
                }
                else return new byte[0];
            }
        }
    }
}
