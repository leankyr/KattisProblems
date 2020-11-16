using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Diagnostics.SymbolStore;

namespace QuickBrownFox
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/quickbrownfox/a.in"))
            {
                string line = sr.ReadLine();
                int N = int.Parse(line);

                Queue<char> q = new Queue<char>(new[] {'a', 'b', 'c', 'd', 'e', 'f', 'g' ,'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o',
                                                          'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'});



                char[] a = q.ToArray();
                
                for (int i = 0; i < N; i++)
                {
                    line = sr.ReadLine();
                    line = line.ToLower(); //Strings are immutable!!!!!!
                   // Console.WriteLine(line);
                    char[] c = line.ToCharArray();
                    byte[] asciiCodes = Encoding.ASCII.GetBytes(line);

                    List<char> m = new List<char>();
                    Dictionary<char, char> letters = new Dictionary<char, char>();
                    for (int j = 0; j < c.Length; j++)
                    {
                        if ((asciiCodes[j] >= 97 && asciiCodes[j] <= 122))
                            if (!letters.ContainsKey(c[j]))
                                letters.Add(c[j], c[j]);
                    
                    }
                    for (int j = 0; j < a.Length; j++)
                        if (!letters.ContainsKey(a[j]))
                            m.Add(a[j]);


                    if (m.Count == 0)
                    {
                        Console.Write("pangram");
                    }
                    else
                    {
                        Console.Write("missing ");
                        foreach (char cc in m)
                            Console.Write(cc);
                    }
                    Console.WriteLine();
                    
                    





                }
                Console.ReadKey();

            }

        }
    }
}