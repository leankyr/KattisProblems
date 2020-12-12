using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/ofugsnuid/01.in"))
            {
                string line = sr.ReadLine();
                int N = int.Parse(line);

                //Console.WriteLine(N);
                int[] numbers = new int[N];
                for (int i = 0; i < N; i++)
                {
                    line = sr.ReadLine();
                    numbers[i] = int.Parse(line);
                }

                
                Array.Reverse(numbers);
                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine(numbers[i]);
                }

            }


            Console.ReadKey();
        }

    }
}
