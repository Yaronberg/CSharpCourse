using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Data
{
    class Rectangle
    {
        double side1 { get; }
        double side2 { get; }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        double AreaCalculator()
        {
            return side1 * side2;
        }
        double PerimeterCalculator()
        {
            return 2*(side1 + side2);
        }
        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }
        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
        }
    }
}
