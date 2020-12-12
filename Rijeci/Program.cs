using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rijeci
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/rijeci/rijeci.3.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);

                byte K = byte.Parse(split[0]);
                int[] ab = fib(K);

                Console.WriteLine($"{ab[0]} {ab[1]}");


            }

            Console.ReadKey();
        }
        static int[] fib(byte a) // it reminds of fibonacci so it is reccursive
        {
            int[] f = new int[a + 1];
            f[0] = 0;
            f[1] = 1;

            for (int x = 2; x <= a; x++)
                f[x] = f[x - 1] + f[x - 2];

            int[] s = { f[a - 1], f[a] };
            return s;



            
        }
    }
}
