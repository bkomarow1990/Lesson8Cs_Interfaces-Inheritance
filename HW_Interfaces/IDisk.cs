using System;
using System.Collections.Generic;
using System.Text;

namespace HW_Interfaces
{
    interface IDisk
    {
        string Read();
        void Write(string text);
    }
}
