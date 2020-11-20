using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SymmetricOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/symmetricorder/sample.in"))
            {

                int k = 1;
                while (true)
                {
                    string line = sr.ReadLine();
                    //string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    int N = int.Parse(line);
                    if (N == 0)
                        break;
                    Console.WriteLine("SET " + k);
                    List<string> ans = new List<string>(new string[N]);
                    int K = N-1;
                    int l = 0;
                    for (int i = 0; i < N; i++)
                    {
 
                        line = sr.ReadLine();
                        ans.Insert(l,line);
                        l++;
                        i++;
                        if (i == N)
                            break;
                        line = sr.ReadLine();
                        ans.Insert(K, line);
                        K--;
                    }
                    foreach (string s in ans)
                    {
                        if (s == null)
                            continue;
                        Console.WriteLine(s);
                    }
                    k += 1;
                }  
            }
            Console.ReadKey();
        }
    }
}