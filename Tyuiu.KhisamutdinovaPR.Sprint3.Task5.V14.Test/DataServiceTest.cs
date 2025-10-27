using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhisamutdinovaPR.Sprint3.Task5.V14.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            // Arrange (Подготовка)
            DataService ds = new DataService();
            int iStart = 1;
            int iEnd = 3;
            int kStart = 1;
            int kEnd = 14;
            double x = 5;

            // Ожидаемое значение (вычисляем вручную)
            // sin(5) ≈ -0.95892
            // Внутренняя сумма для каждого i: ∑[k=1,14] (sin(5) + 2/k)
            // = 14*sin(5) + 2*(1 + 1/2 + 1/3 + ... + 1/14)
            // = 14*(-0.95892) + 2*(гармонический ряд H₁₄ ≈ 3.25156)
            // = -13.42488 + 6.50312 ≈ -6.92176
            // Общая сумма: 3 * (-6.92176) ≈ -20.76528
            double expected = -20.765; // Округлено до 3 знаков

            // Act (Действие)
            double result = ds.GetSumSumSeries(iStart, iEnd, kStart, kEnd, x);

            // Assert (Проверка)
            Assert.AreEqual(expected, result, 0.001, "Значение двойной суммы вычислено неверно");
        }

        [TestMethod]
        public void ValidSingleIteration()
        {
            // Arrange
            DataService ds = new DataService();
            int iStart = 1;
            int iEnd = 1;
            int kStart = 1;
            int kEnd = 1;
            double x = 5;

            // Ожидаемое значение: sin(5) + 2/1 = -0.95892 + 2 = 1.04108
            double expected = Math.Round(Math.Sin(5) + 2, 3);

            // Act
            double result = ds.GetSumSumSeries(iStart, iEnd, kStart, kEnd, x);

            // Assert
            Assert.AreEqual(expected, result, 0.001, "Вычисление для одной итерации неверно");
        }

        [TestMethod]
        public void ValidDifferentX()
        {
            // Arrange
            DataService ds = new DataService();
            int iStart = 1;
            int iEnd = 2;
            int kStart = 1;
            int kEnd = 2;
            double x = 0; // sin(0) = 0

            // Ожидаемое значение: 
            // Для i=1: (0 + 2/1) + (0 + 2/2) = 2 + 1 = 3
            // Для i=2: (0 + 2/1) + (0 + 2/2) = 2 + 1 = 3
            // Общая сумма: 3 + 3 = 6
            double expected = 6;

            // Act
            double result = ds.GetSumSumSeries(iStart, iEnd, kStart, kEnd, x);

            // Assert
            Assert.AreEqual(expected, result, "Вычисление при x=0 неверно");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidRange()
        {
            // Arrange
            DataService ds = new DataService();
            int iStart = 3;
            int iEnd = 1; // Неправильный диапазон

            // Act - должен выбросить исключение
            double result = ds.GetSumSumSeries(iStart, iEnd, 1, 1, 5);
        }
    }
}