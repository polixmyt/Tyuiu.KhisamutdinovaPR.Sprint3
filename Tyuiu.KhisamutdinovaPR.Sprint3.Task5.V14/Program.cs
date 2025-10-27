using System;
using Tyuiu.KhisamutdinovPR.Sprint3.Task5.V14.Lib;

namespace Tyuiu.KhisamutdinovPR.Sprint3.Task5.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Хисамутдинов П. Р. | ИСТНб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Хисамутдинов П. Р. | ИСТНб-23-1                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить значение двойной суммы:                                       *");
            Console.WriteLine("* y = ∑[i=1,3] ∑[k=1,14] (sin(x) + 2/k) при x = 5                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 5;
            int startValue1 = 1; // начало диапазона для i
            int stopValue1 = 3;  // конец диапазона для i
            int startValue2 = 1; // начало диапазона для k
            int stopValue2 = 14; // конец диапазона для k

            Console.WriteLine($"* Значение x: {x}                                                          *");
            Console.WriteLine($"* Диапазон i: от {startValue1} до {stopValue1}                                            *");
            Console.WriteLine($"* Диапазон k: от {startValue2} до {stopValue2}                                           *");
            Console.WriteLine($"* Формула: y = ∑[i=1,3] ∑[k=1,14] (sin(x) + 2/k)                          *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Создаем объект сервиса
            DataService ds = new DataService();

            // Вычисляем значение двойной суммы
            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Console.WriteLine($"Значение двойной суммы y = {result}");

            // Проверочные вычисления
            Console.WriteLine("\nПроверочные вычисления:");
            double sinX = Math.Sin(x);
            Console.WriteLine($"sin({x}) = {Math.Round(sinX, 6)}");

            double sum2k = 0;
            for (int k = 1; k <= 14; k++)
            {
                sum2k += 2.0 / k;
            }
            Console.WriteLine($"Сумма 2/k для k=1..14 = {Math.Round(sum2k, 6)}");

            double totalSin = 3 * 14 * sinX;
            double total2k = 3 * sum2k;
            Console.WriteLine($"Общая часть от sin(x): {Math.Round(totalSin, 6)}");
            Console.WriteLine($"Общая часть от 2/k: {Math.Round(total2k, 6)}");
            Console.WriteLine($"Итог: {Math.Round(totalSin + total2k, 3)}");

            Console.ReadKey();
        }
    }
}