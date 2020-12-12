using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TripleTexting
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/tripletexting/1.in"))
            {
                string line = sr.ReadLine();
                
                string str1 = line.Substring(0, line.Length / 3);
                string str2 = line.Substring(line.Length / 3 , line.Length / 3);
                string str3 = line.Substring(2 * line.Length / 3, line.Length / 3);


                //Console.WriteLine($"{str1} {str2} {str3}");

                if (str1 == str2)
                    Console.WriteLine(str1);
                else if (str2 == str3)
                    Console.WriteLine(str2);
                else if (str1 == str3)
                    Console.WriteLine(str3);
                else
                    ;
            }
            
            Console.ReadKey();
        }
    }
}
