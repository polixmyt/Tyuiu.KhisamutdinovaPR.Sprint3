using System;
using Tyuiu.KhisamutdinovaPR.Sprint3.Task3.V29.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task3.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Variant 29 | ИСТНб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Variant 29 | ИСТНб-23-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где х принимает значения от -5 до 5, вычислить значение     *");
            Console.WriteLine("* функции y = cos(x)/x. При x = 0 пропустить значение.                    *");
            Console.WriteLine("* Полученные значения суммировать.                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"* Старт диапазона: {startValue}                                           *");
            Console.WriteLine($"* Конец диапазона: {stopValue}                                            *");
            Console.WriteLine($"* Функция: y = cos(x)/x                                                   *");
            Console.WriteLine($"* При x = 0 значение пропускается                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Создаем объект сервиса
            DataService ds = new DataService();

            // Вычисляем сумму значений функции
            double result = ds.Calculate(startValue, stopValue);

            Console.WriteLine($"Сумма значений функции y = cos(x)/x на отрезке [{startValue}, {stopValue}]");
            Console.WriteLine($"(исключая x = 0) равна: {result}");

            // Дополнительно выводим таблицу значений для наглядности
            Console.WriteLine("\nТаблица значений функции:");
            Console.WriteLine("+----------+-----------+");
            Console.WriteLine("|    x     |    y(x)   |");
            Console.WriteLine("+----------+-----------+");

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    Console.WriteLine("|    0     |   пропуск  |");
                }
                else
                {
                    double y = Math.Cos(x) / x;
                    Console.WriteLine("|{0,5:d}     |  {1,7:f3}  |", x, Math.Round(y, 3));
                }
            }
            Console.WriteLine("+----------+-----------+");

            Console.ReadKey();
        }
    }
}