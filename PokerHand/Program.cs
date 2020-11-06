using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ReversedBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/pokerhand/2.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                string c1 = split[0];
                string c2 = split[1];
                string c3 = split[2];
                string c4 = split[3];
                string c5 = split[4];

                char[] C1 = c1.ToCharArray();
                char[] C2 = c2.ToCharArray();
                char[] C3 = c3.ToCharArray();
                char[] C4 = c4.ToCharArray();
                char[] C5 = c5.ToCharArray();

                char[] cards= { C1[0], C2[0], C3[0], C4[0], C5[0] };

                string hand = new string(cards);

                
                char[] pcards = { 'A', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K' };

                int mc = 0;
                foreach (char c in pcards)
                {
                    var count = cards.Count(x => x == c);
                    //Console.WriteLine(count);
                    if (count > mc)
                        mc = count;
                }   

                Console.WriteLine(mc);
                Console.ReadKey();
            }
        }
    }
}