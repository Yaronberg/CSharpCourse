using System;
using System.Collections.Generic;
using System.Text;

namespace _3
{
    class Car : Vehicle
    {
        const string name = "Car";

        public Car(double price, int speed, string year) : base(price, speed, year) 
        { }


        public override void Info()
        {
            Console.Write($"Type - {name}, ");
            base.Info();
            Console.WriteLine();
        }
    }
}
