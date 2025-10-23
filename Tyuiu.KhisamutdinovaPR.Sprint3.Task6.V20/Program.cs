using System;
using Tyuiu.KhisamutdinovaPR.Sprint3.Task6.V20.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task6.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнила: Хисамутдинова П.Р. | Вариант 20";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Использование операторов цикла for                                *");
            Console.WriteLine("* Задание №6                                                              *");
            Console.WriteLine("* Вариант №20                                                             *");
            Console.WriteLine("* Выполнила: Хисамутдинова Полина Руслановна, группа ПКТб-25-1            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Найти среди целых чисел, принадлежащих отрезку [20, 32],                *");
            Console.WriteLine("* количество всех делителей меньше 12.                                    *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int start = 20;
            int end = 32;
            int limit = 12;

            int result = ds.GetDivisorsCountInRange(start, end, limit);

            Console.WriteLine($"Отрезок: [{start}; {end}]");
            Console.WriteLine($"Порог делителя: меньше {limit}");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine($"Результат: {result}");
            Console.WriteLine("--------------------------------------------------------------------------");

            Console.WriteLine("Нажмите любую клавишу для завершения...");
            Console.ReadKey();
        }
    }
}
