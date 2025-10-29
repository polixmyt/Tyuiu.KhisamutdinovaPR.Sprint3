using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhisamutdinovaPR.Sprint3.Task6.V20.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            // Arrange (Подготовка)
            DataService ds = new DataService();
            int startValue = 20;
            int stopValue = 32;

            // Ожидаемое значение (вычисляем вручную)
            // Для каждого числа от 20 до 32 суммируем делители меньше 12
            int expected = 0;
            for (int num = 20; num <= 32; num++)
            {
                for (int d = 1; d < 12; d++)
                {
                    if (num % d == 0)
                    {
                        expected += d;
                    }
                }
            }

            // Act (Действие)
            int result = ds.GetSumTheDivisors(startValue, stopValue);

            // Assert (Проверка)
            Assert.AreEqual(expected, result, "Сумма делителей вычислена неверно");
        }

        [TestMethod]
        public void ValidSingleNumber()
        {
            // Arrange
            DataService ds = new DataService();
            int startValue = 20;
            int stopValue = 20;

            // Для числа 20 делители меньше 12: 1, 2, 4, 5, 10
            // Сумма: 1 + 2 + 4 + 5 + 10 = 22
            int expected = 22;

            // Act
            int result = ds.GetSumTheDivisors(startValue, stopValue);

            // Assert
            Assert.AreEqual(expected, result, "Сумма делителей для числа 20 неверно");
        }

        [TestMethod]
        public void ValidRangeTwoNumbers()
        {
            // Arrange
            DataService ds = new DataService();
            int startValue = 20;
            int stopValue = 21;

            // Число 20: делители 1, 2, 4, 5, 10 → сумма = 22
            // Число 21: делители 1, 3, 7 → сумма = 11
            // Итого: 22 + 11 = 33
            int expected = 33;

            // Act
            int result = ds.GetSumTheDivisors(startValue, stopValue);

            // Assert
            Assert.AreEqual(expected, result, "Сумма делителей для чисел 20-21 неверно");
        }

        [TestMethod]
        public void ValidPrimeNumber()
        {
            // Arrange
            DataService ds = new DataService();
            int startValue = 23;
            int stopValue = 23;

            // Для простого числа 23 делители меньше 12: только 1
            // Сумма: 1
            int expected = 1;

            // Act
            int result = ds.GetSumTheDivisors(startValue, stopValue);

            // Assert
            Assert.AreEqual(expected, result, "Сумма делителей для простого числа 23 неверно");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidRange()
        {
            // Arrange
            DataService ds = new DataService();
            int startValue = 32;
            int stopValue = 20; // Неправильный диапазон

            // Act - должен выбросить исключение
            int result = ds.GetSumTheDivisors(startValue, stopValue);
        }
    }
}