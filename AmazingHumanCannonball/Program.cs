using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazingHumanCannonball
{
    class Program
    {

        static void Main(string[] args)

        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/amazinghumancannonball2/test0.in"))
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
                        double v0 = double.Parse(split2[0]);
                        double th = (Math.PI/180) * double.Parse(split2[1]);
                        double x1 = double.Parse(split2[2]);
                        double h1 = double.Parse(split2[3]);
                        double h2 = double.Parse(split2[4]);

                        double t;



                        t = x1 /(v0 * Math.Cos(th));

                        //Console.WriteLine(Math.Cos(th));

                        double y = v0 * t * Math.Sin(th) - 0.5*9.81*t*t;

                        //Console.WriteLine(y);

                        if (y >= h1 + 1 && y <= h2 - 1)
                            Console.WriteLine("Safe");
                        else
                            Console.WriteLine("Not Safe");
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

