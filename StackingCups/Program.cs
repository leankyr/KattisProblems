using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Diagnostics.SymbolStore;

namespace StackingCups
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/cups/cups-01.in"))
            {

                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                int N = int.Parse(split[0]);
                SortedDictionary<int, string> sort = new SortedDictionary<int, string>(); // dict is faster I guess

                for (int i = 0; i < N; i++)                 
                {
                    line = sr.ReadLine();
                    split = line.Split(new char[] { ' ' }, StringSplitOptions.None);



                    byte[] asciiCodes = Encoding.ASCII.GetBytes(split[0]);
                    if (asciiCodes[0] >= 48 && asciiCodes[0] <= 57)
                    {
                        sort.Add(int.Parse(split[0]), split[1]);
                    }
                    else 
                    {
                        sort.Add(2* int.Parse(split[1]),split[0]);
                    }



                }

                foreach (KeyValuePair<int, string> s in sort)
                    Console.WriteLine(s.Value);
                Console.ReadKey();

            }



        }


    }


}

