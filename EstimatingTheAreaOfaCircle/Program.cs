using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Diagnostics.SymbolStore;

namespace EstimatingTheAreaOfACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/estimatingtheareaofacircle/sample.in"))
            {



                while (true)
                { 
                    string line = sr.ReadLine();
                    string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    double r = double.Parse(split[0]);
                    double m = double.Parse(split[1]);
                    double c = double.Parse(split[2]);

                    if (r == 0 && m == 0 && c == 0)
                    {
                        break;
                    }

                    double AC = Math.PI * r * r;
                    double AS = 4 * r * r;

                    double EC = (c / m) * AS;


                    Console.WriteLine($"{AC} {EC}");


                }
           

            }
            Console.ReadKey();
        }
    }
}