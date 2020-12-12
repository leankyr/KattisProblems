using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skener
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/skener/2.in"))
            {

                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                int R = int.Parse(split[0]);
                int C = int.Parse(split[1]);
                int Zr = int.Parse(split[2]);
                int Zc = int.Parse(split[3]);


                char[,] input = new char[R, C];
                char[,] output = new char[R, Zc*C];
                char[,] output2 = new char[Zr*R, Zc * C];
                for (int i = 0; i < R; i++)
                {
                    line = sr.ReadLine();
                    split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    line.ToCharArray();
                    for (int j = 0; j < C; j++) 
                    {
                        input[i, j] = line[j];
                        //Console.Write(input[i, j]);
                    }
                    //Console.WriteLine();
                }
                //Console.WriteLine();
                for (int i = 0; i < R; i++)
                {
                    for (int u = 0; u < Zr; u++)
                    {
                        for (int j = 0; j < C; j++)
                        {
                            for (int k = 0; k < Zc; k++)
                            {

                                Console.Write(input[i, j]);
                            }
                        }
                        Console.WriteLine();
                    }
                    

                }
              
             

            }
        
            Console.ReadKey();
        }
    }
}