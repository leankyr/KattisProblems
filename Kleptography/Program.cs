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
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/kleptography/1.in"))
            {

                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                int n = int.Parse(split[0]); // lentgh of keyword
                int m = int.Parse(split[1]); // length of cipher 
                string keyword = sr.ReadLine();
                string cipher = sr.ReadLine();

                char[] kw = keyword.ToCharArray();
                char[] dec = new char[m];
                char[] cph = cipher.ToCharArray();
                for (int i = 0; i < n; i++)
                {
                    dec[m - 1 - i] = kw[n - 1 - i];
                }

                byte[] b = Encoding.Default.GetBytes(kw);

                LinkedList<char> ll = new LinkedList<char>(kw); // python deque 

                
                for (int i = m - 1; i > n- 1; i--)// I thought of that too
                {
                    dec[i - n] = (char)(97 + (26 + cph[i] - dec[i]) % 26); // remeber chars internally are integers!!!
                }
                Console.WriteLine(dec);




            }
            Console.ReadKey();

        }
            
        
       
    }   
}