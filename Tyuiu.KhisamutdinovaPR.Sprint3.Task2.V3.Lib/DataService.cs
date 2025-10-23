using System;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task2.V3.Lib
{
    public class DataService
    {
        public double CalculateSeriesSum(int x)
        {
            double s = 0;
            int i = 1;

            do
            {
                s += (Math.Pow(x, 2) * i) + 1;
                i++;
            }
            while (i <= 15);

            return s;
        }
    }
}