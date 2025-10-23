using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task1.V3.Lib;

public class DataService: ISprint3Task1V3
{
    // p = Π_{k=1..10} ( k / (cos(5) + 1)^2 )
    public double Calculate()
    {
        double p = 1.0;
        int k = 1;
        double den = Math.Pow(Math.Cos(5) + 1, 2);

        while (k <= 10)
        {
            p *= k / den;
            k++;
        }

        return p;
    }

    public double GetMultiplySeries(int startValue, int stopValue)
    {
        throw new NotImplementedException();
    }
}