using System;
using System.IO;
using System.Collections.ObjectModel;


namespace SumKindOfProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/sumkindofproblem/sample001.in"))
            {

                string line = sr.ReadLine();
                int P = int.Parse(line);

                for (int i = 0; i < P; i++)
                {
                    line = sr.ReadLine();
                    string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    int K = int.Parse(split[0]);
                    int n = int.Parse(split[1]);

                    Console.WriteLine($"{K} {SumPosInts(n)} {SumOddInts(2*n)} {SumEvenInts(2 * n)}");
                }


                    

            }
            



            Console.ReadKey();
        }
        static int SumPosInts(int a) 
        {
            if (a == 0)
                return a;
            else
                return a + SumPosInts(a - 1);
        }

        static int SumOddInts(int a)
        {


            if (a == 1)
                return a;
            else if(a%2 == 0)
                return SumOddInts(a - 1);
            else
                return a + SumOddInts(a - 1);
        }

        static int SumEvenInts(int a)
        {


            if (a == 0)
                return a;
            else if (a % 2 == 1)
                return SumEvenInts(a - 1);
            else
                return a + SumEvenInts(a - 1);
        }








    }
}