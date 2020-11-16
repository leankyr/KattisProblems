using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Diagnostics.SymbolStore;

namespace SchoolSpirit
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/schoolspirit/sample2.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                int N = int.Parse(split[0]);


                double sum = 0;
                List<int> n = new List<int>();
                for (int i = 0; i < N; i++) 
                {
                    int S = int.Parse(line = sr.ReadLine());

                    sum += S * Math.Pow(0.8, i);
                    n.Add(S);


                }
                
                double avg = 0;
                for (int i = 0; i < N; i++)
                {
                    
                    List<int> n2 = new List<int>(n);
                    n2.RemoveAt(i);
                    for (int j = 0; j < N - 1; j++)
                    {
                        avg += n2[j] * Math.Pow(0.8, j);
                    }


                }




                Console.WriteLine(0.2 * sum);
                Console.WriteLine(0.2 * (avg / N));
                Console.ReadKey();

            }

        }


    }



}
