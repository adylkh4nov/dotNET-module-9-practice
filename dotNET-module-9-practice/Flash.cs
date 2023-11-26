using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_module_9_practice
{
    public class Flash : Storage
    {
        private double usbSpeed;
        private double memorySize;

        public double USB3Speed { get => usbSpeed; set => usbSpeed = value; }
        public double MemorySize { get => memorySize; set => memorySize = value; }

        public override double GetStorageVolume()
        {
            return memorySize;
        }

        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Copying data of size {dataSize} GB to Flash drive...");
        }

        public override double GetFreeSpace()
        {
           
            return 0; 
        }

        public override void GetDeviceInfo()
        {
            Console.WriteLine($"Flash Drive - Name: {Name}, Model: {Model}, USB 3.0 Speed: {usbSpeed} MB/s, Memory Size: {memorySize} GB");
        }
    }

    public class DVD : Storage
    {
        private double readWriteSpeed;
        private string type;

        public double ReadWriteSpeed { get => readWriteSpeed; set => readWriteSpeed = value; }
        public string Type { get => type; set => type = value; }

        public override double GetStorageVolume()
        {
            return type == "односторонний" ? 4.7 : 9; 
        }

        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Copying data of size {dataSize} GB to DVD...");
        }

        public override double GetFreeSpace()
        {
            
            return 0; 
        }

        public override void GetDeviceInfo()
        {
            Console.WriteLine($"DVD - Name: {Name}, Model: {Model}, Read/Write Speed: {readWriteSpeed} MB/s, Type: {type}");
        }
    }

    public class HDD : Storage
    {
        private double usbSpeed;
        private int partitions;
        private double partitionSize;

        public double USB2Speed { get => usbSpeed; set => usbSpeed = value; }
        public int Partitions { get => partitions; set => partitions = value; }
        public double PartitionSize { get => partitionSize; set => partitionSize = value; }

        public override double GetStorageVolume()
        {
            return partitions * partitionSize;
        }

        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Copying data of size {dataSize} GB to HDD...");
        }

        public override double GetFreeSpace()
        {
            
            return 0; 
        }

        public override void GetDeviceInfo()
        {
            Console.WriteLine($"HDD - Name: {Name}, Model: {Model}, USB 2.0 Speed: {usbSpeed} MB/s, Partitions: {partitions}, Partition Size: {partitionSize} GB");
        }
    }

}
