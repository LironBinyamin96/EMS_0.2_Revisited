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
                /*Exception handling*/default:{ return new DataPacket(new ArgumentException($"Requested action was not found! Check DataPacket._header.Act!\n_header={data._header}\nAct={data._header.Act}").Message); }
                /*Select employee*/   case 1: { return new DataPacket(SQLBridge.TwoWayCommand(SQLBridge.Select(data.StringData))); }
                /*Add employee*/      case 2: { return new DataPacket(SQLBridge.OneWayCommand(SQLBridge.Add(data.StringData))); }
                /*Update employee*/   case 3: { return new DataPacket(SQLBridge.OneWayCommand(SQLBridge.Update(data.StringData))); }
                /*Delete employee*/   case 4: { return new DataPacket(SQLBridge.OneWayCommand(SQLBridge.DeleteEmployee(data.StringData))); }
                /*Get employee log*/  case 5: { return new DataPacket(SQLBridge.TwoWayCommand(SQLBridge.GetMonthLog(data.StringData)));}
                /*Get Picture*/       case 6: { return new DataPacket(GetPicture()); }
                /*Update entry*/      case 7: { return new DataPacket(SQLBridge.UpdateEntry(data.StringData)); };
                /*Get Exceptions*/    case 8: { return new DataPacket(SQLBridge.TwoWayCommand(SQLBridge.GetAllExceptions(data.StringData))); }
                /*Get all emails*/    case 9: { return new DataPacket(SQLBridge.TwoWayCommand("select _email from Employees;")); }
                /*Save image sent*/   case 10: { return new DataPacket(SavePucture(data.ByteData)); }

                /*Get free ID*/       case 252: { return new DataPacket(SQLBridge.GetFreeID(), 255); }
                /*Direct querry*/     case 253: { return new DataPacket(SQLBridge.OneWayCommand(data.StringData)); }
                /*Direct querry*/     case 254: { return new DataPacket(SQLBridge.TwoWayCommand(data.StringData)); }
                /*Out*/               case 255: { return data; }
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
                    return File.ReadAllBytes(imagePath);
                }
                else return new byte[0];
            }

            string SavePucture(byte[] picData)
            {
                if (picData == null || picData.Length == 0) return "Data packet contining the picture was empty or null";
                try
                {
                    int num = 0;
                    for (int i = 0; i < Config.InternalIDDigitAmount; i++)
                        num = (num * 10) + 1;
                    byte[] temp = BitConverter.GetBytes(num);
                    int intID = BitConverter.ToInt32(picData.TakeLast(temp.Length).ToArray());
                    Array.Resize(ref picData, picData.Length - temp.Length);
                    Bitmap image = (Bitmap)new ImageConverter().ConvertFrom(picData);
                    if (image != null) { image.Save(Config.FR_Images + $"\\{intID}{Config.ImageFormat}"); return "saved"; }
                    else return "Could not convert data recieved to image.";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }
    }
}
