using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tri
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/tri/tri-02.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                int n1 = int.Parse(split[0]);
                int n2 = int.Parse(split[1]);
                int n3 = int.Parse(split[2]);

                if (n1 + n2 == n3)
                    Console.WriteLine($"{n1}+{n2}={n3}");
                else if (n3 + n2 == n1)
                    Console.WriteLine($"{n1}={n2}+{n3}");
                else if (n1 - n2 == n3)
                    Console.WriteLine($"{n1}-{n2}={n3}");
                else if (n2 - n3 == n1)
                    Console.WriteLine($"{n1}={n2}-{n3}");
                else if (n1 * n2 == n3)
                    Console.WriteLine($"{n1}*{n2}={n3}");
                else if (n3 * n2 == n1)
                    Console.WriteLine($"{n1}={n2}*{n3}");
                else if (n1 / n2 == n3)
                    Console.WriteLine($"{n1}/{n2}={n3}");
                else if (n2 / n3 == n1)
                    Console.WriteLine($"{n1}={n2}/{n3}");
                else if (n3 / n2 == n1)
                    Console.WriteLine($"{n1}={n2}/{n3}");
            }

            Console.ReadKey();
        }
    }
}

