using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace Beavergnaw
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/beavergnaw/C.in"))
            {
                while (true)
                { 
                    string P1 = sr.ReadLine();
                    string[] split = P1.Split(new char[] { ' ' }, StringSplitOptions.None);

                    double D = double.Parse(split[0]);
                    double V = double.Parse(split[1]) * 1.5;

                    if (D == 0 && V == 0)
                        break;

                    double pi = Math.PI;
                    double R = D / 2.0;

                    double Total = Math.Pow(R, 2) * Math.PI * D;

                    Total -= V;
                    Total /= Math.PI;
                    Total /= 2;
                    Total = Math.Pow(Total, (double)1/3);
                    Console.WriteLine(2 * Total);


                }
                Console.ReadKey();
                
            }

        }
    }
}
