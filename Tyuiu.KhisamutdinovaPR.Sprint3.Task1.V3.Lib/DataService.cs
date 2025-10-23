using tyuiu.cources.programming.interfaces.Sprint3;
using System;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task1.V3.Lib
{
    public class DataService
    {
        // p = Π_{k=1..10} ( k / (cos(5) + 1)^2 )
        public double Calculate()
        {
            double p = 1.0;
            double den = Math.Pow(Math.Cos(5) + 1.0, 2.0); // важно: (cos(5)+1)^2
            int k = 1;

            while (k <= 10)
            {
                p *= k / den;   // k/int → double, т.к. den — double
                k++;
            }

            return Math.Round(p, 3); // 24589.408
        }
    }
}