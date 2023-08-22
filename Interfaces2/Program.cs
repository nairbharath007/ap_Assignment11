using Interfaces2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDrawable circle = new Circle(5.0);
            circle.Draw();
            Console.WriteLine();

            IDrawable rect = new Rectangle(4.0, 6.0);
            rect.Draw();
            Console.WriteLine();

            ICalculable rectangle = new Rectangle(4.0, 6.0);
            Console.WriteLine($"Area of Rectangle: {rectangle.CalculateArea()}");
            Console.WriteLine();

            ICalculable circ = new Circle(5.0);
            Console.WriteLine($"Area of Rectangle: {circ.CalculateArea()}");
            Console.WriteLine();


        }
    }
}
