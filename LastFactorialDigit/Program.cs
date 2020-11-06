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
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/lastfactorialdigit/2.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                short T = short.Parse(split[0]);

                for (short i = 0; i < T; i++) 
                {
                    string num = sr.ReadLine();
                    int n = int.Parse(num);
                    
                    if (n == 0 || n == 1 )
                        Console.WriteLine('1');
                    if (n == 2)
                        Console.WriteLine('2');
                    if (n == 3)
                        Console.WriteLine('6');
                    if (n == 4)
                        Console.WriteLine('4');
                    if (n == 5)
                        Console.WriteLine('0');
                    if (n == 6)
                        Console.WriteLine('0');
                    if (n == 7)
                        Console.WriteLine('0');
                    if (n == 8)
                        Console.WriteLine('0');
                    if (n == 9)
                        Console.WriteLine('0');
                    if (n == 10)
                        Console.WriteLine('0');


                }
                



                Console.ReadKey();
            }
        }
    }
}
