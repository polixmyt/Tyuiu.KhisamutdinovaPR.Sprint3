using System;
using Tyuiu.KhisamutdinovaPR.Sprint3.Task6.V20.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task6.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Хисамутдинов П. Р. | ИСТНб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Хисамутдинов П. Р. | ИСТНб-23-1                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих      *");
            Console.WriteLine("* числовому отрезку [20, 32] сумму всех делителей меньше 12.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = 20;
            int stopValue = 32;

            Console.WriteLine($"* Старт диапазона: {startValue}                                           *");
            Console.WriteLine($"* Конец диапазона: {stopValue}                                            *");
            Console.WriteLine($"* Ищем делители: меньше 12                                                *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Создаем объект сервиса
            DataService ds = new DataService();

            // Вычисляем сумму делителей
            int result = ds.GetSumTheDivisors(startValue, stopValue);

            Console.WriteLine($"Сумма всех делителей меньше 12 в диапазоне [{startValue}, {stopValue}] = {result}");

            // Дополнительная информация - детальный анализ
            Console.WriteLine("\nДетальный анализ:");
            PrintDetailedAnalysis(startValue, stopValue);

            Console.ReadKey();
        }

        static void PrintDetailedAnalysis(int start, int stop)
        {
            Console.WriteLine("+----------+---------------------+----------+");
            Console.WriteLine("|  Число   | Делители < 12       |  Сумма   |");
            Console.WriteLine("+----------+---------------------+----------+");

            int totalSum = 0;

            for (int number = start; number <= stop; number++)
            {
                string divisors = "";
                int sumForNumber = 0;

                for (int d = 1; d < 12; d++)
                {
                    if (number % d == 0)
                    {
                        divisors += d + " ";
                        sumForNumber += d;
                    }
                }

                totalSum += sumForNumber;
                Console.WriteLine($"|{number,5}    | {divisors,-18} | {sumForNumber,5}    |");
            }

            Console.WriteLine("+----------+---------------------+----------+");
            Console.WriteLine($"| Общая сумма: {totalSum,40} |");
            Console.WriteLine("+-------------------------------------------+");
        }
    }
}
