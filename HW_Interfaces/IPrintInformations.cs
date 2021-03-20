using System;
using System.Collections.Generic;
using System.Text;

namespace HW_Interfaces
{
    interface IPrintInformation
    {
        string GetName();
        void Print(string str);
    }
    class Printer : IPrintInformation
    {
        public string GetName()
        {
            return this.GetType().Name;
        }

        public void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
    class Monitor : IPrintInformation
    {
        public string GetName()
        {
            return this.GetType().Name;
        }

        public void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
