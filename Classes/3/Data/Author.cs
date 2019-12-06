using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Data
{
    class Author
    {
        public string NameAuthor { get; set; }   
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Автор - " + NameAuthor);
            Console.ResetColor();

        }
    }
}
