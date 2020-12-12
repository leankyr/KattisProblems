using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Peragrams
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/peragrams/peragrams-02.in"))
            {
                string line = sr.ReadLine();
                //Console.WriteLine(line);

                Queue<char> q = new Queue<char>(new[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o',
                                                        'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'});



                char[] a = q.ToArray();
                Dictionary<char, int> d = new Dictionary<char, int>();
                for (int i = 0; i < 26; i++)
                    d.Add(a[i], 0);

                char[] carr = line.ToCharArray();

                foreach (char c in carr)
                {
                    d[c] += 1;
                }
              //  foreach (char c in a)
              //      Console.Write(d[c]);

                int count = 0;
                bool foundOdd = false;
                foreach (char c in q) {
                    if (d[c] % 2 == 1)
                    {
                        if (!foundOdd)
                        {
                            foundOdd = true;
                            continue;
                        }
                        else
                            count += 1;
                    
                    }
                }
                Console.WriteLine(count);

            }
            Console.ReadKey();
        }   

    }
}
