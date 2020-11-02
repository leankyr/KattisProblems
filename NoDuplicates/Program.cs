using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Security.Policy;

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
                using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/nodup/3.in"))
                {
                    string line;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    line = sr.ReadLine();
                   // Console.WriteLine(line);

                    string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    bool f = false;
                    foreach (var word in split)
                    {
                        // System.Console.WriteLine($"{word}");

                        var num = split.Count(s => s == word); // This is Linq... Guess I need to learn
                      
                        if (num > 1)
                        {
                            f = true;
                            break;
                        }
                    }

                    if (f)
                    {
                        Console.WriteLine("no");
                    }
                    else {
                        Console.WriteLine("yes");
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

