using System;

namespace Interface_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new Duck() { Height = 180};
            duck.Fly();
            duck.Move();
            Console.WriteLine("Hello World!");
            IFly ifl = duck;
            ifl.Move();
            MandarinDuck mDuck = new MandarinDuck();
            mDuck.Move();
            mDuck.Fly();
        }
    }
}
