using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Romans
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/kornislav/kornislav.2.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                short A = short.Parse(split[0]);
                short B = short.Parse(split[1]);
                short C = short.Parse(split[2]);
                short D = short.Parse(split[3]);

                //Console.WriteLine($"{A} {B} {C} {D}");

                // I need the object
                Program n = new Program();

                

                short[] dims = { A, B, C, D };

                Console.WriteLine(n.MakeSquare(dims));

                
             

               //- Console.WriteLine($"{lad2}");

                Console.ReadKey();
            }
       
        }

        public int MakeSquare(short[] d) 
        
        {
            Array.Sort(d);
            
            return d[0] * d[2];
            
        }


    }
}