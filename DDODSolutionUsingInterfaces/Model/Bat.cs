using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDODSolutionUsingInterfaces.Model
{
    internal class Bat : ISpeakable, IFlyable
    {
        public void Speak()
        {
            Console.WriteLine(" Bat speaks.");
        }

        public void Fly()
        {
            Console.WriteLine(" Bat flies.");
        }
    }
}
