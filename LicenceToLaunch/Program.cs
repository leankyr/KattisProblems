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
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/licensetolaunch/1.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                int n = int.Parse(split[0]);

                line = sr.ReadLine();
                split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                long minDays = (long)Math.Pow(10, 10);
                int index = 0;                


                for (int i = 0; i < n; i++)
                {
                    //Console.WriteLine($"{split[i]}");
                    int m = int.Parse(split[i]);
                    if (m < minDays) 
                    {
                        //Console.WriteLine($"{split[i]}");
                        minDays = m;
                        index = i;
                    }

                }
                
                
                Console.WriteLine($"{index}");



                Console.ReadKey();
            }
        }
    }
}