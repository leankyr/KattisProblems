using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;


namespace CLosingTheLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/closingtheloop/1.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                int N = int.Parse(split[0]);


                for (int i = 0; i < N; i++)
                {
                    int Length = 0;
                    line = sr.ReadLine();
                    int S = int.Parse(line);
                    line = sr.ReadLine();
                    split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    if (S == 1)
                    {
                        Length = 0;
                        Console.WriteLine("Case #" + (i + 1) + ": " + Length);
                        continue;
                    }
                    char prevC = 'N';
                    int prevL = 0;
                    int knots = 0;
                    List<char> cs = new List<char>();

                    for (int j = 0; j < S; j++)
                    {
                        char[] seg = split[j].ToCharArray();

                        int L = 0;
                        char C = 'N';


                        if (seg.Length == 2)
                        {
                            L = seg[0] - '0';
                            C = seg[1];
                            cs.Add(C);
                        }
                        else if (seg.Length == 3)
                        {
                            string d1 = seg[0].ToString();
                            string d2 = seg[1].ToString();
                            string num = d1 + d2;
                            L = int.Parse(num);
                            C = seg[2];
                            cs.Add(C);
                        }
                        else if (seg.Length == 4)
                        {
                            string d1 = seg[0].ToString();
                            string d2 = seg[1].ToString();
                            string d3 = seg[2].ToString();
                            string num = d1 + d2 + d3;
                            L = int.Parse(num);
                            C = seg[3];
                            cs.Add(C);
                        }

                        if (prevC != C)
                        {
                            Length += L;
                            prevC = C;
                            prevL = L;
                            knots += 1;
                        }
                        else
                        {
                            if (L > prevL)
                            {
                                Length = Length + L - prevL;
                                prevL = L;
                            }
                        }




                    }
                    Length -= knots;
                    if (!cs.Contains('R') || !cs.Contains('B'))
                    {
                        Length = 0;
                        Console.WriteLine("Case #" + (i + 1) + ": " + Length);
                    }
                    else
                        Console.WriteLine("Case #" + (i + 1) + ": " + Length);
                }
                   

                    



            }
                Console.ReadKey();

        }

        
    }
}
