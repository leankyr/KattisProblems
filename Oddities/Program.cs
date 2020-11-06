using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    class Program
    {

        static void Main(string[] args)

        {
            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/oddities/sample.in"))
            {
                string line;
                line = sr.ReadLine();


                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                byte t = byte.Parse(split[0]);



                for (byte i = 0; i < t; i++)
                {
                    line = sr.ReadLine();
                    split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    short n = short.Parse(split[0]);

                    if (n % 2 == 0)
                        Console.WriteLine($"{n} is even");
                    else
                        Console.WriteLine($"{n} is odd");

                }
                Console.ReadKey();
            }
        }

    }
}
