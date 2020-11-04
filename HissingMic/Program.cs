using System;
using System.IO;

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
                using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/hissingmicrophone/hissingmicrophone-02.in"))
                {
                    string line;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    line = sr.ReadLine();
                    //Console.WriteLine(line);

                    if (line.Contains("ss"))
                    {
                        Console.WriteLine("hiss");
                    }
                    else
                    {
                        Console.WriteLine("no hiss");
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
