using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Net;

namespace Romans
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/hangingout/1.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                byte L = byte.Parse(split[0]);
                byte x = byte.Parse(split[1]);

                int crowd = 0;
                int groups = 0;
                for (byte i = 0; i < x; i++) 
                {
                    line = sr.ReadLine();
                    split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    string command = split[0];
                    int n = int.Parse(split[1]);

                    //Console.WriteLine(crowd);
                    if (command == "enter" )
                    {
                        if (crowd + n <= L)
                            crowd += n;
                        else
                            groups += 1;
                    }
                    else if (command == "leave")
                        crowd -= n;
                        
                }

                Console.WriteLine(groups);
                Console.ReadKey();


            }
        }

    }
}
