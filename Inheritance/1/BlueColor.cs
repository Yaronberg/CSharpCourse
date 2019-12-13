using System;
using System.Collections.Generic;
using System.Text;

namespace _1
{
    class BlueColor : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            base.Print(value);
            Console.ResetColor();
        }
    }
}
