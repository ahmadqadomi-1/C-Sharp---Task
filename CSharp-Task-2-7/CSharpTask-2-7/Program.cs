using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharpTask_2_7.Program.Car;

namespace CSharpTask_2_7
{
    internal class Program
    {
        //Task 1.1
        internal interface ISound
        {
            void MakeSound();
        }

        //Task 1.2
        internal abstract class Animal
        {
            public Animal(string name)
            {
                this.Name = name;
            }
            public string Name { get; set; }
            public abstract void Eat();
            public void Sleep()
            {
                Console.WriteLine($"{this.Name} is sleeping");
            }
        }

        //Task 1.3
        //Task 1.3.1
        internal class Dog : Animal, ISound
        {
            public Dog(string name) : base(name) { }
            public override void Eat() { Console.WriteLine($"The {Name} is eating Dog's food"); }
            public void MakeSound() { Console.WriteLine($"{Name} (3ow)"); }
        }
        //Task 1.3.2
        internal class Cat : Animal, ISound
        {
            public Cat(string name) : base(name) { }

            public override void Eat() { Console.WriteLine($"The {Name} is eating Cat's food"); }
            public void MakeSound() { Console.WriteLine($"{Name} (Meow)"); }
        }


        //Task 2.1
        public class Car
        {
            public string Make { get; set; }
            public int Year { get; set; }
            public string Type { get; set; }
            public decimal Price { get; set; }
            public string Model { get; set; }
            public string PalletNo { get; set; }
            public string Color { get; set; }

            public Car(string make, int year, string type, decimal price, string model, string palletNo, string color)
            {
                Make = make;
                Year = year;
                Type = type;
                Price = price;
                Model = model;
                PalletNo = palletNo;
                Color = color;
            }

            //Task 2.2
            public void DisplayInfo(string make, int year)
            {
                Console.WriteLine($"Make: {make}, Year: {year}");
            }

            //Task 2.3

            public void DisplayInfo(string make)
            {
                Console.WriteLine($"Make: {make}");
            }

            //Task 2.4

            public virtual void Display()
            {
                Console.WriteLine("Welcome Car");
                Console.WriteLine($"Make: {Make}, Year: {Year}, Type: {Type}, Price: {Price}, Model: {Model}, Pallet No: {PalletNo}, Color: {Color}");
            }

            //Task 2.5

            public class BMW : Car
            {
                public BMW(string make, int year, string type, decimal price, string model, string palletNo, string color)
                    : base(make, year, type, price, model, palletNo, color)
                {
                }

                public override void Display()
                {
                    Console.WriteLine("Welcome BMW");
                    Console.WriteLine($"Made in: {Make}, Year: {Year}, Type: {Type}, Price: {Price}, Model: {Model}, Pallet No: {PalletNo}, Color: {Color}");
                }
            }


        }

        static void Main(string[] args)
        {
            //Task 1
            Cat cat = new Cat("Baggera");
            Dog dog = new Dog("scooby-doo");
            cat.Eat();
            dog.Eat();
            cat.Sleep();
            dog.Sleep();
            cat.MakeSound();
            dog.MakeSound();


            //Task 2
            BMW bMW = new BMW("M5", 2021, "BMW", 105495, "M5 1985-2021", "12-13333", "black");
            bMW.Display();

        }
    }
}
