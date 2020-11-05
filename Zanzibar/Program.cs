using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Zanzibar
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/zanzibar/sample.in"))
            {
                string line;
                line = sr.ReadLine();

                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                short T = short.Parse(split[0]);


                // test cases
                for (int i = 0; i < T; i++)
                {   
                    line = sr.ReadLine();
                    string[] split2 = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    int k = 1;
                    int count = 0;
                    while(true)
                    {
                        int cp = int.Parse(split2[k-1]);
                        int cn = int.Parse(split2[k]);

                        if (cn > 2 * cp)
                        {
                            Console.WriteLine(cn);
                            Console.WriteLine(cp);
                            count += cn - 2*cp;
                            
                            
                        if (cn == 0)
                            break;

                        k += 1;
                    }
                    Console.WriteLine(count);

                }   
                Console.ReadKey();
            }
        }
    }
}
