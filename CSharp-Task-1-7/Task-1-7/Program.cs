using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(2015, "Nissan leaf", 9000, "leaf", "10-    1", "black");

            Console.WriteLine(car.display);
            Bmw bmw = new Bmw(2008, "mercedes", 21000, "E200", "18.25299", "Grey");
            Console.WriteLine(bmw.display);
        }
    }
}
