using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    class Program
    {

        static void Main(string[] args)

        {
            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/parking2/parking.in"))
            {
                string line;
                line = sr.ReadLine();


                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                byte t = byte.Parse(split[0]);

                

                for (byte i = 0; i < t; i++) 
                {
                    line = sr.ReadLine();
                    split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    byte n = byte.Parse(split[0]);
                    line = sr.ReadLine();
                    split = line.Split(new char[] { ' ' }, StringSplitOptions.None);

                    byte min = 101;
                    byte max = 0;
                    for (byte j = 0; j < n; j++) 
                    {
                        if (byte.Parse(split[j]) > max)
                            max = byte.Parse(split[j]);
                        if(byte.Parse(split[j]) < min)
                            min = byte.Parse(split[j]);

                    }
                    Console.WriteLine($"{(max-min)*2}");


                }
                Console.ReadKey();

            }

        }


    }
}
