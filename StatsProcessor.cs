using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemoCodes
{
    internal class StatsProcessor
    {

        // we r passing array in each function
        public decimal Mean()
        {
            int[] array = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };
            int sum = 0 ;
            decimal mean = 0;

            //Mean Calculation
            foreach (int test in array)
            {
                sum = sum + test;
            }
            mean = (decimal)sum / array.Length;
            //Console.WriteLine($"Mean is {mean}");
            return mean;

        }




        public int Median()
        {
            //Median Calculation
            int[] array = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };
            Array.Sort(array);
            //Console.WriteLine(array.Length);
            int m = (array.Length) / 2;
            //Console.WriteLine($"Median is {array[m]}");
            return m;


        }




        public int Mode()
        {
            int[] array = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };
            int maxcount = 0, maxnum = 0;
            //Mode Calculation
            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;
                for (int j = 1; j < array.Length - 1; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                }
                if (count > maxcount)
                {
                    maxcount = count;
                    maxnum = array[i];
                }
            }
            //Console.WriteLine($"Mode is {maxnum}");
            return maxnum;
        }




    }
}