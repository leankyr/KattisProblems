using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Diagnostics.SymbolStore;

namespace Quadrant
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/quadrant/1.in"))
            {
                string line = sr.ReadLine();
                int X = int.Parse(line);
                line = sr.ReadLine();
                int Y = int.Parse(line);

                if (X > 0 && Y > 0)
                    Console.WriteLine('1');
                else if (X < 0 && Y > 0)
                    Console.WriteLine('2');
                else if (X < 0 && Y < 0)
                    Console.WriteLine('3');
                else
                    Console.WriteLine('4');
                Console.ReadKey();

            }

        }
    }
}