using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Diagnostics.SymbolStore;

namespace RacingAroundTheAlphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/racingalphabet/1.in"))
            {
                string line = sr.ReadLine();
                int N = int.Parse(line);
                

                double Per = 2 * Math.PI * 30;
                double DBL = Per / 28;

                Queue<char> q = new Queue<char>(new[] {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O',
                                                        'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', ' ','\''});
                
                
                
                char[] a = q.ToArray();
                Dictionary<char, int> d = new Dictionary<char, int>();
                for (int i = 0; i < 28; i++) 
                    d.Add(a[i], i);

                for (int i = 0; i < N; i++)
                {
                    line = sr.ReadLine();
                    char[] input = line.ToCharArray();
                    int TotalD = 0;
                    for (int j = 1; j < input.Length; j++)
                    {
                        if (Math.Abs(d[input[j]] - d[input[j - 1]]) < 14)
                            TotalD += Math.Abs(d[input[j]] - d[input[j - 1]]);
                        else
                        {
                            if (d[input[j]] > d[input[j - 1]])
                                TotalD += 28 - d[input[j]] + d[input[j - 1]];
                            else
                                TotalD += 28 - d[input[j-1]] + d[input[j]];

                        }
                    }

                    double TotalT = (DBL * TotalD) /15 + input.Length;
                    Console.WriteLine(TotalT);
                }

                
                Console.ReadKey();

            }

        }
    }
}