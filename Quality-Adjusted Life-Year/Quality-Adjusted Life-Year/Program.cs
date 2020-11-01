using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace Quality_Adjusted_Life_Year
{
    class Program
    {

        static void Main(string[] args)

        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("C:/Users/leankyr/Downloads/qaly/1.in"))
                {
                    string line;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    line = sr.ReadLine();


                    string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    long N = Int64.Parse(split[0]);

                    // Console.WriteLine($"{N}");
                    decimal qaly = 0;
                    for (int i = 0; i < N; i++)
                    {
                        string line2;
                        line2 = sr.ReadLine();
                        string[] split2 = line2.Split(new char[] { ' ' }, StringSplitOptions.None);
                        decimal q = decimal.Parse(split2[0]);
                        decimal y = decimal.Parse(split2[1]);

                        // Console.WriteLine($"{q} {y}");

                        qaly = qaly + q * y;




                    }
                    Console.WriteLine($"{qaly:0.000}");
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