using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemoCodes
{
    internal class Stats
    {
        public static void ShowOutput()
        {
            int[] numbers = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };

            double mean = numbers.Average();
            Console.WriteLine(("Mean: " + mean));

        }
    }
}
