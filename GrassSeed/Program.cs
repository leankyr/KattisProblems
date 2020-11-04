using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace GrassSeed
{
    class Program
    {

        static void Main(string[] args)
        {

            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/grassseed/2.in"))
            {
                string line;

                // Read and display lines from the file until 
                // the end of the file is reached. 
                line = sr.ReadLine();
                decimal C = decimal.Parse(line);
                line = sr.ReadLine();
                short L = Int16.Parse(line);
                //Console.WriteLine($"{C}");
                //Console.WriteLine($"{L}");

                decimal s = 0;
                for (short i = 0; i < L; i++)
                {
                    line = sr.ReadLine();
                    string[] split2 = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    decimal w = decimal.Parse(split2[0]);
                    decimal l = decimal.Parse(split2[1]);

                    s += w * l;
                }
                decimal FC = C * s;
                Console.Write($"{FC:0.00000000}");


                // check one side


            }

            Console.ReadKey();
        }
    }
}
