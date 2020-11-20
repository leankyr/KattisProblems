using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HonorThyParent
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/apaxianparent/apaxianparent-004.in"))
            {

                string line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                char[] Y = split[0].ToCharArray();
                char[] P = split[1].ToCharArray();

                HashSet<char> vowels = new HashSet<char>() { 'a', 'i', 'o', 'u' };
                HashSet<char> e = new HashSet<char>() { 'e'};
                HashSet<char> x = new HashSet<char>() { 'x' };

                string ans = string.Empty;
                if (e.Contains(Y[Y.Length - 1]))
                {
                    string s1 = new string(Y);
                    string s2 = new string(P);
                    ans = s1 + "x" + s2;
                }
                else if (vowels.Contains(Y[Y.Length - 1]))
                {
                    Y[Y.Length - 1] = 'e';
                    string s1 = new string(Y);
                    string s2 = new string(P);
                    ans = s1 + "x" + s2;
                }
                else if (x.Contains(Y[Y.Length - 1]) && e.Contains(Y[Y.Length - 2]))
                {
                    string s1 = new string(Y);
                    string s2 = new string(P);
                    ans = s1 + s2;
                }
                else
                {
                    string s1 = new string(Y);
                    string s2 = new string(P);
                    ans = s1 + "ex" +  s2;
                }
                Console.WriteLine(ans);
            }
            Console.ReadKey();
        }
    }
}