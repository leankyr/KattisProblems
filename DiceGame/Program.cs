using System;
using System.IO;
using System.Collections.ObjectModel;


namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/dicegame/3.in"))
            {
           
                    string line = sr.ReadLine();
                    string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    int a1G = int.Parse(split[0]);
                    int b1G = int.Parse(split[1]);
                    int a2G = int.Parse(split[2]);
                    int b2G = int.Parse(split[3]);
                    line = sr.ReadLine();

                split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                int a1E = int.Parse(split[0]);
                int b1E = int.Parse(split[1]);
                int a2E = int.Parse(split[2]);
                int b2E = int.Parse(split[3]);

                int sG = a1G + b1G + a2G + b2G;
                int sE = a1E + b1E + a2E + b2E;

                if(sG>sE)
                    Console.WriteLine($"Gunnar");
                else if(sG==sE)
                    Console.WriteLine($"Tie");
                else
                    Console.WriteLine($"Emma");

            }
            Console.ReadKey();
        }
    }
}