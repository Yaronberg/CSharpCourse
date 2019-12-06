using _3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            
            Console.WriteLine("Введите автора книги: ");
            string author = Console.ReadLine();
            Console.WriteLine("Введите название книги: ");
            string title = Console.ReadLine();
            Console.WriteLine("Введите содержание книги: ");
            string content = Console.ReadLine();

            book.AddInfo(author, title, content);
            Console.WriteLine("Вы ввели: ");
            book.Show();
            
            Console.ReadKey();
        }
    }
}
