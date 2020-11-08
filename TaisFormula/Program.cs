using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace TaisFormula
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/taisformula/1.in"))
            {
                while (true)
                {
                    string P1 = sr.ReadLine();
                    string[] split = P1.Split(new char[] { ' ' }, StringSplitOptions.None);

                    
                    
                    
                    Console.WriteLine(2 * Total);


                }
                Console.ReadKey();

            }

        }
    }
}