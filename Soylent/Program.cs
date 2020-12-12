using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Soylent
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/soylent/soylent-01.in"))
            {


                
                    string line = sr.ReadLine();
                    int T = int.Parse(line);

                for (int i = 0; i < T; i++) 
                { 
                    line = sr.ReadLine();
                    int N = int.Parse(line);
                    
                    double b = Math.Ceiling((double)N / 400);
                    Console.WriteLine(b);
                }

                    



            }

            Console.ReadKey();
        }

    }
}