using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadlyDiamondOfDeathProblem.Model
{
    internal class Bird : Animal
    {
        public void Speak()
        {
            Console.WriteLine("Bird speaks.");
        }

        public void Fly()
        {
            Console.WriteLine("Bird flies.");
        }
    }
}
