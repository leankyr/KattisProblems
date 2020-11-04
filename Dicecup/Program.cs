using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicecup
{
    class Program
    {
        
        static void Main(string[] args)

        {
            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/dicecup/sample01.in"))
            {
                string line;

                // Read and display lines from the file until 
                // the end of the file is reached. 
                line = sr.ReadLine();


                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                uint N = UInt32.Parse(split[0]);
                short M = Int16.Parse(split[1]);

                Console.WriteLine($"{N}");
                Console.WriteLine($"{M}");


                SortedDictionary<int, int> numbers = new SortedDictionary<int, int>();

                int max = 0;
                for (int i = 1; i <= N; i++) 
                { 
                    for (int j =1; j<= M; j++)
                    {
                        int sum = i + j;
                        if (numbers.ContainsKey(sum))
                            numbers[sum] = numbers[sum] + 1;
                        else
                            numbers.Add(sum, 1);

                        if (numbers[sum] > max)
                            max = numbers[sum];
                    }
                }
                foreach (KeyValuePair<int, int> n in numbers)
                    if (n.Value == max)
                        Console.WriteLine(n.Key);


                Console.ReadKey();

                
            }

        }


    }
}

