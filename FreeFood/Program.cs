using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Diagnostics.SymbolStore;

namespace MixedFractions
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/freefood/3.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                int N = int.Parse(split[0]);

                int sDays = 0;
                HashSet<int> S = new HashSet<int>();
                for (int i = 0; i < N; i++)
                {
                    line = sr.ReadLine();
                    split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    int s = int.Parse(split[0]);
                    int t = int.Parse(split[1]);
                    for (int j = s; j <= t; j++)
                    {
                        if (!S.Contains(j))
                        {
                            sDays += 1;
                            S.Add(j);
                            
                        }
                        else
                            continue;
                    }
                    
                }
                

                
                Console.WriteLine($"{sDays}");

                



            }
            Console.ReadKey();
        }
    }
}