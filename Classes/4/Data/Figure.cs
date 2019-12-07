using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Data
{
    class Figure
    {

        public (double, string) LengthSide(Point A, Point B) //params Point[] points
        {

            var result = (side: Math.Sqrt(Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2)), name: (A.Name + B.Name));
            return result;
        }
        public void PerimeterCalculator(params Point[] points)
        {
            var perim = (side: 0.0, name: "");
            int last = points.Length - 1;
            for (int i = 0; i < last; i++)
            {
                perim.side += LengthSide(points[i], points[i + 1]).Item1;
                perim.name += LengthSide(points[i], points[i + 1]).Item2 + "-";
            }
            perim.side += LengthSide(points[0], points[last]).Item1;
            perim.name += LengthSide(points[0], points[last]).Item2;


            Console.WriteLine($"Периметр фигуры {perim.name} = " + perim.side);
        }
    }
}
