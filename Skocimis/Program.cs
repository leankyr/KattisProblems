using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skocimis
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/skocimis/2.in"))
            {
               
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                int A = int.Parse(split[0]);
                int B = int.Parse(split[1]);
                int C = int.Parse(split[2]);

                int m = 0;

                while (true)
                {
                    if (A == B - 1 && B == C - 1)
                        break;

                    if (B - A < C - B)
                    {
                        int temp = B;
                        A = B;
                        B = temp + 1;
                    }
                    else
                    {
                        int temp = B;
                        C = B;
                        B = temp - 1;

                    }


                    m += 1;

                
                }
                Console.WriteLine(m);

            }
            Console.ReadKey();
        }
    }
}