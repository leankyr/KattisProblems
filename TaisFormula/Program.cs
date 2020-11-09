using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace TaisFormula
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/taisformula/2.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                double N = double.Parse(split[0]);

                line = sr.ReadLine();
                split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                double pt = double.Parse(split[0]);
                double pv = double.Parse(split[1]);

                double sum = 0;
                for (int i = 1; i<N; i++)
                {
                    line = sr.ReadLine();
                    split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    double t = double.Parse(split[0]);
                    double v = double.Parse(split[1]);

                    double A = ((pv + v) / 2) * (t - pt);

                    sum += A;
                        
                        pt = t;
                        pv = v;

                }
                Console.WriteLine(sum/1000);

                    

                
                Console.ReadKey();

            }

        }
    }
}
