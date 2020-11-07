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
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/jobexpenses/03.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                int N = int.Parse(split[0]);

                line = sr.ReadLine();
                split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                int sum = 0;
                int i = 0;
                while (i < N)
                    {
                    sum = Math.Max(sum, sum - int.Parse(split[i]));
                    i++;
                }
                Console.WriteLine(sum);
                Console.ReadKey();



            }
        }

    }
}
