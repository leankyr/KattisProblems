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
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/detaileddifferences/sample.in"))
            {
                string line = sr.ReadLine();
                int n = int.Parse(line);



                for (int i = 0; i < n; i++)
                {
                    string in1 = sr.ReadLine();
                    string in2 = sr.ReadLine();

                    char[] in1c = in1.ToCharArray();
                    char[] in2c = in2.ToCharArray();

                    var sb = new List<char>();
                    for (int j = 0; j < in1.Length; j ++)
                    {
                        if (in1c[j] == in2c[j])
                            sb.Add('.');
                        else
                            sb.Add('*');
                    }
                    Console.WriteLine(in1);
                    Console.WriteLine(in2);
                    Console.WriteLine(sb.ToArray()); // To be able to print the string
                    Console.Write('\n');
                    
                }
                Console.ReadKey();
            }
        }

    }
}