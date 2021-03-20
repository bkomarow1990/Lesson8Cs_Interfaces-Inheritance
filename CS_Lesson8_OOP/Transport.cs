using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Lesson8_OOP
{
    abstract class Transport
    {
        public string Brand { get; set; }
        public abstract void Move();
        public abstract byte Places { get; }
        public Transport(string brand = "NoBrand")
        {
            Brand = brand;
        }
        public void Repair()  // non virtual
        {
            Console.WriteLine($"Repair {Brand}...");
        }
        public override string ToString()
        {
            return $"Brand : {Brand}, Places: {Places}";
        }
    }
    class Car : Transport
    {
        public double Power { get; set; }
        public Car(string brand="NoBrand", double power=0)
        :base(brand){
            Power = power;
        }
        public override void Move()
        {
            Console.WriteLine($"Car: '{Brand}' is moving by road");
        }
        public override byte Places => 4;
        public override string ToString()
        {
            return $"{this.GetType().Name} , Brand: {Brand}, Power {Power}, Places : {Places}";
        }
        public new void Repair()  // non virtual
        {
            Console.WriteLine($"Car repair {Brand}...");
        }
    }
}
