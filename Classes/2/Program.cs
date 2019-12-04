using _2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Area - " + rectangle.Area);
            Console.WriteLine("Perimeter - " + rectangle.Perimeter);

            Console.ReadKey();
        }
    }
}
