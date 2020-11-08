using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WeakVertices
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/WeakVertices/sample.in"))
            {
                while (true)
                {
                    string line = sr.ReadLine();
                    string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    int n = int.Parse(split[0]);
                    if (n == -1)
                        break;



                    int[][] am = new int[n][];
                    for (int i = 0; i < n; i++)
                    {
                        am[i] = new int[n];
                        line = sr.ReadLine();
                        split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                        for (int j = 0; j < n; j++)
                        {
                            am[i][j] = int.Parse(split[j]);

                        }
                    }


                    for (int i = 0; i < n; i++)
                    {
                        bool weak = true;
                        for (int j = 0; j < n; j++)
                        {
                            for (int k = 0; k < n; k++)
                            {
                                if (am[i][j] == 1 && am[i][k] == 1 && am[j][k] == 1 && i != j && i != k && j != k) // how to check if all three are neighboors
                                    weak = false;
                            }

                        }
                        if (weak)
                            Console.Write($"{i} ");



                    }
                    Console.WriteLine();
                }
                //Console.WriteLine(s);

            }
                Console.ReadKey();
            
        }

    }
}