using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_tasks_27_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1.

            //Task 1.1

            int[] arr01 = { 1, 7, 9, 45 };
            Console.WriteLine(string.Join(" , ", arr01));

            //Task 1.2

            string[] arr02 = { "Str", "alex", "moh" };
            Console.WriteLine("[" + string.Join(" , ", arr02) + " ]");

            //Task 1.3

            string[] arr03 = { "the", "fox", "over", "lazy", "dog" };
            Console.WriteLine(string.Join(" , ", arr03));


            //Task 2.

            String[] fruits = { "Tomato", "Banana", "Watermelon" };
            int indexTomato = Array.IndexOf(fruits, "Tomato");
            int indexBanana = Array.IndexOf(fruits, "Banana");
            Console.WriteLine($"The indexOf Tomato is : {indexTomato}");
            Console.WriteLine($"The indexOf Banana is : {indexBanana}");


            //Task 3.

            string[] arrFood = { "Food 1", "Food 2", "Food 3", "Food 4", "Food 5" };
            string[] arrMovie = { "Movie 1", "Movie 2", "Movie 3", "Movie 4" };
            string[] arrSport = { "Sport 1", "Sport 2", "Sport 3" };
            Console.WriteLine(string.Join(" , ", arrFood));
            Console.WriteLine(string.Join(" , ", arrMovie));
            Console.WriteLine(string.Join(" , ", arrSport));


            //Task 4.

            int[] treeNum = { 5, 10, 15 };
            int sum01 = treeNum[0] + treeNum[1] + treeNum[2];
            Console.WriteLine(sum01);


            //Task 5.
            //for (int i = 1; i <= 100; i += 2)
            //{
            //    Console.WriteLine(i);
            //}

            Console.Write("[");
            for (int i = 1; i <= 100; i += 2)
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }
                Console.Write(i);
            }
            Console.WriteLine("]");


            //Task 6.

            int raws = 5;
            for (int i = 0; i < raws; i++)
            {
                for (int s = -50; s < raws - i; s++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }


            //Task 7.

            int number = 1;

            for (int i = 1; i <= 4; i++)
            {
                // Print spaces
                for (int j = 1; j <= 4 - i; j++)
                {
                    Console.Write(" ");
                }
                // Print numbers
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(number + " ");
                    number++;
                }
                Console.WriteLine();
            }









        }
    }
}
