using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SumSquaredDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/sumsquareddigits/sample01.in"))
            {
                
                    string line = sr.ReadLine();
                    string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    int P = int.Parse(split[0]);

                
                for (int i = 0; i < P; i++) 
                {
                    line = sr.ReadLine();
                    split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    int K = int.Parse(split[0]);
                    int b = int.Parse(split[1]);
                    int n = int.Parse(split[2]);
                    long sum = 0;
                    while(n>0)
                    {
                        int d = (int)(n % b); // how you get rid of the bs
                        sum += d * d;
                        n = (int)(n - d) / b; 


                    }
                    Console.WriteLine($"{K} {sum}");
                    Console.ReadKey();

                }



            }


        }


    }


}