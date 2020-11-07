using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Net;
using System.Threading;

namespace Romans
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/fiftyshades/1.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                byte N = byte.Parse(split[0]);

                int count = 0;
                for (int i = 0; i < N; i++)
                {
                    line = sr.ReadLine();
                    line = line.ToLower();
                    if (line.Contains("pink") || line.Contains("rose"))
                        count += 1;


                }

                if (count > 0)
                    Console.WriteLine(count);
                else
                    Console.WriteLine("\"I must watch Star Wars with my daughter\"");
                Console.ReadKey();
            }

            
        }

    }
}