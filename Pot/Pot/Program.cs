using System;
using System.IO;
using System.Xml.Schema;
using System.Text;
using Microsoft.Win32;

namespace Pot
{
    class Program
    {

        static void Main(string[] args)

        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/pot/pot.3.in"))
                {
                    string line;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    line = sr.ReadLine();


                    string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    double N = Int64.Parse(split[0]);

                    //Console.WriteLine($"{N}");
                    double sum = 0;
                    for (int i = 0; i < N; i++)
                    {
                        string line2;
                        line2 = sr.ReadLine();
                        string[] split2 = line2.Split(new char[] { ' ' }, StringSplitOptions.None);
                        string input = split2[0];
                                              
                        string power = String.Empty;
                        power = input.Substring(input.Length - 1); // cause it returns a new string
                        double p = Int32.Parse(power); 
                        //Console.WriteLine($"{power}");
                        
                        string Base = String.Empty;
                        Base = input.Remove(input.Length - 1, 1);
                        double b = Int32.Parse(Base);
                        //Console.WriteLine($"{Base}");

                        sum = sum + Math.Pow(b, p); // Math returns a double this is where the prob was




                    }
                   Console.WriteLine($"{sum}");
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
