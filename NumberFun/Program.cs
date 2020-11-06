using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFun
{
    class Program
    {

        static void Main(string[] args)

        {
            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/numberfun/sample01.in"))
            {
                string line;
                line = sr.ReadLine();


                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                short N = short.Parse(split[0]);



                for (byte i = 0; i < N; i++)
                {
                    line = sr.ReadLine();
                    split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    short a = short.Parse(split[0]);
                    short b = short.Parse(split[1]);
                    short c = short.Parse(split[2]);

                    if (a + b == c) {
                        Console.WriteLine("Possible");
                        continue;
                    }
                    else if (a - b == c || b - a == c)
                    {
                        Console.WriteLine("Possible");
                        continue;
                    }
                    else if (a * b == c)
                    {
                        Console.WriteLine("Possible");
                        continue;
                    }
                    else if (a / b == c && a % b == 0|| b / a == c && b % a == 0)
                    {
                        Console.WriteLine("Possible");
                        continue;
                    }
                    else
                        Console.WriteLine("Impossible");


                }
                Console.ReadKey();
            }
        }

    }
}