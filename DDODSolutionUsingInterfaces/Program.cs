using DDODSolutionUsingInterfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDODSolutionUsingInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bat bat = new Bat();
            bat.Speak(); // Calls Bat's Speak method
            Console.WriteLine();
            bat.Fly();   // Calls Bat's Fly method
            Console.WriteLine();

        }
    }
}
