using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuckInATimeLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/timeloop/b.in"))
            {
                string line;
                line = sr.ReadLine();

                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                uint N = UInt32.Parse(split[0]);
                // Console.WriteLine($"{N}");

                for (short i = 0; i < N; i++)
                    Console.WriteLine($"{i + 1} {"Abracadabra"}");

                Console.ReadKey();
            }
        }
    }
}
