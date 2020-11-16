using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Diagnostics.SymbolStore;

namespace StarArrangemets
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/relocation/1.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                int N = int.Parse(split[0]);
                int Q = int.Parse(split[1]);

                int[] X = new int[N]; // the locations of the N companies
                line = sr.ReadLine();
                split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                for (int i = 0; i < N; i++) 
                {
                    X[i] = int.Parse(split[i]);
                }
                for (int i = 0; i < Q; i++)
                {
                    line = sr.ReadLine();
                    split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    int K = int.Parse(split[0]);
                    if (K == 1)
                    {
                        int C = int.Parse(split[1]);
                        int x = int.Parse(split[2]);

                        X[C - 1] = x;
                    }
                    else
                    {
                        int A = int.Parse(split[1]);
                        int B = int.Parse(split[2]);

                        int D = Math.Abs(X[A - 1] - X[B - 1]);
                        Console.WriteLine(D);


                    }
                }
                    Console.ReadKey();

            }

        }


    }



}