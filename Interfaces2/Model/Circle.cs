using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2.Model
{
    internal class Circle : IDrawable, ICalculable
    {
        private double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing a circle with radius {Radius}...");
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
