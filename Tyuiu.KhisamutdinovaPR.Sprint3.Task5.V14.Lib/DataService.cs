using System;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task5.V14.Lib
{
    public class DataService
    {
        public double GetSumSumSeries(int iStart, int iEnd, int kStart, int kEnd, double x)
        {
            // Проверка корректности диапазонов
            if (iStart > iEnd || kStart > kEnd)
            {
                throw new ArgumentException("Начальные значения не могут быть больше конечных");
            }

            double totalSum = 0; // Общая сумма

            // Внешний цикл по i от iStart до iEnd
            for (int i = iStart; i <= iEnd; i++)
            {
                double innerSum = 0; // Внутренняя сумма для каждого i

                // Внутренний цикл по k от kStart до kEnd
                for (int k = kStart; k <= kEnd; k++)
                {
                    // Вычисляем значение: sin(x) + 2/k
                    double term = Math.Sin(x) + (2.0 / k);

                    // Добавляем к внутренней сумме
                    innerSum += term;
                }

                // Добавляем внутреннюю сумму к общей сумме
                totalSum += innerSum;
            }

            // Округляем результат до 3 знаков после запятой
            return Math.Round(totalSum, 3);
        }
    }
}