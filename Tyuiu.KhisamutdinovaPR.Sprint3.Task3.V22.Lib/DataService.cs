using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task3.V22.Lib
{
    public class DataService: ISprint3Task3V22
    {
        public int GetMaxCharCount(string value, char item)
        {
            // Проверка на пустую строку
            if (string.IsNullOrEmpty(value))
            {
                return 0;
            }

            int maxCount = 0;     // Максимальное количество подряд идущих символов
            int currentCount = 0; // Текущее количество подряд идущих символов
            char prevChar = '\0'; // Предыдущий символ

            // Цикл foreach для перебора всех символов в строке
            foreach (char currentChar in value)
            {
                // Если текущий символ равен искомому
                if (currentChar == item)
                {
                    // Если предыдущий символ тоже был искомым, увеличиваем счетчик
                    if (prevChar == item)
                    {
                        currentCount++;
                    }
                    else
                    {
                        // Начинаем новую последовательность
                        currentCount = 1;
                    }

                    // Обновляем максимальное количество
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                }
                else
                {
                    // Сбрасываем счетчик, если символ не искомый
                    currentCount = 0;
                }

                // Запоминаем текущий символ как предыдущий для следующей итерации
                prevChar = currentChar;
            }

            return maxCount;
        }
    }
}