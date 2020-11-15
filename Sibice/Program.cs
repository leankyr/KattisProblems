using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Sibice
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/sibice/1.in"))
            {

                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                int N = int.Parse(split[0]);
                int W = int.Parse(split[1]);
                int H = int.Parse(split[2]);

                double diag1 = Math.Sqrt(Math.Pow(W, 2) + Math.Pow(W, 2));
                double diag2 = Math.Sqrt(Math.Pow(W, 2) + Math.Pow(H, 2));
                
                for (int i = 0; i < N; i++)
                {
                    int M = int.Parse(line = sr.ReadLine());

                    if (M <= diag2)
                        Console.WriteLine($"{"DA"}");
                    else
                        Console.WriteLine($"{"NE"}");
                }


                
                Console.ReadKey();

            }



        }


    }


}
