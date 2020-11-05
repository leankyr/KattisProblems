using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatterUp
{
    class Program
    {

        static void Main(string[] args)

        {
            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/batterup/3.in"))
            {
                string line;

                // Read and display lines from the file until 
                // the end of the file is reached. 
                line = sr.ReadLine();


                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                byte n = byte.Parse(split[0]);
                //Console.WriteLine($"{n}");
                line = sr.ReadLine();

                int nom = 0;
                int denom = n;
                for (byte i = 0; i < n; i++)
                {
                    string[] split2 = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    int bats = int.Parse(split2[i]);
                    //Console.WriteLine($"{bats}");

                    if (bats >= 0)
                        nom += bats;
                    else
                        denom -= 1;
                }

                //Console.WriteLine($"{nom}");
                Console.WriteLine($"{(decimal)nom/denom:0.00000000000000000}");

                Console.ReadKey();

            }


        }


    }
}