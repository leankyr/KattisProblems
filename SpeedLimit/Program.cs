using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;


namespace SpeedLimit
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/speedlimit/sample.in"))
            {


                while (true)
                {
                    string line = sr.ReadLine();
                    int N = int.Parse(line);

                    if (N == -1)
                        break;

                    int prevT = 0;
                    int miles = 0;
                    for (int i = 0; i < N; i++)
                    {
                        line = sr.ReadLine();
                        string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                        int S = int.Parse(split[0]);
                        int T = int.Parse(split[1]);
                        miles += S * (T - prevT);
                        prevT = T;
                    
                    }
                    Console.WriteLine(miles + " miles");


                }
            }
            Console.ReadKey();
        }
    }
}
