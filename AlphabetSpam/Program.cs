using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Diagnostics.SymbolStore;

namespace AlphabetSpam
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/alphabetspam/1.in"))
            {
                string line = sr.ReadLine();
                byte[] asciiCodes = Encoding.ASCII.GetBytes(line);

                int whites = 0;
                int lowerCase = 0;
                int upperCase = 0;
                int symbols = 0;

                for (int i = 0; i < asciiCodes.Length; i++)
                {
                    if (asciiCodes[i] == 95)
                        whites += 1;
                    else if (asciiCodes[i] >= 65 && asciiCodes[i] <= 90)
                        upperCase += 1;
                    else if (asciiCodes[i] >= 97 && asciiCodes[i] <= 122)
                        lowerCase += 1;
                    else
                        symbols += 1;


                    
                }
                Console.WriteLine($"{(decimal)whites / line.Length:0.00000000}");
                Console.WriteLine($"{(decimal)lowerCase / line.Length:0.00000000}");
                Console.WriteLine($"{(decimal)upperCase / line.Length:0.00000000}");
                Console.WriteLine($"{(decimal)symbols / line.Length:0.00000000}");

                Console.ReadKey();

            }

        }
    }
}
