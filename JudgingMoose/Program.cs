using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Net;

namespace Romans
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/judgingmoose/3.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                short l = short.Parse(split[0]);
                short r = short.Parse(split[1]);

                //Console.WriteLine($"{l} {r}");
                if (l == 0 && r == 0)
                {
                    Console.WriteLine("Not a moose");
                    
                }

                if (l == r && l != 0)
                    Console.WriteLine($"{"Even"} {2 * l}");
                else if (r > l)
                    Console.WriteLine($"{"Odd"} {2 * r}");
                else if (l > r)
                    Console.WriteLine($"{"Odd"} {2 * l}");
                


                Console.ReadKey();
            }   
        }

    }
}