using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace Autori
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/autori/autori.2.in"))
            {
                string line = sr.ReadLine();
                int dashCount = line.Count(t => t == '-');

                //Console.WriteLine($"{dashCount}");
    

                //count the hyphens
                string[] split = line.Split(new char[] { '-' }, StringSplitOptions.None);

                var abr = new StringBuilder(); // to get the new string
                for (int i = 0; i < dashCount + 1; i++) {
                    char[] name = split[i].ToCharArray();
                    //Console.WriteLine(name[0]);
                    abr.Append(name[0]);
                }





                Console.WriteLine(abr);
                Console.ReadKey();
            }
        }
    }
}
