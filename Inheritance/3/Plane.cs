using System;
using System.Collections.Generic;
using System.Text;

namespace _3
{
    class Plane : Vehicle
    {
        const string name = "Plane";
        public int Height { get; set; }
        public int Passengers { get; set; }

        public Plane(double price, int speed, string year, int passengers, int height) : base(price, speed, year)
        {
            this.Passengers = passengers;
            this.Height = height;
        }
        public override void Info()
        {
            Console.Write($"Type - {name}, ");
            base.Info();
            Console.Write($"Passengers - {Passengers}, Height - {Height} \n");
        }

    }
}
