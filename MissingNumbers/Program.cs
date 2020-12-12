using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Peragrams
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/missingnumbers/2.in"))
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

                int lastNum = numbers[numbers.Length - 1];
                int[] idealCount = new int[lastNum];

                

                for (int i = 0; i < lastNum; i++)
                    idealCount[i] = i + 1;

                for (int i = 0; i < N; i++)
                    idealCount[numbers[i] - 1] = 0;

                bool skipped = true;
                if (idealCount.Sum() == 0 )
                    skipped = false;
                foreach (int n in idealCount)
                {
                   if (n == 0)
                       continue;
                    else
                        Console.WriteLine(n);
                }
                
                if (!skipped)
                    Console.WriteLine("good job");


            }


            Console.ReadKey();
        }

    }
}
