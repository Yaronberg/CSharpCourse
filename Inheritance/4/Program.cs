using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ключ");
            string key = Console.ReadLine();
            string ProKey = "Pro";
            string ExpKey = "Exp";

            DocumentWorker access = new DocumentWorker(); 

            if (String.Compare(key, ProKey, StringComparison.OrdinalIgnoreCase) == 0)
            {
                access = new ProDocumentWorker();
            }
            else if (String.Compare(key, ExpKey, StringComparison.OrdinalIgnoreCase) == 0)
            {
                access = new ExpertDocumentWorker();
            }

            access.OpenDocumet();
            access.EditDocument();
            access.SaveDocument();

            Console.ReadKey();
        }
    }
}
