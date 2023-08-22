using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Model
{
    internal abstract class Shape
    {
        public string Name { get; }

        public Shape(string name)
        {
            Name = name;
        }

        // Abstract method to calculate area (forces implementation in derived classes)
        public abstract double CalculateArea();

        public void DisplayInfo()
        {
            Console.WriteLine($"This is a {Name}");
        }
    }
}
