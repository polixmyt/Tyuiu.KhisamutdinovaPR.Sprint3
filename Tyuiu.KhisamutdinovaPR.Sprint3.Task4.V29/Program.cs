using System;
using Tyuiu.KhisamutdinovaPR.Sprint3.Task4.V29.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task4.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнила: Хисамутдинова Полина Руслановна | Вариант 29";

            DataService ds = new DataService();

            Console.WriteLine("***********************************************");
            Console.WriteLine("* Спринт #3                                   *");
            Console.WriteLine("* Задание #4                                  *");
            Console.WriteLine("* Вариант #29                                 *");
            Console.WriteLine("* Выполнила: Хисамутдинова Полина Руслановна  *");
            Console.WriteLine("***********************************************");
            Console.WriteLine("* Условие:                                    *");
            Console.WriteLine("* На отрезке [-5;5] вычислить сумму y=cos(x)/x,*");
            Console.WriteLine("* пропустив x=0                               *");
            Console.WriteLine("***********************************************");

            double result = ds.GetSumSeries();

            Console.WriteLine($"Результат вычислений: {result}");
            Console.ReadKey();
        }
    }
}