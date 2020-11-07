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
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/isithalloween/2.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                string MON = (split[0]);
                string DAY = (split[1]);

                

                if (MON == "OCT" && DAY == "31")
                    Console.WriteLine("yup");
                else if (MON == "DEC" && DAY == "25")
                    Console.WriteLine("yup");
                else
                    Console.WriteLine("nope");

                Console.ReadKey();

            }
        }

    }
}