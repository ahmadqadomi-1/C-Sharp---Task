using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Task_26_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            int x = 10;
            int y = 9;
            Console.WriteLine(Math.Min(x, y));

            //Task 2.
            Console.Write("enter your fav num here!");
            int signNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sign(signNumber));

            //Console.WriteLine("enter here your Last num phone");
            //int numPhone = int.Parse(Console.ReadLine());
            //Console.WriteLine(numPhone[0]);

            //Task 3.
            int[] arr = { 0, -1, 4 };
            Array.Sort(arr);
            Array.Reverse(arr);
            Console.WriteLine($"{arr[0]} , {arr[1]} , {arr[2]}");

            //Task 4.
            int[] arr01 = { -5, -2, -6, 0, -1 };
            Array.Sort(arr01);
            Console.WriteLine(arr01[arr01.Length - 1]);

            //Task 5.
            Console.Write("please inter your car speed in kilimiters per hours");
            double kilo = double.Parse(Console.ReadLine());
            Console.WriteLine($" {kilo * 0.621371} miles per hour");

            //Task 6.
            Console.Write("Type Your fav Hours");
            int hour = int.Parse(Console.ReadLine());
            Console.Write("Enter Your lucky min in hours");
            int minute = int.Parse(Console.ReadLine());
            Console.WriteLine($"your lucky hours and min is {hour * 60 + minute}");

            //Task 7.
            Console.Write("Enter the total number of minutes: ");
            int totalMinutes = int.Parse(Console.ReadLine());
            int hours = totalMinutes / 60;
            int minutes = totalMinutes % 60;
            Console.WriteLine($"{hours} hours, {minutes} minutes");

            //Task 8.
            string[] elementWord = { "hours", "Minutes", "kilimiters" , "Reverse" , "speed" };
            Console.WriteLine(elementWord[0].Substring(0 , 3));
            Console.WriteLine(elementWord[1].Substring(0, 3));
            Console.WriteLine(elementWord[2].Substring(0, 3));
            Console.WriteLine(elementWord[3].Substring(0, 3));
            Console.WriteLine(elementWord[4].Substring(0, 3));

            //ctrl + k + d





        }
    }
}
