using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {

        static void Main(string[] args)

        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/fizzbuzz/fizzbuzz-01.in"))
                {
                    string line;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    line = sr.ReadLine();


                    string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    uint X = UInt32.Parse(split[0]);
                    uint Y = UInt32.Parse(split[1]);
                    uint N = UInt32.Parse(split[2]);
                    Console.WriteLine($"{X}");
                    Console.WriteLine($"{Y}");
                    Console.WriteLine($"{N}");



                    for (short i = 1; i <=N; i++)
                    {

                        if (i % X == 0 && i % Y == 0)
                        {
                            Console.WriteLine("FizzBuzz");
                        }
                        else if (i % Y == 0)
                        {
                            Console.WriteLine("Buzz");
                        }
                        else if (i % X == 0)
                        {
                            Console.WriteLine("Fizz");
                        }
                        else
                            Console.WriteLine($"{i}");

                    }

                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
