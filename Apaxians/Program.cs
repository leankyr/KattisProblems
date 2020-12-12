using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Apaxians
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/apaxiaaans/apaxiaaans-003.in"))
            {
                string line = sr.ReadLine();
                char[] input = line.ToCharArray();

                List<char> ll = new List<char>(input);
                List<char> l2 = new List<char>();
                l2.Add(ll.ElementAt(0));
                for (int i = 1; i < line.Length; i++) 
                {
                    if (ll.ElementAt(i - 1) != ll.ElementAt(i))
                    {
                        l2.Add(ll.ElementAt(i));
                    }
                }

                foreach (char c in l2)
                    Console.Write(c);



                Console.ReadKey();

            }
        }

    }
}
