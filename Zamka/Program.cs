using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamka
{
    class Program
    {

        static void Main(string[] args)

        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/zamka/zamka.3.in"))
                {
                    string line;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    string num1 = sr.ReadLine();
                    string num2 = sr.ReadLine();
                    string num3 = sr.ReadLine();
                    //Console.WriteLine($"{L}");
                    //Console.WriteLine($"{D}");
                    //Console.WriteLine($"{X}");
                    // start Solving

                    int L = int.Parse(num1);
                    int D = int.Parse(num2);
                    int X = int.Parse(num3);

                    int numSmall = 0;
                    int numBig = 0;
                    for (int i = L; i <= D; i++) 
                    {
                        int k = i;
                        string s = k.ToString();

                        char[] digits = s.ToCharArray();
                        int res = digits.Sum(c => c - '0');

                        if (res == X) 
                        {
                            numSmall = i;
                            break;
                        }
                    }
                    Console.WriteLine(numSmall);

                    for (int i = D; i >= L; i--)
                    {
                        int k = i;
                        string s = k.ToString();

                        char[] digits = s.ToCharArray();
                        int res = digits.Sum(c => c - '0');

                        if (res == X)
                        {
                            numBig = i;
                            break;
                        }
                    }
                    Console.WriteLine(numBig);

                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
