using _4.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Point pointA = new Point(10, -4, "A");
            Point pointB = new Point(10, 17, "B");
            Point pointC = new Point(4, 9, "C");
            Point pointD = new Point(16, 6, "D");
            //Point pointE = new Point(-2, 3, "E");
            //Point pointG = new Point(-5, 5, "G");

            Figure figure = new Figure();
            figure.PerimeterCalculator(pointA, pointB, pointC, pointD);

            Console.ReadKey();
        }
    }
}
