using System;
using Tyuiu.KhisamutdinovaPR.Sprint3.Task5.V14.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task5.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Таск 5 | Вариант 14";
            Console.WriteLine("*********************************************");
            Console.WriteLine("* Спринт #3                                 *");
            Console.WriteLine("* Таск 5. Двойная сумма                     *");
            Console.WriteLine("* Вариант 14                                *");
            Console.WriteLine("*********************************************\n");

            double x = 5;                // по условию
            var ds = new DataService();

            double y = ds.GetSumSumSeries(1, 3, 1, 14, x);

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"Результат: {Math.Round(y, 3)}");
        }
    }
}