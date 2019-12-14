using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle ship = new Ship(650004.25, 70, "1995", 600, "Sydney");
            ship.Info();

            Vehicle plane = new Plane(342204.62, 500, "2010", 200, 100);
            plane.Info();

            Vehicle car = new Car(25432.60, 120, "2007");
            car.Info();
            Console.ReadKey();
        }
    }
}
