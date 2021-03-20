using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Demo
{
    class Duck : IFly, ISwim
    {
        const ushort MaxHeight = 200;
        public void Move()
        {
            Console.WriteLine("Duck moved on land");
        }
        void ISwim.Move() {
            Console.WriteLine("Duck is Swimming");
        }
        public virtual void Fly()
        {
            Console.WriteLine("Duck is flying");
        }
        private ushort height; // full property
        public ushort Height
        {
            get => height;
            set
            {
                if (value < MaxHeight )
                {
                    this.height = value;
                }
                this.height = value;
            }
        }
    }
}
