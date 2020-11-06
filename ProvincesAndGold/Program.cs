using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/provincesandgold/sample03.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                byte G = byte.Parse(split[0]);
                byte S = byte.Parse(split[1]);
                byte C = byte.Parse(split[2]);

                int BP = G * 3 + S * 2 + C * 1;

                string VC = "";

                if (BP >= 8)
                    VC = "Province or Gold";
                else if (BP >= 6)
                    VC = "Duchy or Gold";
                else if (BP >= 5)
                    VC = "Duchy or Silver";
                else if (BP >= 3)
                    VC = "Estate or Silver";
                else if (BP >= 2)
                    VC = "Estate or Copper";
                else
                    VC = "Copper";


                Console.WriteLine(VC);
                Console.ReadKey();
            }
        }
    }
}