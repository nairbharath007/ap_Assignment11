using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2.Model
{
    internal class Rectangle : IDrawable, ICalculable
    {
        private double Width { get; }
        private double Height { get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing a rectangle with width {Width} and height {Height}...");
        }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }
}
