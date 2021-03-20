using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HW_Interfaces
{
    class Comp
    {
        private int countDisk;
        private int countPrintDevices;
        private List<Disk> disks = new List<Disk>();
        private List<IPrintInformation> print_devices=new List<IPrintInformation>();
        public void AddDeviceWithIndex(int index, IPrintInformation si) {
            if (si == null)
            {
                throw new Exception("PrintInformation device is empty!");
            }
            if (index < 0 || index>= print_devices.Count)
            {
                throw new Exception("Incorrect index");
            }
            print_devices.Insert(index, si);
            ++countPrintDevices;
        }
        public void AddDiskWithIndex(int index, Disk d)
        {
            if (d == null)
            {
                throw new Exception("PrintInformation device is empty!");
            }
            if (index < 0 || index >= disks.Count)
            {
                throw new Exception("Incorrect index");
            }
            disks.Insert(index, d);
            ++countDisk;
        }
        public bool CheckDisk(string name)
        {
            var it=disks.Find(e => e.GetName() == name);
            if (it != null)
            {
                return true;
            }
            return false;
        }
        public void AddDevice(IPrintInformation device)
        {
            if (device == null)
            {
                throw new Exception("Device is Null");
            }
            this.print_devices.Add(device);
        }
        public void AddDisk(Disk disk)
        {
            if (disk == null)
            {
                throw new Exception("Device is Null");
            }
            this.disks.Add(disk);
        }
        void InsertReject(string device, bool b)
        {
            var it = disks.Find(e => e.GetName() == device);
            if (it == null)
            {
                Console.WriteLine("Disk haven`t");
                return;
            }
            if (!(it is IRemoveableDisk))
            {
                Console.WriteLine("Device isn`t Removable");
                return;
            }
            IRemoveableDisk irdisk = it as IRemoveableDisk;
            if (b == true)
            {
                irdisk.Insert();
            }
            else {
                irdisk.Reject();
            }
        }
        public bool PrintInfo(string text, string device) {
            var it = print_devices.Find(e => e.GetName() == device);
            if (it == null)
            {
                Console.WriteLine("Device haven`t");
                return false;
            }
            if (!(it is Monitor))
            {
                Console.WriteLine("Isn`t Monitor device, (it`s Printer)");
                return false;
            }
            it.Print(text);
            return true;
        }
        public bool WriteInfo(string text, string device) {
            var it = print_devices.Find(e => e.GetName() == device);
            if (it != null)
            {
                Console.WriteLine("Device haven`t");
                return false;
            }
            if (!(it is Printer))
            {
                Console.WriteLine("Isn`t Printer device, (it`s Monitor)");
                return false;
            }
            it.Print(text);
            return true;
        }
        public string ReadInfo(string device) {
            var it = disks.Find(e => e.GetName() == device);
            if (it != null)
            {
                Console.WriteLine("Device haven`t");
                return String.Empty;
            }
            return it.Memory;
        }
        public void ShowDisk(){
            foreach (var item in disks)
            {
                Console.WriteLine(item);
            }
        }
        public void ShowPrintDevice()
        {
            foreach (var item in print_devices)
            {
                Console.WriteLine($"Print Device: {item.GetName()}");
            }
        }
        public Comp(Disk d, IPrintInformation pd)
        {
            AddDisk(d);
            AddDevice(pd);
            
        }
        public Comp()
        {

        }
    }
}
