using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasiestProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/easiest/sample.in"))
            {
                

                while (true) 
                {
                    string line = sr.ReadLine();
                    string N = line;
                    if (int.Parse(N) == 0)
                        break;

                    char[] digits = N.ToCharArray();
                    int sumN = 0;
                    for (int i = 0; i < digits.Length; i++)
                    {
                        int d = digits[i] - '0';
                        sumN += d;
                    }
                    //Console.WriteLine(sumN);

                    int Num = int.Parse(N);
                    int p = 11;

                    while (true){
                        int prod = p * Num;
                        string dgs = prod.ToString();
                        digits = dgs.ToCharArray();
                        int sumD = 0;
                        for (int i = 0; i < digits.Length; i++)
                        {
                            int d = digits[i] - '0';
                            sumD += d;
                        }
                        if (sumD == sumN)
                        {
                            Console.WriteLine(p);
                            break;
                        }
                        else
                            p += 1;



                    }

                }




            }

            Console.ReadKey();
        }
        
    }
}