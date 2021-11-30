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
            int num_value = 15;


            //Mode Calculation
            float tot = 0;
            float mean = 0;
            for (int i = 0; i < num_value; i++)
            {
                tot = tot + numbers[i];
            }
            mean = tot / num_value;
            Console.Write("Mean: ");
            Console.WriteLine(mean);


            //Median calculation   
            float mid = 0;
            if (num_value % 2 == 0)
            {
                int temp = (num_value / 2) - 1;
                for (int i = 0; i < num_value; i++)
                {
                    if (temp == i || (temp + 1) == i)
                    {
                        mid = mid + numbers[i];
                    }
                }
                mid = mid / 2;
                Console.Write("Median: ");
                Console.WriteLine(mid);
            }
            else
            {
                int temp = (num_value / 2);
                for (int i = 0; i < num_value; i++)
                {
                    if (temp == i)
                    {
                        mid = numbers[i];
                        Console.Write("Median: ");
                        Console.WriteLine(mid);
                    }
                }
            }








        }
    }
}
