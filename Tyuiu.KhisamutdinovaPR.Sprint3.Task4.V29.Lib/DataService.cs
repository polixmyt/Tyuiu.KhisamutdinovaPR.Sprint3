using System;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task4.V29.Lib
{
    public class DataService
    {
        public double GetSumSeries()
        {
            double sum = 0;

            for (int x = -5; x <= 5; x++)
            {
                if (x == 0) continue;

                double y = Math.Cos(x) / x;
                sum += y;
            }

            return Math.Round(sum, 3);
        }
    }
}