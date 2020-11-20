using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Diagnostics.SymbolStore;

namespace OddManOut
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/oddmanout/1.in"))
            {
                string line = sr.ReadLine();
                int N = int.Parse(line);

                for (int i = 0; i < N; i++) 
                {
                    line = sr.ReadLine();
                    int G = int.Parse(line);
                    line = sr.ReadLine();
                    string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);

                    List<int> l = new List<int>();
                    for (int j = 0; j < G; j++)
                    {
                        l.Add(int.Parse(split[j]));
                    }

                    var query = l.GroupBy(x => x) // interesting to find the unique value ok...
                    .Where(g => g.Count() == 1)
                    .Select(y => y.Key)
                    .ToList();

                    Console.WriteLine("Case #"+ (i+1) + ": " + query[0]);
                }
                            
            }
            Console.ReadKey();
        }
    }
}