using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romans
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/ladder/ladder.01.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                short h = short.Parse(split[0]);
                double v = (double)(Math.PI/180) * double.Parse(split[1]);

               // Console.WriteLine($"{h} {v}");

                double lad = (h / Math.Sin(v));
                double lad2 = Math.Ceiling(lad);


                Console.WriteLine($"{lad2}");

                Console.ReadKey();
            }
        }
    }
}
