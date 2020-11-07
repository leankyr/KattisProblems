using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Beavergnaw
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/avion/3.in"))
            {
                
                
                    
                int[] c = new int[5]; 
                for (int i = 0; i < 5; i++)
                {
                    string line = sr.ReadLine();
                    if (line.Contains("FBI"))
                        c[i] = i + 1;
                }

                if (c.Sum() != 0)
                    foreach (int n in c)
                    {
                        if (n == 0)
                            continue;
                        Console.Write($"{n} ");
                    }
                else
                    Console.WriteLine("HE GOT AWAY!");


                
                Console.ReadKey();

            }

        }
    }
}
