using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Demo
{
    interface IFly : IMove
    {
        void Fly();
        ushort Height { get; set; }
    }
}
