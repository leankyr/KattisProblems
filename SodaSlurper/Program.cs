using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Diagnostics.SymbolStore;

namespace SodaSluper
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/sodaslurper/2.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                int e = int.Parse(split[0]);
                int f = int.Parse(split[1]);
                int c = int.Parse(split[2]);

                int T = e + f;


                int s = 0;
                while (T/c>0)
                {
                    int d = T / c;
                    f = T % c;
                    T = d + f;
                    s += d; 
                }
                
                Console.WriteLine($"{s}");
                Console.ReadKey();

            }

        }


    }



}