using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Faktor
{
    class Program
    {

        static void Main(string[] args)

        {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/faktor/faktor.dummy.3.in"))
                {
                    string line;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    line = sr.ReadLine();


                    string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    uint A = UInt32.Parse(split[0]);
                    double I = double.Parse(split[1]);
                    
                    //Console.WriteLine($"{A}");
                    //Console.WriteLine($"{I}");

                    I = I - 0.99;

                    double F = I * A;
                    F = Math.Ceiling(F);

                    Console.WriteLine($"{F}");

                    Console.ReadKey();


                }

        }
            
         
    }
}
