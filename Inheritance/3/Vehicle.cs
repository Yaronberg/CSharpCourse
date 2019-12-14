using System;
using System.Collections.Generic;
using System.Text;

namespace _3
{
    abstract class Vehicle
    {
        public double Price {get; set;}
        public int Speed { get; set; }
        public DateTime Year { get; set; }

        public Vehicle(double price, int speed, string year)
        {
            this.Price = price;
            this.Speed = speed;
            this.Year = DateTime.ParseExact(year, "yyyy",
                                System.Globalization.CultureInfo.InvariantCulture); ;
        }
        public virtual void Info()
        {
            Console.Write($"Price - {Price}, Speed - {Speed}, Year of manufacture - {Year.ToString("yyyy")}, ");
        }
    }
}
