using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task2.V3.Lib;

public class DataService : ISprint3Task2V3
{
    public double GetSumSeries(int value, int startValue, int stopValue)
    {
        double s = 0;
        int i = 1;

        do
        {
            s += (Math.Pow(value, 2) * i) + 1;
            i++;
        }
        while (i <= 15);

        return s;
    }

    public double GetSumSeries(int value)
    {
        throw new NotImplementedException();
    }
}
