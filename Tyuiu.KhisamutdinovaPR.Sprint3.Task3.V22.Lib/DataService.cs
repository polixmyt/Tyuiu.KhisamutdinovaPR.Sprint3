using System;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task3.V22.Lib
{
    public class DataService
    {
        public int GetMaxConsecutiveB(string input)
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