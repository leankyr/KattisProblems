using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Diagnostics.SymbolStore;

namespace ARealChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/areal/2.in"))
            {
                string line = sr.ReadLine();
                double a = double.Parse(line);

                double s = Math.Sqrt(a);
                    
                Console.WriteLine(4*s);
            }


                Console.ReadKey();

            

        }
    }
}