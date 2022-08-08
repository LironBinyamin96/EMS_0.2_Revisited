using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS_Library.Network;
using EMS_Library;

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
                /*Select employee*/ case 1: { return new DataPacket(SQLBridge.TwoWayCommand(SQLBridge.Select(data.StringData))); }
                /*Add employee*/    case 2: { return new DataPacket(SQLBridge.OneWayCommand(SQLBridge.Add(data.StringData))); }
                /*Update employee*/ case 3: { return new DataPacket(SQLBridge.OneWayCommand(SQLBridge.Update(data.StringData))); }
                /*Delete employee*/ case 4: { return new DataPacket(SQLBridge.OneWayCommand(SQLBridge.DeleteEmployee(data.StringData))); }
                /*Get employee log*/case 5: { return new DataPacket(SQLBridge.TwoWayCommand(SQLBridge.GetMonthLog(data.StringData)));}
                /*Get Picture*/     case 6: { return new DataPacket(GetPicture()); }
                /*Update entry*/    case 7: { return new DataPacket(SQLBridge.UpdateEntry(data.StringData)); };


                /*Ping*/            //case 101: { return new DataPacket($"Ack. {EMS_Library.Config.ServerIP}:{EMS_Library.Config.ServerPort}"); }
                /*Sending Data*/    //case 102: { ConnectionsManager.AcceptClient(); return new DataPacket("Ack. Recieving."); }
                /*Terminate con*/   //case 103: { throw new NotImplementedException(""); }


                /*Get free ID*/
                case 252: { return new DataPacket(SQLBridge.GetFreeID(), 255); }
                /*Direct querry*/
                case 253: { return new DataPacket(SQLBridge.OneWayCommand(data.StringData)); }
                /*Direct querry*/
                case 254: { return new DataPacket(SQLBridge.TwoWayCommand(data.StringData)); }
                /*Out*/
                case 255: { return data; }
            }

            //Retrieves picture and returns it as byte[]
            byte[] GetPicture()
            {
                //"get picture of #_intid"
                if (int.TryParse(data.StringData.Substring(data.StringData.IndexOf('#') + 1), out int id))
                {
                    string imagePath = Config.FR_Images + $"\\{id}{Config.ImageFormat}";
                    if (!File.Exists(imagePath)) //If no image found, replace with stock.
                        imagePath = Config.FR_Images + $"\\StockImage{Config.ImageFormat}";
                    if (!File.Exists(imagePath)) throw new Exception($"Could not find neither eployee photo nor stock image. Place StockImage{Config.ImageFormat} into {Config.FR_Images} folder");
                    File.ReadAllBytes(imagePath).DebugPrint();
                    return File.ReadAllBytes(imagePath);
                }
                else return new byte[0];
            }
        }
    }
}
