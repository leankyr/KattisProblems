using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DRMMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/rationalsequence2/sample001.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                int P = int.Parse(split[0]);

                for (int i = 0; i < P; i++)
                {
                    line = sr.ReadLine();
                    split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    int K = int.Parse(split[0]);
                    split = split[1].Split(new char[] { '/' }, StringSplitOptions.None);
                    int p = int.Parse(split[0]);
                    int q = int.Parse(split[1]);
                    //Console.WriteLine($"{p} {q}");

                    StringBuilder sb = new StringBuilder();


                    while (p > 1 || q > 1)
                    {
                        if (q > p)
                        {
                            q -= p;
                            sb.Append('L');

                        }
                        else
                        {
                            p -= q;
                            sb.Append('R');
                        }

                    }
                        string arr = new string(sb.ToString().Reverse().ToArray()); // That's that

                        char[] arr2 = arr.ToCharArray();

                        int k = 1;
                        foreach (char c in arr2)
                        {
                            k *= 2;
                            if (c == 'R')
                            {
                                k++;
                            }
                        }
                        Console.WriteLine($"{K} {k}");


                }
                    Console.ReadKey();
                
            }
        }        

    }
}
