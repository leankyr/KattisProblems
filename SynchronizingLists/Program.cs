using System;
using System.CodeDom;
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

                     // this is how to copy lists
                    List<int> res2 = new List<int>(l2);
                    int[] l2n = new int[n];

                    /*
                    foreach (int i in l1)
                    {
                        Console.WriteLine(i);
                    }

                    foreach (int i in res1)
                    {
                        Console.WriteLine(i);
                    }
                    */
                    for(int i = 0; i < n; i++) 
                    {
                        int ir1 = res1.IndexOf(res1.Min());
                        int li = l1.IndexOf(res1.Min());

                        l2n[li] = res2.Min();

                        res1.RemoveAt(ir1);
                        int ir2 = res2.IndexOf(res2.Min());
                        res2.RemoveAt(ir2);
                    }

                    foreach (int i in l2n)
                    {
                        Console.WriteLine(i);
                    }




                }
                    



                Console.ReadKey();


            }

                
        }       
                

    }
            

}

    
