using DeadlyDiamondOfDeathProblem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadlyDiamondOfDeathProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bat bat = new Bat();
            bat.Speak(); // Which Speak method should be called?
            bat.Fly();   // Calls Bird's Fly method, but which Speak method?
        }
    }
}
