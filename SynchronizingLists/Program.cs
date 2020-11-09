using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SynchronizingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/synchronizinglists/sample.in"))
            {
                while (true)
                {
                    string line = sr.ReadLine();
                    string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    int n = int.Parse(split[0]);
                    if (n == -0)
                        break;

                    var l1 = new List<int>();
                    var l2 = new List<int>();

                    for (int i=0; i < n; i++)
                    {
                        line = sr.ReadLine();
                        l1.Add(int.Parse(line));
                    }

                    for (int i = 0; i < n; i++)
                    {
                        line = sr.ReadLine();
                        l2.Add(int.Parse(line));
                    }
                  


                }
                    
                    Console.ReadKey();
            }       
                //Console.WriteLine(s);

        }
            

    }

    
}