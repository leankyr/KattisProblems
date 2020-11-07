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
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/harshadnumbers/3.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                string n = split[0];
                int num = int.Parse(split[0]);


                while (true)
                {   

                    char[] digits = n.ToCharArray();
                    int[] intDigits = digits.Select(a => a - '0').ToArray();

                    int digitSum = intDigits.Sum();


                    if (num % digitSum == 0)
                    {
                        Console.WriteLine(num);
                        break;
                    } 
                    else
                    {
                        num += 1;
                        n = num.ToString();
                    }
                }
                Console.ReadKey();

              
            }
        }

    }
}
