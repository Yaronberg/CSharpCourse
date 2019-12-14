using System;
using System.Collections.Generic;
using System.Text;

namespace _3
{
    class Ship : Vehicle
    {
        const string name = "Ship";
        public int Passengers { get; set; }
        public string Port { get; set; }
        public Ship (double price, int speed, string year, int passengers, string port): base(price, speed, year)
        {
            this.Passengers = passengers;
            this.Port = port;
        }
        public override void Info()
        {
            Console.Write($"Type - {name}, ");
            base.Info();
            Console.Write($"Passengers - {Passengers}, Port - {Port} \n");
        }
    }
}
