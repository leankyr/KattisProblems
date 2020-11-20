using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MethodicMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/kleptography/2.in"))
            {

                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                int n = int.Parse(split[0]);
                int m = int.Parse(split[1]);
                string keyword = sr.ReadLine();
                string clearText = sr.ReadLine();

                char[] kw = keyword.ToCharArray();
                char[] dec = new char[m];

                for (int i = 0; i < n; i++)
                {
                    dec[m - 1 - i] = kw[n - 1 - i];
                }

                byte[] b = Encoding.Default.GetBytes(kw);
    



                for (int i = m - 1; i > n - 1; i--)
                {
                    dec[i - n] = 
                }







                }
                */







            }
            Console.ReadKey();
        }
       
    }   
}