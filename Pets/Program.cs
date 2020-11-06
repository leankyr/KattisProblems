using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShatteredCake
{
    class Program
    {

        static void Main(string[] args)

        {
            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/pet/pet.2.in"))
            {
                string line;

                int max = 0;
                int index = 0;
                for (int i = 0; i < 5; i++)
                {
                    int sum = 0;
                    line = sr.ReadLine();
                    string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);



                    sum = int.Parse(split[0]) + int.Parse(split[1]) + int.Parse(split[2]) + int.Parse(split[3]);

                    if (sum > max)
                    {
                        max = sum;
                        index = i;
                    }


                }
                Console.WriteLine($"{index + 1} {max}");
                Console.ReadKey();
                


            }

        }


    }
}