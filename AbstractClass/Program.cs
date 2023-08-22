using AbstractClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle("Circle", 5.0);
            Shape rectangle = new Rectangle("Rectangle", 4.0, 6.0);

            circle.DisplayInfo();
            Console.WriteLine($"Area of {circle.Name}: {circle.CalculateArea()}");

            rectangle.DisplayInfo();
            Console.WriteLine($"Area of {rectangle.Name}: {rectangle.CalculateArea()}");

        }
    }
}
