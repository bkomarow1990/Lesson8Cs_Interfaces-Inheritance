using System;

namespace HW_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Comp comp = new Comp(new HDD("Hello", 1), new Monitor());
            //Monitor monik = new Monitor();
            //Console.WriteLine(monik.GetType().Name);
            comp.AddDisk(new Flash("Lesson SS",2 ));

            comp.PrintInfo("Lalala", "Monitor");
        }
    }
}
