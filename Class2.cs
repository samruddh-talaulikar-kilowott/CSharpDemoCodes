using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class2
    {
        public static void ShowOutput()
        {
            Console.WriteLine("Hello from Class2.cs\n");
            int firstValue = 100;
            int secondValue = 500;
            int largerValue, smallervalue;
            largerValue = Math.Max(firstValue, secondValue);
            smallervalue = Math.Min(firstValue, secondValue);
            Console.Write("The Larger Value is:");
            Console.WriteLine(largerValue);
            Console.Write("The Smaller Value is:");
            Console.WriteLine(smallervalue);
            
        }
    }
}
