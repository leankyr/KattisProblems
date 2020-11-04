using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NastyHacks
{
    class Program
    {

        static void Main(string[] args)

        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/nastyhacks/1.in"))
                {
                    string line;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    line = sr.ReadLine();


                    string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    uint N = UInt32.Parse(split[0]);
                    // Console.WriteLine($"{N}");

                    for (short i = 0; i < N; i++) 
                    {   line = sr.ReadLine();
                        string[] split2 = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                        int r = Int32.Parse(split2[0]);
                        int e = Int32.Parse(split2[1]);
                        int c = Int32.Parse(split2[2]);
                        //Console.WriteLine($"{r}");
                        //Console.WriteLine($"{e}");
                        //Console.WriteLine($"{c}");

                        if (e - c > r)
                        {
                            Console.WriteLine("advertise");
                        }
                        else if (e - c == r)
                        {
                            Console.WriteLine("does not matter");
                        }
                        else
                        {
                            Console.WriteLine("do not advertise");
                        }



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

