using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanukahChallenge
{
    class Program
    {

        static void Main(string[] args)

        {
            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/chanukah/sample01.in"))
            {
                string line;

                // Read and display lines from the file until 
                // the end of the file is reached. 
                line = sr.ReadLine();


                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                short P = short.Parse(split[0]);
                //Console.WriteLine($"{days}");
               
                for (short i = 0; i < P; i++)
                {
                    line = sr.ReadLine();
                    string[] split2 = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    short K = short.Parse(split2[0]);
                    short N = short.Parse(split2[1]);
                    //Console.WriteLine($"{K} {N}");
                    int numDays = 0;
                    for (short j = 1; j <= N; j++) 
                    {
                        numDays += j;
                    }
                    numDays += N;
                    Console.WriteLine($"{K} {numDays}");



                }
                Console.ReadKey();


            }

        }


    }
}
