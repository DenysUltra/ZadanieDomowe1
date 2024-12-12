using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaniedomowe1
{
    internal class Devices
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Status { get; set; }
        public string DeviceID { get; set; }

        public Devices(string name, string manufacturer, string status, string deviceId)
        {
            Name = name;
            Manufacturer = manufacturer;
            Status = status;
            DeviceID = deviceId;
        }
    }
}
