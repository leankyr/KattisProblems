using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWonders
{
    class Program
    {

        static void Main(string[] args)

        {
            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/sevenwonders/3.in"))
            {
                string line;


                line = sr.ReadLine();
                //Console.WriteLine(line);
                
                char[] input = line.ToCharArray();

                int sumTs = 0;
                int sumGs = 0;
                int sumCs = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == 'T')
                        sumTs += 1;
                    else if (input[i] == 'G')
                        sumGs += 1;
                    else
                        sumCs += 1;
                }

                int Points = sumTs * sumTs + sumCs * sumCs + sumGs * sumGs;

                int[] arr = { sumTs, sumGs, sumCs };

                int set = arr.Min();

                Points = Points + set * 7;

                Console.WriteLine(Points);
                Console.ReadKey();

            }



        }


    }
}
