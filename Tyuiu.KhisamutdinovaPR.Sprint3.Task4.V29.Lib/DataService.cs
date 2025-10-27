using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task3.V29.Lib
{
    public class DataService: ISprint3Task4V29
    {
        public double Calculate(int startValue, int stopValue)
        {
            // Проверка корректности диапазона
            if (startValue > stopValue)
            {
                throw new ArgumentException("Начальное значение не может быть больше конечного");
            }

            double sum = 0; // Инициализация суммы

            // Проходим по всем значениям x в заданном диапазоне
            for (int x = startValue; x <= stopValue; x++)
            {
                // Пропускаем x = 0, так как при x=0 будет деление на ноль
                if (x == 0)
                {
                    continue; // Переходим к следующей итерации цикла
                }

                // Вычисляем значение функции y = cos(x) / x
                double cosX = Math.Cos(x); // Вычисляем косинус x
                double y = cosX / x;       // Вычисляем значение функции

                // Добавляем значение к сумме
                sum += y;
            }

            // Округляем сумму до 2 знаков после запятой
            return Math.Round(sum, 2);
        }
    }
}