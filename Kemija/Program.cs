using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Diagnostics.SymbolStore;

namespace Kemija
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/kemija08/kemija.2.in"))
            {

                string line = sr.ReadLine();
                //string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                
                HashSet<char> vowels = new HashSet<char>(){'a','e','i','o','u'};
                HashSet<char> space = new HashSet<char>() {' '};

                char[] chars = line.ToCharArray();
                var list = new List<char>(chars);
                int l = chars.Length;
                for (int i = 0; i < l; i++)
                {
                    if (vowels.Contains(list[i]))
                    {
                        list.RemoveAt(i + 1);
                        list.RemoveAt(i + 1);
                        l -= 2;
                    }
                    if (space.Contains(list[i]))
                        continue;
                }

                foreach (char c in list)
                    Console.Write(c);


            }   

            Console.ReadKey();
        }
    }
}
