using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACMCOntestScoring
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/acm/2.in"))
            {
                int sumc = 0;
                int sumt = 0;
                
                HashSet<char> psr = new HashSet<char>();
                List<char> psw = new List<char>();

                while (true)
                {
                    string line = sr.ReadLine();
                    string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    if (int.Parse(split[0]) == -1)
                        break;

                    int time = int.Parse(split[0]);
                    char prob = char.Parse(split[1]);
                    string eval = split[2];
                    
                    // Console.WriteLine($"{time} {prob} {eval}");
                    if (eval == "wrong")
                    {
                        psw.Add(prob);
                    }


                    if (eval == "right")
                    {
                        sumc += 1;
                        sumt += time;
                        psr.Add(prob);
                    }

                }

                foreach (char p in psr) {
                    var c = psw.Where(s => s == p).Count(); // again linq should know
                    if (psw.Contains(p))
                        sumt += 20 * c;
                }

                

                Console.WriteLine($"{sumc} {sumt}");


            }
            Console.ReadKey();
        }
    }
}
