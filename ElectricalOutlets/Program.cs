using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalOutlets
{
    class Program
    {

        static void Main(string[] args)

        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/electricaloutlets/1.in"))
                {
                    string line;
                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    line = sr.ReadLine();
                    string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    uint N = UInt32.Parse(split[0]);
                    //Console.WriteLine($"{N}");
                    


                    for (short j = 0; j < N; j++)
                    {
                        line = sr.ReadLine();
                        string[] split2 = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                        uint K = uint.Parse(split2[0]);
                        uint[] O = new uint[K];
                        uint outlets = 0;
                        for (short i = 0; i < K; i++)
                        {
                            O[i] = uint.Parse(split2[i+1]);
                            //Console.WriteLine(O[i]);
                            outlets += O[i];
                            //Console.WriteLine(outlets);

                        }
                        outlets = outlets -K + 1;
                        Console.WriteLine(outlets);
                    }


            }   }
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

