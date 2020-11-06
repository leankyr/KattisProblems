using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo
{
    class Program
    {

        static void Main(string[] args)

        {
            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/modulo/3.in"))
            {
                string line;
                Dictionary<int, int> d = new Dictionary<int, int>();
                for (byte i = 0; i < 10; i++) 
                {
                    line = sr.ReadLine();
                    string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    short N = short.Parse(split[0]);

                    int m = N % 42;
                    if (d.ContainsKey(m))
                        continue;

                        d.Add(m, N);
                }

                //foreach (int k in d.Keys)
                  //  Console.WriteLine(k);

                Console.WriteLine(d.Count());
                Console.ReadKey();
             
            }
        }

    }
}