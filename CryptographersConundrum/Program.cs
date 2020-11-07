using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CryptographersConandrum
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/conundrum/1.in"))
            {
                string S = sr.ReadLine();

                int sl = S.Length;

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < S.Length; i++)
                {
                    if (i % 3 == 0)
                        sb.Append(' ');
                    sb.Append(S[i]);
                }
                sb.Remove(0, 1);
                string Sf = sb.ToString();

                string[] split = Sf.Split(new char[] { ' ' }, StringSplitOptions.None);
                int count = 0;
                int L = S.Length/3;
                for (int i = 0; i < L ; i++)
                {
                   // Console.WriteLine(split[i]);
                    char[] carr = split[i].ToCharArray();
                   // Console.WriteLine(carr[0]);
                    if (carr[0] == 'P')
                        count += 1;
                    if(carr[1] == 'E')
                        count += 1;
                    if(carr[2] == 'R')
                        count += 1;
                }

                Console.WriteLine(sl - count);

                Console.ReadKey();
            }
        }

    }
}
