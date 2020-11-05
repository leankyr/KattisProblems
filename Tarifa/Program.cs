using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarifa
{
    class Program
    {

        static void Main(string[] args)

        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/tarifa/tarifa.1.in"))
                {
                    string line;
                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    line = sr.ReadLine();
                    string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    int X = Int32.Parse(split[0]);
                    line = sr.ReadLine();
                    string[] split2 = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    int N = Int32.Parse(split2[0]);



                   
                    int[] P = new int[N];
                    for (short i = 0; i < N; i++) 
                    {   

                        line = sr.ReadLine();
                        string[] split3 = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                        P[i] = int.Parse(split3[0]);

                    }
                    int remainingMegs = (N + 1) * X - P.Sum();
                    Console.WriteLine(remainingMegs);




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

