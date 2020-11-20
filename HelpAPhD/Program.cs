using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelpAPhD
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/helpaphd/1.in"))
            {

                string line = sr.ReadLine();
                //string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                int N = int.Parse(line);

                for (int i = 0; i < N; i++) 
                {
                    line = sr.ReadLine();
                    char[] chars = line.ToCharArray();
                    if (chars[0] == 'P')
                        Console.WriteLine("skipped");
                    else
                    { 
                        string[] split = line.Split(new char[] { '+' }, StringSplitOptions.None);
                        int a = int.Parse(split[0]);
                        int b = int.Parse(split[1]);
                        Console.WriteLine(a+b);
                    }

                }

                
            }
            Console.ReadKey();
        }
    }
}