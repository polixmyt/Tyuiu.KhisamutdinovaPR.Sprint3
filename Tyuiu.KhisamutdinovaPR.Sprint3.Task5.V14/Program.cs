using System;
using Tyuiu.KhisamutdinovaPR.Sprint3.Task5.V14.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task5.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Variant 14 | ИСТНб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Variant 14 | ИСТНб-23-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить значение двойной суммы:                                       *");
            Console.WriteLine("* y = ∑[i=1,3] ∑[k=1,14] (sin(x) + 2/k) при x = 5                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int iStart = 1;
            int iEnd = 3;
            int kStart = 1;
            int kEnd = 14;
            double x = 5;

            Console.WriteLine($"* Диапазон i: от {iStart} до {iEnd}                                          *");
            Console.WriteLine($"* Диапазон k: от {kStart} до {kEnd}                                         *");
            Console.WriteLine($"* Значение x: {x}                                                          *");
            Console.WriteLine($"* Формула: y = ∑[i=1,3] ∑[k=1,14] (sin(x) + 2/k)                          *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Создаем объект сервиса
            DataService ds = new DataService();

            // Вычисляем значение двойной суммы
            double result = ds.GetSumSumSeries(iStart, iEnd, kStart, kEnd, x);

            Console.WriteLine($"Значение двойной суммы y = {result}");

            // Дополнительная информация для понимания вычислений
            Console.WriteLine("\nДополнительная информация:");
            Console.WriteLine($"sin({x}) = {Math.Round(Math.Sin(x), 3)}");
            Console.WriteLine($"Количество итераций по i: {iEnd - iStart + 1}");
            Console.WriteLine($"Количество итераций по k: {kEnd - kStart + 1}");
            Console.WriteLine($"Общее количество вычислений: {(iEnd - iStart + 1) * (kEnd - kStart + 1)}");

            Console.ReadKey();
        }
    }
}