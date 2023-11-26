using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_module_9_practice
{
    public abstract class Storage
    {
        private string name;
        private string model;

        public string Name { get => name; set => name = value; }
        public string Model { get => model; set => model = value; }

        public abstract double GetStorageVolume();

        public abstract void CopyData(double dataSize);

        public abstract double GetFreeSpace();

        public abstract void GetDeviceInfo();
    }

}
