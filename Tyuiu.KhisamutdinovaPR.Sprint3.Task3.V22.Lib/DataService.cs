using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task3.V22.Lib
{
    public class DataService : ISprint3Task3V22
    {
        public int GetMaxCharCount(string value, char item)
        {
            throw new NotImplementedException();
        }

        public int GetMaxCharCount(string input)
        {
            int maxCount = 0;
            int currentCount = 0;

            foreach (char c in input)
            {
                if (c == 'b')
                {
                    currentCount++;
                    if (currentCount > maxCount)
                        maxCount = currentCount;
                }
                else
                {
                    currentCount = 0;
                }
            }

            return maxCount;
        }
    }
}