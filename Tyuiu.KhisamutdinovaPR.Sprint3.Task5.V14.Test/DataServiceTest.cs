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

            // Ожидаемое значение (вычисляем вручную)
            // sin(5) ≈ -0.95892
            // Внутренняя сумма для каждого i: ∑[k=1,14] (sin(5) + 2/k)
            // = 14*sin(5) + 2*(1 + 1/2 + 1/3 + ... + 1/14)
            // = 14*(-0.95892) + 2*(гармонический ряд H₁₄ ≈ 3.25156)
            // = -13.42488 + 6.50312 ≈ -6.92176
            // Общая сумма: 3 * (-6.92176) ≈ -20.76528
            double expected = -20.765; // Округлено до 3 знаков

            // Act (Действие)
            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            // Assert (Проверка)
            Assert.AreEqual(expected, result, 0.001, "Значение двойной суммы вычислено неверно");
        }

        [TestMethod]
        public void ValidSingleIteration()
        {
            // Arrange
            DataService ds = new DataService();
            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 1;
            int startValue2 = 1;
            int stopValue2 = 1;

            // Ожидаемое значение: sin(5) + 2/1 = -0.95892 + 2 = 1.04108
            double expected = Math.Round(Math.Sin(5) + 2, 3);

            // Act
            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            // Assert
            Assert.AreEqual(expected, result, 0.001, "Вычисление для одной итерации неверно");
        }

        [TestMethod]
        public void ValidDifferentX()
        {
            // Arrange
            DataService ds = new DataService();
            int x = 0; // sin(0) = 0
            int startValue1 = 1;
            int stopValue1 = 2;
            int startValue2 = 1;
            int stopValue2 = 2;

            // Ожидаемое значение: 
            // Для i=1: (0 + 2/1) + (0 + 2/2) = 2 + 1 = 3
            // Для i=2: (0 + 2/1) + (0 + 2/2) = 2 + 1 = 3
            // Общая сумма: 3 + 3 = 6
            double expected = 6;

            // Act
            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            // Assert
            Assert.AreEqual(expected, result, "Вычисление при x=0 неверно");
        }

        [TestMethod]
        public void ValidHarmonicSeries()
        {
            // Arrange
            DataService ds = new DataService();
            int x = 0; // sin(0) = 0
            int startValue1 = 1;
            int stopValue1 = 1;
            int startValue2 = 1;
            int stopValue2 = 3;

            // Ожидаемое значение: 2/1 + 2/2 + 2/3 = 2 + 1 + 0.666... = 3.666...
            double expected = Math.Round(2.0 / 1 + 2.0 / 2 + 2.0 / 3, 3);

            // Act
            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            // Assert
            Assert.AreEqual(expected, result, 0.001, "Вычисление гармонического ряда неверно");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidRange()
        {
            // Arrange
            DataService ds = new DataService();
            int x = 5;
            int startValue1 = 3;
            int stopValue1 = 1; // Неправильный диапазон

            // Act - должен выбросить исключение
            double result = ds.GetSumSumSeries(x, startValue1, 1, stopValue1, 1);
        }
    }
}