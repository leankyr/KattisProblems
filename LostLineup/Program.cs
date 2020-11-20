using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Diagnostics.SymbolStore;

namespace MethodicMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/lostlineup/2.in"))
            {
                
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                int N = int.Parse(split[0]);
                line = sr.ReadLine();
                split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                Dictionary<int, int> d = new Dictionary<int, int>();
                for (int i = 1; i < N; i++) 
                {
                    d.Add(int.Parse(split[i - 1]), i);
                }

                List<int> q = new List<int>();
                q.Add(1);


                //foreach (KeyValuePair<int, int> p in d)
                 //   Console.Write(p + " ");


                for (int i = 0; i < N-1; i++)
                {
                    q.Add(d[i] + 1);
                }

                foreach (int n in q)
                    Console.Write(n + " ");


            }
            Console.ReadKey();
        }
    }
}
