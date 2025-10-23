using System;
using Tyuiu.KhisamutdinovaPR.Sprint3.Task1.V3.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task1.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Задание #1 | Вариант #3 | Выполнила: Хисамутдинова П.Р. | ПКТб-25-1";
            Console.WriteLine("********************************************************");
            Console.WriteLine("* Спринт 3                                             *");
            Console.WriteLine("* Тема: Цикл while                                     *");
            Console.WriteLine("* Задание 1                                            *");
            Console.WriteLine("* Вариант 3                                            *");
            Console.WriteLine("* Выполнила: Хисамутдинова П.Р. (KhisamutdinovaPR)     *");
            Console.WriteLine("********************************************************");
            Console.WriteLine("* Формула: p = Π(k=1..10) ( k / (cos(5)+1)^2 )         *");
            Console.WriteLine("********************************************************");

            var ds = new DataService();
            double result = ds.Calculate();

            Console.WriteLine($"Результат: {result}");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}