using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreedyPolygons
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/greedypolygons/sample1.in"))
            {

                string line = sr.ReadLine();
                
                int N = int.Parse(line);

                for (int i = 0; i < N; i++)
                {
                    line = sr.ReadLine();
                    string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    double n = double.Parse(split[0]);
                    double l = double.Parse(split[1]);
                    double d = double.Parse(split[2]);
                    double g = double.Parse(split[3]);

                    double area = 0.25 * n * l * l * 1 / (Math.Tan(Math.PI / n)) + Math.Pow(g*d,2) * Math.PI + n*l*d*g;

                    Console.WriteLine(area);

                }


            }
            Console.ReadKey();
        }
    }
}