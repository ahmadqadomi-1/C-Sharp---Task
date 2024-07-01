using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_30_6
{
    internal class Class1
    {
        //Task 1 
        public void AvaSum(double[] arr01)
        {
            double sum = 0;
            for (int i = 0; i < arr01.Length; i++)
            {
                sum = sum + arr01[i];
            }
            double avarege = sum / arr01.Length;
            Console.WriteLine(sum);
            Console.WriteLine(avarege);
        }
        //Task 2
        public void Cube(double cubenum)
        {
            double number01 = cubenum * cubenum * cubenum;
            Console.WriteLine(number01);
        }
        //Task 3
        //public void Above1950s(int[] years)
        //{
        //    for (int i = 0; i < years.Length; i++)
        //    {
        //        if (years[i] >= 1950)
        //        {
        //            Console.WriteLine(years[i]);
        //        }
        //    }
        //}
        //Task 4
        public int YearsToDay(int years)
        {
            int days = years * 365; 
            return days;
        }
    }
}
