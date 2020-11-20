using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;


namespace BoatParts
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/boatparts/02.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                int P = int.Parse(split[0]);
                int N = int.Parse(split[1]);
                int d = 0;
                HashSet<string> h = new HashSet<string>();
                for (int i = 0; i < N; i++)
                {
                    line = sr.ReadLine();
                    if (!h.Contains(line))
                    {
                        h.Add(line);
                        d = i + 1;
                    }
                        
                }

                if (h.Count < P)
                    Console.WriteLine("paradox avoided");
                else
                    Console.WriteLine($"{d}");





            }
            Console.ReadKey();
        }
    }
}