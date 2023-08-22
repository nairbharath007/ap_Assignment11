using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDODSolutionUsingInterfaces.Model
{
    internal class Animal : ISpeakable
    {
        public void Speak()
        {
            Console.WriteLine("Animal speaks.");
        }
    }
}
