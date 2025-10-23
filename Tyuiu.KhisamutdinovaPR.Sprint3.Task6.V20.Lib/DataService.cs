using System;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task6.V20.Lib
{
    public class DataService
    {
        /// <summary>
        /// Считает общее количество делителей меньше limit для всех чисел на отрезке [start, end].
        /// Включает делитель 1. Считаются только положительные делители.
        /// </summary>
        public int GetDivisorsCountInRange(int start, int end, int limit)
        {
            if (start > end) (start, end) = (end, start);
            if (limit <= 1) return 0;

            int total = 0;
            for (int x = start; x <= end; x++)
            {
                for (int d = 1; d < limit; d++)
                {
                    if (x % d == 0) total++;
                }
            }
            return total;
        }
    }
}