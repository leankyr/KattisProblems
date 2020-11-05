using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Bela
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/bela/bela.2.in"))
            {
                string line = sr.ReadLine();

                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                short N = short.Parse(split[0]);
                char B = char.Parse(split[1]);

                //Console.WriteLine($"{N} {B}");
                

                int sum = 0;
                for (short i = 0; i < N; i++)
                {
                    for (short j = 0; j < 4; j++)
                    {
                        line = sr.ReadLine();
                        char[] cards = line.ToCharArray();
                        //Console.WriteLine($"{cards[0]}");
                        if (cards[0] == '7' || cards[0] == '8')
                            continue;
                        else if (cards[0] == 'A')
                            sum += 11;
                        else if (cards[0] == 'K')
                            sum += 4;
                        else if (cards[0] == 'Q')
                            sum += 3;
                        else if (cards[0] == 'T')
                            sum += 10;
                        else if (cards[0] == 'J')
                        {
                            if (cards[1] == B)
                                sum += 20;
                            else
                                sum += 2;
                        }
                        else
                        {
                            if (cards[1] == B)
                                sum += 14;
                            else
                                continue;
                        }
                    }

                }
                    Console.WriteLine($"{sum}");

                    Console.ReadKey();
            }
        }
    }
}