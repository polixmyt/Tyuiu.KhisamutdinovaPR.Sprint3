using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task1.V3.Lib
{
    public class DataService: ISprint3Task1V3
    {
        // p = Π_{k=1}^{10} ( k / (cos(5) + 1)^2 )
        public double Calculate()
        {
            double p = 1;
            int k = 1;
            while (k <= 10)
            {
                p = (k / Math.Pow(Math.Cos(5) + 1.0, 2));
                k++;
            }
            return Math.Round(p, 6);
        }

        public double GetMultiplySeries(int startValue, int stopValue)
        {
            throw new NotImplementedException();
        }
    }
}
