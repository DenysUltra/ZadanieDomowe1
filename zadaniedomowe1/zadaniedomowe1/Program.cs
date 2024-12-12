using System;
using System.Collections.Generic;
using System.Management;

namespace USBDeviceInfo
{

    public interface IUSBDevice
    {
        string DeviceID { get;  }
        string Description { get;}
        string Manufacturer { get; }
    }


    public class USBDevice : IUSBDevice
    {
        public string DeviceID { get; private set; }
        public string Description { get; private set; }
        public string Manufacturer { get; private set; }

        public USBDevice(string deviceId, string description, string manufacturer)
        {
            DeviceID = deviceId;
            Description = description;
            Manufacturer = manufacturer;
        }

        public override string ToString()
        {
            return $"DeviceID: {DeviceID}\nDescription: {Description}\nManufacturer: {Manufacturer}\n";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Connected USB devices:");
            List<IUSBDevice> usbDevices = GetUSBDevices();

            if (usbDevices.Count == 0)
            {
                Console.WriteLine("There are no USB devices connected.");
            }
            else
            {
                foreach (var device in usbDevices)
                {
                    Console.WriteLine(device);
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }


        static List<IUSBDevice> GetUSBDevices()
        {
            List<IUSBDevice> devices = new List<IUSBDevice>
            {
                new USBDevice("USB\\VID_1234&PID_5678", "USB Flash Drive", "Generic Manufacturer"),
                new USBDevice("USB\\VID_8765&PID_4321", "USB Keyboard", "Keyboard Inc."),
                new USBDevice("USB\\VID_1111&PID_2222", "USB Mouse", "Mouse Co.")
            };

            return devices;
        }
    }
}


