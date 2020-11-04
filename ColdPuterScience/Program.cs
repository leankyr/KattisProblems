using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColdPuterScience
{
    class Program
    {

        static void Main(string[] args)

        {
            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/cold/cold-002.in"))
            {
                string line;

                // Read and display lines from the file until 
                // the end of the file is reached. 
                line = sr.ReadLine();


                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                byte days = byte.Parse(split[0]);
                //Console.WriteLine($"{days}");
                line = sr.ReadLine();

                int numDays = 0;
                for (byte i=0; i < days; i++)
                {
                    string[] split2 = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    float temp = float.Parse(split2[i]);
                    if (temp < 0)
                        numDays += 1;
                }


                Console.WriteLine($"{numDays}");
                Console.ReadKey();


            }

        }


    }
}
