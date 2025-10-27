using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhisamutdinovaPR.Sprint3.Task3.V29.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task3.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            // Arrange (Подготовка)
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            // Ожидаемое значение (вычисляем вручную)
            // y = cos(x)/x для x от -5 до 5, исключая x=0
            // Суммируем все значения
            double expected = 0.0;
            for (int x = -5; x <= 5; x++)
            {
                if (x != 0)
                {
                    expected += Math.Cos(x) / x;
                }
            }
            expected = Math.Round(expected, 2);

            // Act (Действие)
            double result = ds.Calculate(startValue, stopValue);

            // Assert (Проверка)
            Assert.AreEqual(expected, result, 0.01, "Сумма значений функции вычислена неверно");
        }

        [TestMethod]
        public void ValidSkipZero()
        {
            // Arrange
            DataService ds = new DataService();
            int startValue = -1;
            int stopValue = 1;

            // При диапазоне [-1, 1] должны быть вычислены только x=-1 и x=1
            // x=0 должен быть пропущен
            double expected = Math.Cos(-1) / (-1) + Math.Cos(1) / 1;
            expected = Math.Round(expected, 2);

            // Act
            double result = ds.Calculate(startValue, stopValue);

            // Assert
            Assert.AreEqual(expected, result, 0.01, "Значение при x=0 не было пропущено");
        }

        [TestMethod]
        public void ValidSingleValue()
        {
            // Arrange
            DataService ds = new DataService();
            int startValue = 2;
            int stopValue = 2;

            // Ожидаемое значение: cos(2)/2
            double expected = Math.Round(Math.Cos(2) / 2, 2);

            // Act
            double result = ds.Calculate(startValue, stopValue);

            // Assert
            Assert.AreEqual(expected, result, "Вычисление для одного значения неверно");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidRange()
        {
            // Arrange
            DataService ds = new DataService();
            int startValue = 5;
            int stopValue = -5;

            // Act - должен выбросить исключение
            double result = ds.Calculate(startValue, stopValue);
        }
    }
}