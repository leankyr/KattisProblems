using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingForCarrots
{
    class Program
    {
        
        static void Main(string[] args)
        
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("C:/Users/leankyr/Downloads/carrots/carrots.01.in"))
                {
                    string line;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    line = sr.ReadLine();
                    
                    string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    long N = Int64.Parse(split[0]);
                    long P = Int64.Parse(split[1]);
                        
                    Console.WriteLine($"{N} {P}");

                    for (int i = 0; i < N; i++){
                        line = sr.ReadLine();
                        Console.WriteLine(line);





                    }
                    Console.WriteLine(P);

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