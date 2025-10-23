using System;
using tyuiu.cources.programming.interfaces.Sprint3;  

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task5.V14.Lib
{
    public class DataService : ISprint3Task5V14
    {
        // Сумма по двум индексам: i = iStart..iEnd, k = kStart..kEnd
        // y = Σ_i Σ_k (sin(x) + 2/k)
        public double GetSumSumSeries(int iStart, int iEnd, int kStart, int kEnd, double x)
        {
            double sum = 0.0;

            for (int i = iStart; i <= iEnd; i++)
            {
                for (int k = kStart; k <= kEnd; k++)
                {
                    sum += Math.Sin(x) + 2.0 / k;
                }
            }

            return sum;
        }

        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            throw new NotImplementedException();
        }
    }
}