using System;
using System.Collections.Generic;
using System.Text;

namespace HW_Interfaces
{
    interface IRemoveableDisk
    {
        bool HasDisk { get; }
        void Insert();
        void Reject();
    }
}
