using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skener
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/oddgnome/sample01.in"))
            {

                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                int n = int.Parse(split[0]);

                for (int i = 0; i < n; i++)
                {
                    line = sr.ReadLine();
                    split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    int[] gnomes = new int[int.Parse(split[0])];
                    for (int j = 0; j < int.Parse(split[0]); j++)
                    {
                        gnomes[j] = int.Parse(split[j + 1]);
                        //Console.Write($"{gnomes[j]} ");
                    }
                    // Console.WriteLine();
                    int k = 0;
                    for (int j = 0; j < gnomes.Length; j++)
                    {
                        if (gnomes[j + 1] == gnomes[j] + 1)
                            continue;
                        else
                        {
                            k = j + 1;
                            break;
                        }
                    }
                    Console.WriteLine(k + 1);
                }

            }
            Console.ReadKey();
        }
    }
}