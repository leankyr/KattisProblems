using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datum
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/cudoviste/cudoviste.3.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] {' '}, StringSplitOptions.None);
                int R = int.Parse(split[0]);
                int C = int.Parse(split[1]);

                char[,] map = new char[R, C]; // multi dim array

                for(int k= 0; k<R; k++)
                {
                    line = sr.ReadLine();
                    line.ToCharArray();
                    for (int l=0;l<C;l++)
                    {
                        map[k, l] = line[l];
                    }
                }


                int ip = 0;
                int jp = 0;
                int i = 1;
                int j = 1;
                int RowCount = 1;
                int[] count = new int[5];
                while(true)
                {
                    StringBuilder s = new StringBuilder();
                    s.Append(map[ip, jp]);
                    s.Append(map[ip, j]);
                    s.Append(map[i, jp]);
                    s.Append(map[i, j]);
                   //ip = i;
                    jp = j;
                  //  i += 1;
                    j += 1;

                    if (j == C)
                    {
                        jp = 0;
                        j = 1;
                        RowCount += 1;
                        ip = RowCount - 1;
                        i = RowCount;
                    }
                    

                    if (s.ToString().Contains("#"))
                        ;
                    else if (s.ToString().Contains("X"))
                    {
                        var c = s.ToString().Count(x => x == 'X');
                        count[c] += 1;
                    }
                    else
                        count[0] += 1;
                    if (RowCount == R)
                        break;

                    //Console.WriteLine(s);
                    
                }

                for (i = 0; i < 5; i++)
                    Console.WriteLine(count[i]);



                    Console.ReadKey();
            }
        }

    }
}
