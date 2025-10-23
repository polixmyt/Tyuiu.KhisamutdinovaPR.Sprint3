// =========================  LIB  =========================
// Tyuiu.KhisamutdinovaPR.Sprint3.Task7.V9.Lib/DataService.cs
using System;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task7.V9.Lib
{
    public class DataService
    {
        /// <summary>
        /// Табулирует функцию F(x) = (2x-3)/(cos(x)-2x) + 5x - sin(x)
        /// на отрезке [start; end] с шагом 1.
        /// При делении на ноль возвращает 0 для значения функции.
        /// Округление до 2 знаков.
        /// </summary>
        public double[] Tabulate(int start, int end)
        {
            if (end < start) throw new ArgumentException("end < start");

            int len = end - start + 1;
            var result = new double[len];

            int idx = 0;
            for (int x = start; x <= end; x++, idx++)
            {
                double denom = Math.Cos(x) - 2 * x;
                double fx;

                if (Math.Abs(denom) < 1e-12)
                {
                    fx = 0.0;
                }
                else
                {
                    fx = (2 * x - 3) / denom + 5 * x - Math.Sin(x);
                }

                result[idx] = Math.Round(fx, 2, MidpointRounding.AwayFromZero);
            }

            return result;
        }
    }
}