using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planina
{
    class Program
    {

        static void Main(string[] args)

        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/planina/planina.3.in"))
                {
                    string line;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    line = sr.ReadLine();


                    string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    double N = Int64.Parse(split[0]);
                    Console.WriteLine($"{N}");

                    // Start Solving
                    // Side is  the dots on the side of the square
                    double Side = 2;
                    for (int i = 0; i < N; i++) 
                    {
                        Side = Side + Math.Pow(2, i);
                    }
                    Console.WriteLine($"{Math.Pow(Side, 2)}");



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

