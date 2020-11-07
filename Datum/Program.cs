using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace Datum
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/leankyr/source/repos/KattisProblems/Inputs/datum/datum.1.in"))
            {
                string line = sr.ReadLine();
                string[] split = line.Split(new char[] {' '}, StringSplitOptions.None);
                int D = int.Parse(split[0]);
                int M = int.Parse(split[1]);

                DateTime date = new DateTime(2009, M, D);
                var weekDate = date.DayOfWeek;

                Console.WriteLine(weekDate);

                Console.ReadKey();
            }
        }

    }
}