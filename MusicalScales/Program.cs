using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MusicalScales
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/musicalscales/scales-02.in"))
            {
                string line = sr.ReadLine();
                int N = int.Parse(line);
                line = sr.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);


                List<string> Scales = new List<string>();
                HashSet<string> A = new HashSet<string> { "A", "B", "C#", "D", "E", "F#", "G#", "A" };
                HashSet<string> As = new HashSet<string> { "A#", "C", "D", "D#", "F", "G", "A", "A#" };
                HashSet<string> B = new HashSet<string> { "B", "C#", "D#", "E", "F#", "G#", "A#", "B" };
                HashSet<string> C = new HashSet<string> {"C", "D", "E", "F", "G", "A", "B", "C"};
                
                HashSet<string> Cs = new HashSet<string> { "C#", "D#", "F", "F#", "G#", "A#", "C", "C#" };
                HashSet<string> D = new HashSet<string> { "D", "E", "F#", "G", "A", "B", "C#", "D" };
                HashSet<string> Ds = new HashSet<string> { "D#", "F", "G", "G#", "A#", "C", "D", "D#" };
                HashSet<string> E = new HashSet<string> { "E", "F#", "G#", "A", "B", "C#", "D#", "E" };
                
                HashSet<string> F = new HashSet<string> { "F", "G", "A", "A#", "C", "D", "E", "F" };
                HashSet<string> Fs = new HashSet<string> { "F#", "G#", "A#", "B", "C#", "D#", "F", "F#"};
                HashSet<string> G = new HashSet<string> { "G", "A", "B", "C", "D", "E", "F#", "G" };
                HashSet<string> Gs = new HashSet<string> { "G#", "A#", "C", "C#", "D#", "F", "G", "G#" };






                bool notContained = false;
                for (int i = 0; i < N; i++)
                {
                    if (!A.Contains(split[i]))
                    {
                        notContained = true;
                    }
                }
                if (!notContained)
                    Scales.Add("A");

                notContained = false;
                for (int i = 0; i < N; i++)
                {
                    if (!As.Contains(split[i]))
                    {
                        notContained = true;
                    }
                }
                if (!notContained)
                    Scales.Add("A#");


                notContained = false;
                for (int i = 0; i < N; i++)
                {
                    if (!B.Contains(split[i])) 
                    {
                        notContained = true;   
                    }
                }
                if (!notContained)
                    Scales.Add("B");

                notContained = false;
                for (int i = 0; i < N; i++)
                {
                    if (!C.Contains(split[i]))
                    {
                        notContained = true;
                    }
                }
                if (!notContained)
                    Scales.Add("C");


                notContained = false;
                for (int i = 0; i < N; i++)
                {
                    if (!Cs.Contains(split[i]))
                    {
                        notContained = true;
                    }
                }
                if (!notContained)
                    Scales.Add("C#");

                notContained = false;
                for (int i = 0; i < N; i++)
                {
                    if (!D.Contains(split[i]))
                    {
                        notContained = true;
                    }
                }
                if (!notContained)
                    Scales.Add("D");


                notContained = false;
                for (int i = 0; i < N; i++)
                {
                    if (!Ds.Contains(split[i]))
                    {
                        notContained = true;
                    }
                }
                if (!notContained)
                    Scales.Add("D#");

                notContained = false;
                for (int i = 0; i < N; i++)
                {
                    if (!E.Contains(split[i]))
                    {
                        notContained = true;
                    }
                }
                if (!notContained)
                    Scales.Add("E");


                notContained = false;
                for (int i = 0; i < N; i++)
                {
                    if (!F.Contains(split[i]))
                    {
                        notContained = true;
                    }
                }
                if (!notContained)
                    Scales.Add("F");

                notContained = false;
                for (int i = 0; i < N; i++)
                {
                    if (!Fs.Contains(split[i]))
                    {
                        notContained = true;
                    }
                }
                if (!notContained)
                    Scales.Add("F#");


                notContained = false;
                for (int i = 0; i < N; i++)
                {
                    if (!G.Contains(split[i]))
                    {
                        notContained = true;
                    }
                }
                if (!notContained)
                    Scales.Add("G");

                notContained = false;
                for (int i = 0; i < N; i++)
                {
                    if (!Gs.Contains(split[i]))
                    {
                        notContained = true;
                    }
                }
                if (!notContained)
                    Scales.Add("G#");

                if (Scales.Count == 0)
                    Console.Write("none");

                for (int i = 0; i < Scales.Count; i++) 
                {
                    Console.Write($"{Scales[i]} ");
                }

            }


            Console.ReadKey();
        }

    }
}