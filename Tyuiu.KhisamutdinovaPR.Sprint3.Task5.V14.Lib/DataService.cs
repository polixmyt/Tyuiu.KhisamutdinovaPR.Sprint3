using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KhisamutdinovPR.Sprint3.Task5.V14.Lib
{
    public class DataService: ISprint3Task5V14
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            // Проверка корректности диапазонов
            if (startValue1 > stopValue1 || startValue2 > stopValue2)
            {
                throw new ArgumentException("Начальные значения не могут быть больше конечных");
            }

            double totalSum = 0; // Общая сумма

            // Внешний цикл по i (первый диапазон)
            for (int i = startValue1; i <= stopValue1; i++)
            {
                // Внутренний цикл по k (второй диапазон)
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    // Вычисляем значение: sin(x) + 2/k
                    double term = Math.Sin(x) + (2.0 / k);

                    // Добавляем к общей сумме
                    totalSum += term;
                }
            }

            // Округляем результат до 3 знаков после запятой
            return Math.Round(totalSum, 3);
        }
    }
}