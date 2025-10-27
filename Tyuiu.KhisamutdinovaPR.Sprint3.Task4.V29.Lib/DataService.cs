using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task4.V29.Lib
{
    public class DataService : ISprint3Task4V29
    {
        public double Calculate(int startValue, int stopValue)
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

        public double Calculate()
        {
            throw new NotImplementedException();
        }
    }
}