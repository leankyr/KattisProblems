using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;


namespace ARationalSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/rationalsequence2/sample001.in"))
            {


            
                    string line = sr.ReadLine();
                    int P = int.Parse(line);

                    for (int i = 0; i < P; i++) 
                    {
                        line = sr.ReadLine();
                        string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                        int n = int.Parse(split[0]);
                        
                        string[] split2 = split[1].Split(new char[] { '/' }, StringSplitOptions.None);
                        int p = int.Parse(split2[0]);
                        int q = int.Parse(split2[1]);


                    Console.WriteLine(Sequence(p, q));
                    
                    
                        //Console.WriteLine($"{n} {p} {q}");
                    }
                  
                Console.ReadKey();
            }
        

        }
        static int Sequence(int p, int q)
        {
            if (p == 1 && q == 1)
                return 1;
            if (p < q)
                return 2*Sequence(p, q - p);
            else if (p > q)
                return 2*Sequence(p - q, q);
            
            return 0;
            

        }

    }
}
