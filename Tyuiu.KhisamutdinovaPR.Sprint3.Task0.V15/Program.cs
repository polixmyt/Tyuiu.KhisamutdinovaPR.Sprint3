using System;
using Tyuiu.KhisamutdinovaPR.Sprint3.Task0.V15.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task0.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнила Хисамутдинова Полина Руслановна | Вариант 15";

            DataService ds = new DataService();

            double t = 0.7;
            double result = ds.Calculate(t);

            Console.WriteLine("******************************************************");
            Console.WriteLine("* Спринт #3                                           *");
            Console.WriteLine("* Тема: Цикл for                                      *");
            Console.WriteLine("* Вариант: 15                                         *");
            Console.WriteLine("* Выполнила: Хисамутдинова Полина Руслановна          *");
            Console.WriteLine("******************************************************");
            Console.WriteLine($"t = {t}");
            Console.WriteLine($"Результат: {result}");
            Console.WriteLine("******************************************************");

            Console.ReadKey();
        }
    }
}