using System;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task6.V20.Lib
{
    public class DataService : ISprint3Task6V20
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            // Проверка корректности диапазона
            if (startValue > stopValue)
            {
                throw new ArgumentException("Начальное значение не может быть больше конечного");
            }

            int sumDivisors = 0; // Сумма всех делителей меньше 12

            // Проходим по всем числам в заданном диапазоне
            for (int number = startValue; number <= stopValue; number++)
            {
                // Для каждого числа ищем делители меньше 12
                for (int divisor = 1; divisor < 12; divisor++)
                {
                    // Проверяем, является ли divisor делителем number
                    if (number % divisor == 0)
                    {
                        sumDivisors += divisor; // Суммируем делители
                    }
                }
            }

            return sumDivisors;
        }
    }
}