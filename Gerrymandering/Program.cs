using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SymmetricOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/gerrymandering/1.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                int P = int.Parse(split[0]);
                int D = int.Parse(split[1]);
                Dictionary<string, int> DPV = new Dictionary<string, int>();
                int[,] Sv = new int[D,2];

                for (int i = 0; i < D; i++) 
                {
                    for (int j = 0; j < 2; j++) 
                    {
                        Sv[i, j] = 0;
                    }
                }


                for (int i = 0; i < P; i++)
                {
                    
                    line = sr.ReadLine();
                    split = line.Split(new char[] { ' ' }, StringSplitOptions.None);

                    int d = int.Parse(split[0]);
                    int A = int.Parse(split[1]);
                    int B = int.Parse(split[2]);
                    
                    

                    Sv[d - 1, 0] += A;
                    Sv[d - 1, 1] += B;
                    



                }
                double WA = 0;
                double WB = 0;
                int V = 0;
                for (int i = 0; i < D; i++)
                {
                    V += (Sv[i, 0] + Sv[i, 1]);
                    if (Sv[i, 0] > Sv[i, 1])
                    {
                        Console.Write($"{'A'} {Sv[i, 0] - (Sv[i, 0] + Sv[i, 1]) / 2 - 1} {Sv[i, 1]} ");
                        WA += Sv[i, 0] - (Sv[i, 0] + Sv[i, 1]) / 2 - 1;
                        WB += Sv[i, 1];
                    }
                    else
                    {
                        Console.Write($"{'B'} {Sv[i, 0]} {Sv[i, 1] - (Sv[i, 0] + Sv[i, 1]) / 2 - 1} ");
                        WA += Sv[i, 0];
                        WB += Sv[i, 1] -  (Sv[i, 0] + Sv[i, 1]) / 2 - 1;
                    }
                        Console.Write($"\n");
                }
                double EG = Math.Abs(WA - WB) / V;

                Console.Write(EG);




            }
            Console.ReadKey();
        }
    }
}