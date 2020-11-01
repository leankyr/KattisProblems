using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R2
{
    class Program
    {
        static void Main(string[] args)

        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("C:/Users/leankyr/Downloads/r2/1.in"))
                {
                    string line;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    line = sr.ReadLine();

                    string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    long R1 = Int64.Parse(split[0]);
                    long S = Int64.Parse(split[1]);

                    long R2 = 2 * S - R1;
                    Console.WriteLine($"{R1} {S} {R2}");

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
