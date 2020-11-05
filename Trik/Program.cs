using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace Trik
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/trik/2.in"))
            {
                string line;

                // Read and display lines from the file until 
                // the end of the file is reached. 
                line = sr.ReadLine();
                Console.WriteLine(line);
                // to char array
                char[] moves = line.ToCharArray();


                short Pos = 1;
                for (short i = 0; i < moves.Length; i++)
                {
                    if (Pos == 1)
                    {
                        if (moves[i] == 'A')
                            Pos = 2;
                        else if (moves[i] == 'B')
                            continue;
                        else
                            Pos = 3;
                    }
                    else if (Pos == 2)
                    {
                        if (moves[i] == 'A')
                            Pos = 1;
                        else if (moves[i] == 'B')
                            Pos = 3;
                        else
                            continue;

                    }
                    else
                    {
                        if (moves[i] == 'A')
                            continue;
                        else if (moves[i] == 'B')
                            Pos = 2;
                        else
                            Pos = 1;

                    }

                }
                Console.WriteLine(Pos);
            }

                Console.ReadKey();
        }
    }
}
