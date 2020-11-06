using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/railroad2/sample003.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                short X = short.Parse(split[0]);
                short Y = short.Parse(split[1]);

                if ((4 * X + 3 * Y) % 2 == 0)
                    Console.WriteLine("possible");
                else
                    Console.WriteLine("impossible");

                Console.ReadKey();

            }
        }
    }
}
