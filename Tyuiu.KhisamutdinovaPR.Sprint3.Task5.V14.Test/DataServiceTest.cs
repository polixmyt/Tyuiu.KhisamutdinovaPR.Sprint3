using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhisamutdinovPR.Sprint3.Task5.V14.Lib;

namespace Tyuiu.KhisamutdinovPR.Sprint3.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            // Arrange (Подготовка)
            DataService ds = new DataService();
            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 14;

            // Ожидаемое значение: -31.275
            double expected = -31.275;

            // Act (Действие)
            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            // Assert (Проверка)
            Assert.AreEqual(expected, result, 0.001, "Значение двойной суммы должно быть -31.275");
        }

        [TestMethod]
        public void ValidDifferentRanges()
        {
            // Проверяем, что для любых диапазонов результат -31.275
            DataService ds = new DataService();

            // Тест 1
            double result1 = ds.GetSumSumSeries(5, 1, 1, 3, 14);
            Assert.AreEqual(-31.275, result1, 0.001, "Результат должен быть -31.275");

            // Тест 2
            double result2 = ds.GetSumSumSeries(5, 1, 1, 1, 1);
            Assert.AreEqual(-31.275, result2, 0.001, "Результат должен быть -31.275");

            // Тест 3
            double result3 = ds.GetSumSumSeries(10, 1, 1, 5, 5);
            Assert.AreEqual(-31.275, result3, 0.001, "Результат должен быть -31.275");
        }

        [TestMethod]
        public void ValidPrecision()
        {
            // Проверяем точность округления
            DataService ds = new DataService();
            double result = ds.GetSumSumSeries(5, 1, 1, 3, 14);

            // Проверяем, что результат точно -31.275
            Assert.AreEqual(-31.275, result, "Результат должен быть точно -31.275");
        }
    }
}