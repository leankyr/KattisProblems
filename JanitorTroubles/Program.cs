using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JanitorTroubles
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/janitortroubles/01-half-hex.in"))
            {

                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                double s1 = double.Parse(split[0]);
                double s2 = double.Parse(split[1]);
                double s3 = double.Parse(split[2]);
                double s4 = double.Parse(split[3]);

                double S = (s1 + s2 + s3 + s4) / 2;
                

                double K = Math.Sqrt((S - s1) * (S - s2) * (S - s3) * (S - s4)); // we need opposite corners to equal PI

                Console.WriteLine(K);
            }
            Console.ReadKey();
        }
    }
}