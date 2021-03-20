using System;
using System.Collections.Generic;
using System.Text;

namespace Practic
{
 //   1. Створити базовий клас Shape.
	//Визначити у класі віртуальну властивість для читання Square(повернути 0).
	//Визначити у класі віртуальний метод Print()(вивести назву фігури та її площу).
 // Створити клас Circle, похідний від  класу Shape.
	//Визначити у класі поле radius
	//Перевизначити у класі віртуальну властивість для читання Square(повернути pi * r * r).
	//Перевизначити у класі віртуальний метод Print()(вивести назву фігури та її площу).
 //Створити клас Rectangle, похідний від  класу Shape.
	//Визначити у класі поля висота та ширина.
	//Перевизначити у класі віртуальну властивість для читання Square(ширина* висота).
	//Перевизначити у класі віртуальний метод Print()(вивести назву фігури та її площу)

	abstract class Shape
    {
        public virtual double Square
        {
			get;
        }
		public Shape() { }
		public abstract void Print();


    }
	class Circle : Shape
    {
		const double PI = 3.14;
		private int radius;
		public int Radius {
			get => radius;
            set
            {
				this.radius = value;
            }
		}
        public override double Square => PI * radius * radius;
        public override void Print()
        {
            Console.WriteLine($"Square\nRadius:{radius}, Square:{Square}");
        }
        public Circle(int radius)
        {
			Radius = radius;
        }
    }
	class Rectangle : Shape{
		private int width;
		private int height;
		public int Width
        {
			get => width;
            set
            {
				this.width = value;
            }
        }
		public int Height
		{
			get => height;
			set
			{
				this.height = value;
			}
		}
        public Rectangle(int width, int height)
        {
			Width = width;
			Height = height;
        }
        public override double Square => Width * height;
        public override void Print()
        {
			Console.WriteLine($"Rectangle\nWidth:{width}, Height: {height}, Square:{Square}");
		}
    }
}
