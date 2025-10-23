using System;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task1.V3.Lib
{
    public class DataService
    {
        // p = Π_{k=1}^{10} ( k / (cos(5) + 1)^2 )
        public double Calculate()
        {
            double p = 1;
            int k = 1;
            while (k <= 10)
            {
                p *= (k / Math.Pow(Math.Cos(5) + 1, 2));
                k++;
            }
            return Math.Round(p, 6);
        }
    }
}
