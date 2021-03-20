using System;
using System.Linq;
using System.Collections.Generic;

namespace Practic
{
    class Program
    {
        static void printList(List<Shape> list)
        {
            foreach (var item in list)
            {
                item.Print();
            }
        }
        static void Main(string[] args)
//            Створити для перевірки список(List<> ) з фігур.Помістити у список різного типу фігури.
//   Вивести інформацію про всі фігури
//   Впорядкувати список фігур за зростанням площ фігур.

//   Зібрати фігури, що є колами у окремий список(FindAll)

//2. Змінити попередню реалізацію завдання 1. Визначити клас Shape як абстрактний.
//   Властивість Square та метод  Print() визначити як абстрактні.
        
        {
            Rectangle rectangle = new Rectangle(2,3);
            Circle circle = new Circle(2);
            rectangle.Print();
            circle.Print();
            Console.WriteLine("Hello World!");
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle(21));
            shapes.Add(new Rectangle(12,88));
            shapes.Add(rectangle);
            shapes.Add(new Circle(22));
            shapes.Add(circle);
            

            shapes.Sort((e, e2) =>  e.Square.CompareTo(e2.Square));
            printList(shapes);
            var circles = shapes.FindAll(e => e.GetType().Name == "Circle");
            Console.WriteLine("Only circles");
            printList(circles);
        }
    }
}
