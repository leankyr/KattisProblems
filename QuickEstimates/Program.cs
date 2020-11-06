using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/quickestimate/2.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                short N = short.Parse(split[0]);


                for (short i = 0; i < N; i++)
                {
                    line = sr.ReadLine();
                    string num = (line);
                    char[] digits = num.ToCharArray();

                    Console.WriteLine(digits.Length);

                
                
                
                }
                Console.ReadKey();
            }
        }
    }
}

