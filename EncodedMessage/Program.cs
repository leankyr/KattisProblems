using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace Romans
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/encodedmessage/e.in"))
            {
                string line = sr.ReadLine();
                int C = int.Parse(line);

                for (int i = 0; i < C; i++)
                {
                    line = sr.ReadLine();
                    char[] chars = line.ToCharArray();
                    double d = Math.Sqrt(line.Length);
                    int count = 0;

                    var sb = new List<char>(); // for new string
                    for (int k = (int)d-1; k >= 0; k--)
                    {
                        for (int j = 0; j < d; j++)
                        {
                            sb.Add(chars[k + (int)d * j ]);
                            count += 1;
                        }
                    }

                    foreach (char c in sb)
                        Console.Write(c);
                    Console.Write('\n');

                    //Console.WriteLine(P);

                }
                Console.Write('\n');
                Console.ReadKey();
            }
        }

    }
}