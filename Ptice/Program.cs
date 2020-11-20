using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Diagnostics.SymbolStore;

namespace Ptice
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/ptice/2.in"))
            {
                string line = sr.ReadLine();
                int N = int.Parse(line);
                line = sr.ReadLine();


                string A = "ABC";
                string B = "BABC";
                string G = "CCAABB";

                while (N > A.Length)
                {
                    A = A + A;
                }
                while (N > B.Length)
                {
                    B = B + B;
                }
                while (N > G.Length)
                {
                    G = G + G;
                }

                A = A.Remove(N);
                B = B.Remove(N);
                G = G.Remove(N);

                //Console.WriteLine(A);
                //Console.WriteLine(B);
                //Console.WriteLine(G);

                char[] l = line.ToCharArray();
                char[] Ac = A.ToCharArray();
                char[] Bc = B.ToCharArray();
                char[] Gc = G.ToCharArray();

                int cA = 0;
                int cB = 0;
                int cG = 0;
                for (int i = 0; i < N; i++) 
                {
                    if (Ac[i] == l[i])
                        cA += 1;
                    if (Bc[i] == l[i])
                        cB += 1;
                    if (Gc[i] == l[i])
                        cG += 1;

                }

               int m = Math.Max(cA, cB);
                m = Math.Max(m, cG);
                Console.WriteLine(m);
                if (cA >= cB && cA >= cG)
                    Console.WriteLine("Adrian");
                if (cB >= cA && cB >= cG)
                    Console.WriteLine("Bruno");
                if (cG >= cB && cG >= cA)
                    Console.WriteLine("Goran");

            }
            Console.ReadKey();
        }
    }
}