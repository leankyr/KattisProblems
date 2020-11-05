using System;
using System.IO;




namespace Spavanac
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/spavanac/spavanac.3.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                int H = int.Parse(split[0]);
                int M = int.Parse(split[1]);

                Console.WriteLine($"{H} {M}");

                if (M >= 45)
                {
                    M = M - 45;
                }
                else if (H > 0 && M < 45)
                {
                    M = M - 45 + 60;
                    H = H - 1;
                }
                else
                {
                    M = M - 45 + 60;
                    H = 23; 
                }
                Console.WriteLine($"{H} {M}");
                Console.ReadKey();
            }
        }
    }
}
