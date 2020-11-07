using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;

namespace Cetverta
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/cetvrta/1.in"))
            {
                string P1 = sr.ReadLine();
                string[] split = P1.Split(new char[] { ' ' }, StringSplitOptions.None);
                int x1 = int.Parse(split[0]);
                int y1 = int.Parse(split[1]);

                string P2 = sr.ReadLine();
                split = P2.Split(new char[] { ' ' }, StringSplitOptions.None);
                int x2 = int.Parse(split[0]);
                int y2 = int.Parse(split[1]);

                string P3 = sr.ReadLine();
                split = P3.Split(new char[] { ' ' }, StringSplitOptions.None);
                int x3 = int.Parse(split[0]);
                int y3 = int.Parse(split[1]);


                Program o = new Program();

                int[] P4 = o.FindLastPoint(x1, x2, x3, y1, y2, y3);

                Console.WriteLine($"{P4[0]} {P4[1]}");

                Console.ReadKey();
            }
       
        }
        public int[] FindLastPoint(int x1, int x2, int x3, int y1, int y2, int y3)
        {
            int[] P4 = new int[2];
            int x4=0;
            int y4=0;


            if (x1 == x2)
                x4 = x3;
            else if (x1 == x3)
                x4 = x2;
            else if (x2 == x3)
                x4 = x1;

            if (y1 == y2)
                y4 = y3;
            else if (y1 == y3)
                y4 = y2;
            else if (y2 == y3)
                y4 = y1;


            P4[0] = x4;
            P4[1] = y4;

            return P4;
        }


    }
}
