using System;
using System.Collections.Generic;
using System.Text;

namespace HW_Interfaces
{
    abstract class Disk : IDisk
    {
        string memory;
        int mem_size;
        string name;
        public string Memory
        {
            get => memory;
            set
            {
                this.memory = value;
            }
        }

        public int MemSize
        {
            get => mem_size;
            set
            {
                this.mem_size = value;
            }
        }
        public virtual string GetName()
        {
            return this.GetType().Name;
        }

        public string Read()
        {
            return memory;
        }

        public void Write(string text)
        {
            memory += text;
            ++mem_size;
        }
        // Я думав як зробити name, і по умові зробив що він віртуальний і повертає GetType
        public Disk(string memory = "NoMemory", int memorysize = 1)
        {
            Memory = memory;
            MemSize = memorysize;
        }
        public override string ToString()
        {
            return $"Disk\nName:{GetName()}, Memory: {Memory}, MemorySize: {MemSize}"; 
        }
    }
    class CD : Disk, IRemoveableDisk
    {
        public CD(string memory = "NoMemory", int memorysize = 1)
        : base(memory, memorysize)
        {

        }

        public bool HasDisk
        {
            get; set;
        }

        public void Insert()
        {
            HasDisk = true;
        }

        public void Reject()
        {
            HasDisk = false;
        }
        public override string GetName()
        {
            return this.GetType().Name;
        }
    }
    class Flash : Disk, IRemoveableDisk
    {
        public Flash(string memory = "NoMemory", int memorysize = 1)
        : base(memory, memorysize)
        {

        }

        public bool HasDisk
        {
            get; set;
        }

        public void Insert()
        {
            HasDisk = true;
        }

        public void Reject()
        {
            HasDisk = false;
        }
        public override string GetName()
        {
            return this.GetType().Name;
        }
    }
    class HDD : Disk
    {
       public HDD(string memory = "NoMemory", int memorysize = 1)
         :base(memory, memorysize)
        {

        }
        public override string GetName()
        {
            return this.GetType().Name;  
        }
    }
    class DVD : Disk, IRemoveableDisk
    {
        public DVD(string memory = "NoMemory", int memorysize = 1)
        : base(memory, memorysize)
        {

        }

        public bool HasDisk
        {
            get; set;
        }

        public void Insert()
        {
            HasDisk = true;
        }

        public void Reject()
        {
            HasDisk = false;
        }
        public override string GetName()
        {
            return this.GetType().Name;
        }
    }
}
