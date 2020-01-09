using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("PSAF44", "ASUS", 700);
            notebook.Display();

            Console.ReadKey();
        }
    }
    struct Notebook
    {
        string model;
        string brand;
        double price;

        public Notebook(string model, string brand, double price)
        {
            this.model = model;
            this.brand = brand;
            this.price = price;
        }
        public void Display()
        {
            Console.WriteLine($"Производитель - {brand}, Модель - {model}, Цена - {price}");
        }
    }
}
