using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Diagnostics.SymbolStore;

namespace Greetings
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/greetings2/7.in"))
            {
                string line = sr.ReadLine();
                byte[] asciiCodes = Encoding.ASCII.GetBytes(line); // e is 101

                int c = 0;
                for (int i = 0; i < asciiCodes.Length; i++)
                {
                    if (asciiCodes[i] == 101)
                        c += 1;
                }

                byte[] newHey = new byte[2*c];

                for (int i = 0; i < 2 * c; i++)
                {
                    newHey[i] = 101;
                }
                string str = Encoding.Default.GetString(newHey);

                //Console.WriteLine(line);
                Console.WriteLine('h' + str + 'y') ;
                //Console.WriteLine(c);

                Console.ReadKey();

            }

        }
    }
}