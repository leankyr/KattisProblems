using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romans
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/romans/t1.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                decimal X = decimal.Parse(split[0]);

                //Console.WriteLine($"{X}");

                decimal R = X * 1000 * 5280 / 4854;

                R = Math.Round(R,0);
                Console.WriteLine($"{R}");

                

                Console.ReadKey();
            }
        }
    }
}

