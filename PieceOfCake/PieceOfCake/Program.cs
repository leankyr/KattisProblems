using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace PieceOfCake
{
    class Program
    {

        static void Main(string[] args)

        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/pieceofcake2/3.in"))
                {
                    string line;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    line = sr.ReadLine();


                    string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    uint n = UInt32.Parse(split[0]);
                    uint h = UInt32.Parse(split[1]);
                    uint v = UInt32.Parse(split[2]);
                    //Console.WriteLine($"{n}");
                    //Console.WriteLine($"{h}");
                    //Console.WriteLine($"{v}");

                    // check one side
                    uint bv, bh;
                    if (h >= (float)n / 2) {
                        bh = h;
                    }
                    else
                    {
                        bh = n - h;
                    }

                    // check other side
                    if (v >= (float) n / 2)
                    {
                        bv = v;
                    }
                    else
                    {
                        bv = n - v;
                    }

                    uint V = bv * bh * 4;
                    Console.WriteLine($"{V}");


                    // Start Solving

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

