using tyuiu.cources.programming.interfaces.Sprint3;
using System;
using System;

namespace Tyuiu.KhisamutdinovPR.Sprint3.Task1.V3.Lib
{
    public class DataService: ISprint3Task1V3
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            // Инициализируем произведение единицей (нейтральный элемент для умножения)
            double product = 1;

            // Начальное значение k
            int k = 1;

            // Вычисляем константу один раз для оптимизации
            double denominator = Math.Pow(Math.Cos(5) + 1, 2);

            // Цикл while от k=1 до k=10
            while (k <= 10)
            {
                // Вычисляем текущий элемент ряда: k / (cos(5) + 1)²
                double term = k / denominator;

                // Умножаем произведение на текущий элемент
                product *= term;

                // Увеличиваем k на 1 для следующей итерации
                k++;
            }

            // Округляем результат до 3 знаков после запятой
            return Math.Round(product, 3);
        }

        public double GetMultiplySeries()
        {
            throw new NotImplementedException();
        }
    }
}

