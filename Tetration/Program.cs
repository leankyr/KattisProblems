using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Tetration
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/tetration/tetration-03.in"))
            {

                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                double N = double.Parse(split[0]);

                double er = 1;
                double a = N;
                while (true)
                {
                    if (N == 1) 
                    {
                        a = 1;
                        break;
                    }

                    if (er < 0.000001)
                        break;
                    a = Math.Pow(N,1/N);
                    N = a;
                    er = Math.Abs(N - a);
                }




                
                    Console.WriteLine($"{a:0.000000}");
                    Console.ReadKey();

            }



        }


    }


}

