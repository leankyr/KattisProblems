using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aaah
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/aaah/aaah.2.in"))
            {
                string line1 = sr.ReadLine();
                string line2 = sr.ReadLine();

                if (line1.Length < line2.Length)
                    Console.WriteLine("no");
                else
                    Console.WriteLine("go");

                Console.ReadKey();

            }
        }

    }
}