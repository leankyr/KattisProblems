using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/heimavinna/03.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ';' }, StringSplitOptions.None);

                int n = 0;

                for (int i = 0; i < split.Length; i++)
                {
                    if (!split[i].Contains("-"))
                        n += 1;
                    else
                    {
                        string[] split2 = split[i].Split(new char[] { '-' }, StringSplitOptions.None);
                            
                        int n1 = int.Parse(split2[0]);
                        int n2 = int.Parse(split2[1]);
                         n = n + (n2 - n1 + 1);

                    }

                }
                Console.WriteLine(n);


            }


            Console.ReadKey();
        }

    }
}
