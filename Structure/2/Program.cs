using System;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Train[] trains = new Train[7];

            for (int i = 0; i < trains.Length + 1; i++) // ввод данных 
            {
                Console.Write($"Введите номер поезда{i}: ");
                int trainNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите пункт назначения: ");
                string destination = Console.ReadLine();
                Console.Write("Введите время отправления: ");
                string time = Console.ReadLine();
                Console.WriteLine();

                trains[i] = new Train(trainNumber, destination, time);
            }
            
            Array.Sort(trains, (x, y) => x.trainNumber.CompareTo(y.trainNumber)); //сортировка массива по номеру поезда

            Console.Write("Для поиска информации введите номер поезда: ");

            while (true) 
            {
                int num = Convert.ToInt32(Console.ReadLine()); //номер поезда введен с клавиатуры
                Train q = trains.FirstOrDefault(x => x.trainNumber == num); //поиск структуры по номеру поезда
                
                if (q.trainNumber == num) 
                {
                    q.Display();
                    break;
                }
                else
                {
                    Console.WriteLine("Такого номера поезда нет, попробуйте другой номер");
                }
            }


            Console.ReadKey();
        }
        struct Train
        {
            public int trainNumber;
            public string destination;
            public string departureTime;

            public Train(int trainNumber, string destination, string departureTime)
            {
                this.trainNumber = trainNumber;
                this.destination = destination;
                this.departureTime = departureTime;
            }
            public void Display()
            {
                Console.WriteLine(trainNumber + "\n" + destination + "\n" + departureTime);
            }
        }
    }
}
