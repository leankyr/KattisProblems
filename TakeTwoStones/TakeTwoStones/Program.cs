using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KattisProblems
{
    class main
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                long N = Int64.Parse(split[0]);

                /// solve test case and output answer
                if (N % 2 != 0)
                {
                    Console.WriteLine("Alice");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Bob");
                    Console.ReadLine();
                }
            }
        }
    }
}