using System;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task0.V15.Lib
{
    public class DataService
    {
        public double Calculate(double t)
        {
            double s = 0;
            for (int k = 1; k <= 10; k++)
            {
                s += (Math.Pow(t, k) + 2.0 / (k + 1)) * Math.Sin(t);
            }
            return Math.Round(s, 3);
        }
    }
}