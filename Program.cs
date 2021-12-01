//Main File
using CSharpDemoCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello from Program.cs\n");

            var sp = new StatsProcessor();

            var x = sp.Mean();
            Console.WriteLine($"mean is {x}");

            var y = sp.Median();
            Console.WriteLine($"median is {y}");

            var z = sp.Mode();
            Console.WriteLine($"mode is {z}");




            //Stats.MeanMedianMode();
        }


    }
}
