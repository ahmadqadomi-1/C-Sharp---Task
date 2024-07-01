using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_30_6
{

    internal class Program
    {


            public static void Above1950s(int[] years)
            {
                for (int i = 0; i < years.Length; i++)
                {
                    if (years[i] >= 1950)
                    Console.WriteLine(years[i]);
                }
            }
        static void Main(string[] args)
        {
            Class1 AvNum = new Class1();

            //Task 1.

            double[] numbers = { 1 , 2 , 3  , 4 , 5 , 6 , 7 , 8 , 9 , 10 }; 
            AvNum.AvaSum(numbers);

            Console.WriteLine("------------------------------------------------------");

            //Task 2.

            Console.Write(" Choose a number from 1 to 10 :  ");
            double num1 = double.Parse (Console.ReadLine() );
            for (int i = 1; i <= num1; i++)
            {
                AvNum.Cube(i);
            }

            Console.WriteLine("------------------------------------------------------");


            //Task 3.

            int[] arr03 = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };

            Above1950s(arr03);
            Console.WriteLine("------------------------------------------------------");


            //Task 4.

            int Years = 24;
            Console.WriteLine(AvNum.YearsToDay(Years));

            Console.WriteLine("------------------------------------------------------");


            //Task 5.

            Informations detailsInformation = new Informations(24, "male", "Ahmad", "ahmad.alqadomi02@gmail.com", 15667, "0798453201");

            detailsInformation.Display();
        }
    }
}
