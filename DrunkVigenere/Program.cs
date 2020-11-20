using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Diagnostics.SymbolStore;

namespace DrunkVigenere
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/drunkvigenere/drunkvigenere-02.in"))
            {



                
                
                string line = sr.ReadLine();
                char[] EM = line.ToCharArray();
                line = sr.ReadLine();
                char[] key = line.ToCharArray();
                    
                List<char> DM = new List<char>();

                Dictionary<char,int> d = new Dictionary<char, int>(){
                    {'A', 0}, {'B', 1}, {'C', 2}, {'D', 3}, {'E', 4},
                    {'F',5 }, {'G',6 }, {'H', 7}, {'I',8},
                    {'J',9}, {'K',10}, {'L',11}, {'M', 12},
                    {'N', 13 }, {'O', 14}, {'P',15 }, {'Q',16},
                    {'R',17 }, {'S',18 }, {'T', 19}, {'U',20},
                    {'V', 21 }, {'W',22 }, {'X',23 }, {'Y',24 }, {'Z',25 }};

                Dictionary<int, char> dd = new Dictionary<int, char>(){
                    {0, 'A'}, {1, 'B'}, {2, 'C'}, {3, 'D'},
                    {4, 'E'}, {5, 'F'}, {6, 'G'}, {7, 'H'},
                    {8, 'I'}, {9, 'J'}, {10, 'K'}, {11, 'L'},
                    {12, 'M'}, {13, 'N'}, {14, 'O'}, {15, 'P'},
                    {16, 'Q'}, {17, 'R'}, {18, 'S'}, {19, 'T'},
                    {20, 'U'}, {21, 'V'}, {22, 'W'}, {23, 'X'}, {24, 'Y'}, {25, 'Z'}
                };




                //Console.WriteLine(d['A']);
                //Console.WriteLine(key[0]);

                for (int i = 0; i < key.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        int shift = (d[EM[i]] - d[key[i]]) % 26;
                        //Console.WriteLine(shift);
                        DM.Add(dd[shift]);
                    }
                    else 
                    {
                        int shift = (d[EM[i]] + d[key[i]]) % 26;
                        //Console.WriteLine(shift);
                        DM.Add(dd[shift]);
                    }


                }
                foreach (char c in DM)
                    Console.Write(c);


                Console.ReadKey();





            }
            
        }
    }
}
