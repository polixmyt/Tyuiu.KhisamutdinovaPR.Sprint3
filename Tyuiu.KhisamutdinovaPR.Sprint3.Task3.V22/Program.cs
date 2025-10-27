using System;
using Tyuiu.KhisamutdinovaPR.Sprint3.Task3.V22.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task3.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнила: Хисамутдинова Полина Руслановна | ПКТБ-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Выполнила: Хисамутдинова Полина Руслановна | ПКТБ-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach подсчитать максимальное количество букв b,       *");
            Console.WriteLine("* находящихся на соседних позициях в строке: 'tbtbbb dsthg bbsg'          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string str = "tbtbbb dsthg bbsg";
            char targetChar = 'b';

            Console.WriteLine($"Исходная строка: '{str}'");
            Console.WriteLine($"Искомый символ: '{targetChar}'");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Создаем объект сервиса
            DataService ds = new DataService();

            // Вычисляем максимальное количество подряд идущих символов 'b'
            int result = ds.GetMaxCharCount(str, targetChar);

            Console.WriteLine($"Максимальное количество букв '{targetChar}' на соседних позициях: {result}");

            Console.ReadKey();
        }
    }
}