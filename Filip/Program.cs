using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filip
{
    class Program
    {

        static void Main(string[] args)

        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/filip/filip.dummy.3.in"))
                {
                    string line;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    line = sr.ReadLine();
                    string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    string num1 = split[0];
                    string num2 = split[1];

                    char[] num1c = num1.ToCharArray();
                    char[] num2c = num2.ToCharArray();

                    Array.Reverse(num1c);
                    Array.Reverse(num2c);

                    string num1r = new string(num1c); // to make it a string 
                    string num2r = new string(num2c);

                    int n1 = Int32.Parse(num1r);
                    int n2 = Int32.Parse(num2r);

                    //Console.WriteLine(n1);
                    //Console.WriteLine(n2);
                    
                    if (n1 > n2) 
                    {
                        Console.WriteLine($"{n1}");
                    }
                    else
                    {
                        Console.WriteLine($"{n2}");
                    }



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
