using System;
using Tyuiu.KhisamutdinovaPR.Sprint3.Task2.V3.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task2.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнила: Хисамутдинова Полина Руслановна | Вариант 3";

            DataService ds = new DataService();

            int x = 4;
            double result = ds.CalculateSeriesSum(x);

            Console.WriteLine("************************************************************");
            Console.WriteLine("* Спринт #3                                                *");
            Console.WriteLine("* Тема: Цикл do...while                                    *");
            Console.WriteLine("* Задание #2                                               *");
            Console.WriteLine("* Вариант 3                                                *");
            Console.WriteLine("* Выполнила: Хисамутдинова Полина Руслановна, ПКТб-25-1    *");
            Console.WriteLine("************************************************************");
            Console.WriteLine($"Результат вычисления суммы ряда при x = {x} равен: {result}");
            Console.WriteLine("************************************************************");

            Console.ReadKey();
        }
    }
}
