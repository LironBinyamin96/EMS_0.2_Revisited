using EMS_0._2_Server.Properties;
using EMS_Library;
using EMS_Library.Network;
using System;
using System.Diagnostics;

namespace EMS_Server
{
    internal class MyRouter
    {
        /// <summary>
        /// Requests router
        /// ניתוב בקשות
        /// </summary>
        /// <param name="data"></param>
        /// <exception cref="Exception"></exception>
        public async Task<DataPacket> Router(DataPacket data)
        {
            if (data.ByteData == null) return new DataPacket("Data recieved by the server was empty!");
            switch (data._header.Act)
            {
                /*Exception handling*/default: { return new DataPacket(new ArgumentException($"Requested action was not found! Check DataPacket._header.Act!\n_header={data._header}\nAct={data._header.Act}").Message); }
                /*Select employee*/   case 1: { return new DataPacket(SQLBridge.TwoWayCommand(SQLBridge.Select(data.StringData))); }
                /*Add employee*/      case 2: { return new DataPacket(SQLBridge.OneWayCommand(SQLBridge.Add(data.StringData))); }
                /*Update employee*/   case 3: { return new DataPacket(SQLBridge.OneWayCommand(SQLBridge.Update(data.StringData))); }
                /*Delete employee*/   case 4: { return new DataPacket(SQLBridge.OneWayCommand(SQLBridge.DeleteEmployee(data.StringData))); }
                /*Get employee log*/  case 5: { return new DataPacket(SQLBridge.TwoWayCommand(SQLBridge.GetMonthLog(data.StringData))); }
                /*Get Picture*/       case 6: { return new DataPacket(GetPicture()); }
                /*Update entry*/      case 7: { return new DataPacket(SQLBridge.UpdateEntry(data.StringData)); };
                /*Get Exceptions*/    case 8: { return new DataPacket(SQLBridge.TwoWayCommand(SQLBridge.GetAllExceptions(data.StringData))); }
                /*Get all emails*/    case 9: { return new DataPacket(SQLBridge.TwoWayCommand("select _email from Employees;")); }
                /*Save image sent*/   case 10: { return new DataPacket(await SavePucture(data.ByteData)); }
                /*Get yearly log*/    case 11: { return new DataPacket(SQLBridge.TwoWayCommand(SQLBridge.GetYearLog(data.StringData))); }
               
                /*Get free ID*/       case 252: { return new DataPacket(SQLBridge.GetFreeID(), 255); }
                /*Direct querry One*/ case 253: { return new DataPacket(SQLBridge.OneWayCommand(data.StringData)); }
                /*Direct querry Two*/ case 254: { return new DataPacket(SQLBridge.TwoWayCommand(data.StringData)); }
                /*Return recieved*/   case 255: { return data; }
            }


            //Retrieves the picture from file system. Returns image as byte array.
            //מאחזר את התמונה ממערכת הקבצים. מחזיר תמונה כמערך בתים.
            byte[] GetPicture()
            {
                //"get picture of #_intid"
                if (int.TryParse(data.StringData.Substring(data.StringData.IndexOf('#') + 1), out int id))
                {
                    string imagePath = Config.FR_Images + $"\\{id}{Config.ImageFormat}";
                    if (!File.Exists(imagePath)) //If no image found, replace with stock. | אם תמונה לא נמצאה
                        return (byte[])new ImageConverter().ConvertTo(Resources.StockImage, typeof(byte[])) ?? new byte[1];
                    if (!File.Exists(imagePath))
                    {
                        EMS_ServerMainScreen.serverForm.WriteToServerConsole($"Could not find neither eployee photo nor stock image. Place StockImage{Config.ImageFormat} into {Config.FR_Images} folder");
                        return new byte[1];
                    }
                    return File.ReadAllBytes(imagePath);
                }
                else return new byte[0];
            }

            // Saves picture into appropriate folder. Returns string representing outcome of the operation.
            // שומר תמונה בתיקייה המתאימה. מחזיר מחרוזת המייצגת את התוצאה של הפעולה.
            async Task<string> SavePucture(byte[] picData)
            {
                if (picData == null || picData.Length == 0) return "Data packet containing the picture was empty or null";
                try
                {
                    int num = 0;
                    for (int i = 0; i < Config.InternalIDDigitAmount; i++)
                        num = (num * 10) + 1;
                    byte[] temp = BitConverter.GetBytes(num);
                    int intID = BitConverter.ToInt32(picData.TakeLast(temp.Length).ToArray());
                    Array.Resize(ref picData, picData.Length - temp.Length);
                    Bitmap image = (Bitmap)new ImageConverter().ConvertFrom(picData);
                    if (image != null)
                    {
                        if (await IsFace(image))
                        {
                            image.Save(Config.FR_Images + $"\\{intID}{Config.ImageFormat}");
                            return "saved";
                        }
                        else return "Provided picture was not recognized as a valid picture of a face";
                    }
                    else return "Could not convert data recieved to image.";
                }
                catch (Exception ex) { return ex.Message; }
            }

            //Used for differentiating between faces and not faces
            async Task<bool> IsFace(Bitmap image)
            {
                //Save the image on the hardrive for Python process to read.
                image.Save(Config.RootDirectory + $"\\Is_Face{Config.ImageFormat}");

                // Set up the recognition process
                

                try
                {
                   
                    string[] output = new string[0];

                    //Create task for reading the Python's output
                    Task task = new Task(() =>
                    {
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.FileName = "python";
                        startInfo.Arguments = "Is_Face.py";
                        startInfo.UseShellExecute = false;
                        startInfo.RedirectStandardOutput = true;
                        startInfo.CreateNoWindow = false;
                        Process isFace = new Process() { StartInfo = startInfo };
                        isFace.Start();
                        output = isFace.StandardOutput.ReadToEnd().Replace("\r", "").Split('\n'); 
                    });
                    task.Start();
                    //Run new task that waits either for reading task to complete or timeout task to complete
                    if (await Task.WhenAny(task, Task.Delay(10000)) == task)
                    {
                        // task completed within timeout
                        int.TryParse(Array.Find(output, x => x.Parsable(typeof(int))), out int ammountOfFaces);
                        return ammountOfFaces == 1;
                    }
                    else
                    {
                        // timeout logic
                        return false;
                    }
                }
                catch { return false; }
                finally
                {
                    //Delete the image that was created
                    File.Delete(Config.RootDirectory + $"\\Is_Face{Config.ImageFormat}");
                    GC.Collect();
                }
            }
        }
    }
}
