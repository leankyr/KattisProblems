using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;

namespace Cetverta
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/Bijele/2.in"))
            {
                string P1 = sr.ReadLine();
                string[] split = P1.Split(new char[] { ' ' }, StringSplitOptions.None);
                int n1 = int.Parse(split[0]);
                int n2 = int.Parse(split[1]);
                int n3 = int.Parse(split[2]);
                int n4 = int.Parse(split[3]);
                int n5 = int.Parse(split[4]);
                int n6 = int.Parse(split[5]);

                int[] n = { n1, n2, n3, n4, n5, n6 }; 
                int[] Pieces = new int[6];
                int[] mh = { 1, 1, 2, 2, 2, 8 }; 

                for (int i = 0; i < 6; i++)
                {
                    if (mh[i] - n[i] > 0)
                        Pieces[i] = mh[i] - n[i];
                    else if (mh[i] - n[i] == 0)
                        Pieces[i] = 0;
                    else
                        Pieces[i] = mh[i] - n[i];
                    
                    Console.Write($"{Pieces[i]} {""}");
                }

                Console.ReadKey();
            }

        }
    }
}