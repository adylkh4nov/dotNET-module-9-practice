using dotNET_module_9_practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Storage[] devices = new Storage[3];

            
            devices[0] = new Flash { Name = "FlashDrive", Model = "Supra", USB3Speed = 100, MemorySize = 64 };
            devices[1] = new DVD { Name = "DVD", Model = "Corolla", ReadWriteSpeed = 10, Type = "Цветной" };
            devices[2] = new HDD { Name = "HDD", Model = "S500", USB2Speed = 50, Partitions = 2, PartitionSize = 500 };

            
            CalculateTotalMemory(devices);
            CopyDataToDevice(devices, 565); 

            

            Console.ReadKey();
        }

        static void CalculateTotalMemory(Storage[] devices)
        {
            double totalMemory = 0;
            foreach (var device in devices)
            {
                totalMemory += device.GetStorageVolume();
            }
            Console.WriteLine($"Total memory of all devices: {totalMemory} GB");
        }

        static void CopyDataToDevice(Storage[] devices, double dataSize)
        {
            foreach (var device in devices)
            {
                device.CopyData(dataSize);
            }
        }
    }

}
