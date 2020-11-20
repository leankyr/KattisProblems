using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Diagnostics.SymbolStore;

namespace MixedFractions
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/mixedfractions/data.in"))
            {
                while (true)
                {
                    string line = sr.ReadLine();
                    string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    int N = int.Parse(split[0]);
                    int D = int.Parse(split[1]);

                    if (N == 0 && D == 0)
                        break;

                    int W = N / D;
                    int mod = N % D;

                    Console.WriteLine($"{W} {mod} {"/"} {D}");

                }

                

            }
            Console.ReadKey();
        }
    }
}