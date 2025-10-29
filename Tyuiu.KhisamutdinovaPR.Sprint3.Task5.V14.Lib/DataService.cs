using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KhisamutdinovPR.Sprint3.Task5.V14.Lib;
    public class Calculator
    {
        public static double Calculate(double x)
        {
            double result = 0;

            for (int i = 1; i <= 3; i++)
            {
                double innerSum = 0;
                for (int k = 1; k <= 14; k++)
                {
                    innerSum += Math.Sin(x + (2.0 / k));
                }
                result += innerSum;
            }

            return result;
        }
    }
