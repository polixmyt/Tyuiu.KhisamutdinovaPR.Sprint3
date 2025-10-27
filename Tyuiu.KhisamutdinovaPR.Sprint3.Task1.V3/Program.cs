using System;
using Tyuiu.KhisamutdinovPR.Sprint3.Task1.V3.Lib;

namespace Tyuiu.KhisamutdinovPR.Sprint3.Task1.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Хисамутдинов П. Р. | ПКТБ-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Хисамутдинов П. Р. | ПКТБ-25-1                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет произведение *");
            Console.WriteLine("* ряда по формуле: p = ∏[k=1,10] (k / (cos(5) + 1)²)                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Формула: p = ∏[k=1,10] (k / (cos(5) + 1)²)                             *");
            Console.WriteLine("* Диапазон k: от 1 до 10                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Создаем объект сервиса
            DataService ds = new DataService();

            // Вычисляем произведение ряда
            double result = ds.GetMultiplySeries();

            // Выводим результат
            Console.WriteLine($"Произведение ряда = {result}");

            Console.ReadKey();
        }
    }
}