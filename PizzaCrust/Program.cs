using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCrust
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/pizza2/2.in"))
            {

                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                int R = int.Parse(split[0]);
                int C = int.Parse(split[1]);

                double Pa = Math.PI * R * R;
                int CheeseR = R - C;
                double Ca = Math.PI * CheeseR * CheeseR;



                Console.WriteLine($"{100*Ca/Pa:0.000000}");

            }
            Console.ReadKey();
        }
    }
}