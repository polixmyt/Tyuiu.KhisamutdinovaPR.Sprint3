using System;
using Tyuiu.KhisamutdinovaPR.Sprint3.Task7.V9.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task7.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Задание 7 | Вариант 9";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Таск 7. Табулирование функции (массив)                                  *");
            Console.WriteLine("* Вариант 9                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* F(x) = (2x - 3)/(cos(x) - 2x) + 5x - sin(x)                             *");
            Console.WriteLine("* Диапазон: [-5; 5], шаг 1. Деление на ноль -> вернуть 0.                 *");
            Console.WriteLine("* Округление значений до двух знаков после запятой.                       *");
            Console.WriteLine("***************************************************************************\n");

            int start = -5, end = 5;

            var ds = new DataService();
            double[] values = ds.Tabulate(start, end);

            Console.WriteLine("    x\t|\tF(x)");
            Console.WriteLine("---------+---------------------------");

            for (int i = 0; i < values.Length; i++)
            {
                int x = start + i;
                Console.WriteLine($"{x,5}\t|\t{values[i],6:F2}");
            }

            Console.WriteLine("\nМассив результатов:");
            Console.WriteLine("[ " + string.Join("; ", values) + " ]");

            Console.WriteLine("\nГотово. Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}