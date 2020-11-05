using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransitWoes
{
    class Program
    {

        static void Main(string[] args)

        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/transitwoes/transitwoes-02.in"))
                {
                    string line;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    line = sr.ReadLine();


                    string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    uint s = UInt32.Parse(split[0]);
                    uint t = UInt32.Parse(split[1]);
                    uint n = UInt32.Parse(split[2]);
                    //Console.WriteLine($"{s} {t} {n}");

                    line = sr.ReadLine();
                    string[] split2 = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    uint[] dropOffTimes = new uint[n+1];
                    for (short i = 0; i < n + 1; i++) { 
                        dropOffTimes[i] = uint.Parse(split2[i]);
                        //Console.WriteLine($"{dropOffTimes[i]}");
                    }


                    line = sr.ReadLine();
                    string[] split3 = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    uint[] busTimeDropOffs = new uint[n];
                    for (short i = 0; i < n; i++)
                    {
                        busTimeDropOffs[i] = uint.Parse(split3[i]);
                        //Console.WriteLine($"{busTimeDropOffs[i]}");
                    }
                    line = sr.ReadLine();
                    string[] split4 = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    uint[] arrivalInterval = new uint[n];
                    for (short i = 0; i < n; i++)
                    {
                        arrivalInterval[i] = uint.Parse(split4[i]);
                        //Console.WriteLine($"{arrivalInterval[i]}");
                    }
                    
                    short k = 0;
                    uint timePassed = s;
                    while (timePassed < t && k < n )
                    {
                        timePassed += dropOffTimes[k];
                        timePassed += busTimeDropOffs[k];
                        timePassed += (dropOffTimes[k] + busTimeDropOffs[k]) % arrivalInterval[k];
                        k += 1;
                    }

                    if (timePassed + dropOffTimes[k] < t)
                        Console.WriteLine("yes");
                    else                   
                       Console.WriteLine("no");
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
