using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDODSolutionUsingInterfaces.Model
{
    internal class Mammal : ISpeakable
    {
        public void Speak()
        {
            Console.WriteLine("Mammal speaks.");
        }
    }
}
