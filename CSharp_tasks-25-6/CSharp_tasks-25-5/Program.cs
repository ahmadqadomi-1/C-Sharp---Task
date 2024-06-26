using System;
using System.Xml.Linq;

namespace CSharp_tasks_25_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1.
            //Console.WriteLine("Press Fourth Cohort to continue...");
            //string cohor = Console.ReadLine();
            //Console.WriteLine($"Hello, {cohor}!");

            //Task 2.
            //0)
            Double num1 = 2.5555;
            Console.WriteLine(num1);

            //1)

            String greeting = "Hello Coatch";
            Console.WriteLine(greeting);

            //2)

            char myChar = 'A';
            Console.WriteLine($"The first character of my name is: {myChar}");

            //3)

            bool trueBl = true;
            bool falseBl = false;
            Console.WriteLine($"Qadomi solved all his tasks? {trueBl}");

            //4)

            int myAge = 24;
            int yearOfBirth = 2000;

            int sum = myAge + yearOfBirth;
            Console.WriteLine($"this year is {sum}");

            //5)

            const double number01 = 3.14159;
            const int number02 = 30;
            Console.WriteLine(number01 + number02);

            //Task 3.
            string[] cars = new string[] { "mercedes", "BMW", "audi " };
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars.Length);
            Console.WriteLine(string.Join(" " ,cars));

            //Task 4.

            Console.Write("Enter your first name");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name");
            object lastName = Console.ReadLine();
            Console.Write("Enter your year of birth");
            int yourYearOfBirth = int.Parse( Console.ReadLine() );
            Console.WriteLine(firstName + " " + lastName + " " + yourYearOfBirth);
            //Task 5.

            int[] elements = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Console.WriteLine(string.Join(" ", elements));
            //Task 6.

            int[] arr = { 2 , 5 , 8 };
            int sum01 = arr[0] + arr[1] + arr[2];
            Console.WriteLine(sum01);




























        }
    }
}
