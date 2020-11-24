using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DRMMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/drmmessages/2.in"))
            {
                string line = sr.ReadLine();
                char[] cipher = line.ToCharArray();

                char[] half1 = new char[line.Length / 2];
                char[] half2 = new char[line.Length / 2];
                for (int i = 0; i < line.Length / 2; i++)
                    half1[i] = cipher[i];
                for (int i = line.Length / 2; i < line.Length; i++)
                    half2[i - line.Length / 2] = cipher[i];

                Queue<char> q = new Queue<char>(new[] {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O',
                                                        'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'});



                char[] a = q.ToArray();
                Dictionary<char, int> d = new Dictionary<char, int>();
                for (int i = 0; i < 26; i++)
                    d.Add(a[i], i);

                // Rotate strings
                int rot1 = 0;
                int rot2 = 0;
                for (int i = 0; i < line.Length / 2; i++)
                {
                    rot1 += d[half1[i]];
                    rot2 += d[half2[i]];
                }


                for (int i = 0; i < line.Length / 2; i++)
                {

                    half1[i] = (char)('A' + (d[half1[i]] + rot1) % 26); //remember internally they are characters
                    half2[i] = (char)('A' + (d[half2[i]] + rot2) % 26);
                }
                

                //Final step

                for (int i = 0; i < line.Length / 2; i++)
                {

                    half1[i] = (char)('A' + (d[half1[i]] + d[half2[i]]) % 26);
                }
            
                string h1 = new string(half1);
                Console.WriteLine(h1);
            }
            Console.ReadKey();
        }
    }
}