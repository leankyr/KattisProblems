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
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/reversebinary/binary-sample-1.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                int N = int.Parse(split[0]);

                //Console.WriteLine(N);
               
                string binary = Convert.ToString(N, 2);
                //Console.WriteLine(binary);
                

                char[] digits = binary.ToCharArray();

                Array.Reverse(digits);

                string rbinary = new string(digits);
                //Console.WriteLine(rbinary);
                string dec = Convert.ToInt32(rbinary, 2).ToString();

                Console.WriteLine(dec);
                Console.ReadKey();

            }
        }
    }
}
