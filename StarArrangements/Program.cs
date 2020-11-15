using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Diagnostics.SymbolStore;

namespace StarArrangemets
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/stararrangements/stararrangements-0000.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                int S = int.Parse(split[0]);

                

                



                Console.ReadKey();

            }

        }


    }



}
