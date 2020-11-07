using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Net;

namespace Romans
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/icpcawards/1.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                int N = int.Parse(split[0]);


                Dictionary<string, string> d = new Dictionary<string, string>();
                for (int i = 0; i < N; i++)
                {
                    line = sr.ReadLine();
                    split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    string UNI = split[0];
                    string TEAM = split[1];

                    if (d.ContainsKey(UNI))
                        continue;

                    d.Add(UNI, TEAM);
                    

                }
                
                int count = 0;
                foreach (KeyValuePair<string, string> kvp in d)
                {
                    if (count == 12)
                        break;

                    Console.WriteLine("{0} {1}",
                       kvp.Key, kvp.Value);
                    count += 1;
                }

                Console.ReadKey();

            }
        }

    }
}