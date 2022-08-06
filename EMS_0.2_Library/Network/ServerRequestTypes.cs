using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_Library.Network
{
    public class RequestType
    {
        public static RequestType Data => new RequestType("Data");
        public static RequestType Ping => new RequestType("Ping");
        public static RequestType Done => new RequestType("Done");
        private string _type;

        private RequestType(string type) => _type = type;
    }
}
