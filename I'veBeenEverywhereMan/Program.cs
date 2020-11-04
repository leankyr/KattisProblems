using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace I_veBeenEverywhereMan
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/everywhere/everywhere-01.in"))
                {
                    string line;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    line = sr.ReadLine();
                    // Console.WriteLine(line);

                    string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    long T = Int64.Parse(split[0]);
                    //Console.WriteLine($"{T}");

                    for (short i = 0; i < T; i++) 
                    {
                        line = sr.ReadLine();
                        string[] split2 = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                        short N = Int16.Parse(split2[0]);
                        // define dict
                        Dictionary<string, int> Namesnumber = new Dictionary<string, int>();
                        for (short j = 0; j < N; j++)
                        {
                            string City = sr.ReadLine();
                            if (Namesnumber.ContainsKey(City))
                            {
                                continue;
                            }
                            Namesnumber.Add(City, j);
                        }
                        int size = Namesnumber.Count;
                        Console.WriteLine($"{size}");

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
