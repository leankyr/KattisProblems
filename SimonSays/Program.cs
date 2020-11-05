using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SimonSays
{
    class Program
    {

        static void Main(string[] args)

        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/simonsays/02_simple.in"))
                {
                    string line = sr.ReadLine();
                    short N = short.Parse(line);
                    //Console.WriteLine(N);

                    
                    for (short i = 0; i < N; i++)
                    {
                        line = sr.ReadLine();
                        
                        string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                        int c = split.Length;
                        //Console.WriteLine(split[0]);
                        //Console.WriteLine(split[1]);
                        var str = new System.Text.StringBuilder();
                        if (split[0] == "Simon" && split[1] == "says")
                        {
                            for (short j = 2; j < c; j++)
                            {
                                str.Append(" " + split[j]);
                            }
                                    
                        }
                         
                           
                        else
                            continue;
                       

                        Console.WriteLine(str);

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

