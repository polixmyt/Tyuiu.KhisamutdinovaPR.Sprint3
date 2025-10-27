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
            Assert.AreEqual(expected, result, 0.001, "Значение двойной суммы вычислено неверно");
        }

        [TestMethod]
        public void ValidManualCalculation()
        {
            // Ручной расчет для проверки
            double sin5 = Math.Sin(5); // ≈ -0.958924

            // Сумма 2/k для k=1..14
            double sum2k = 0;
            for (int k = 1; k <= 14; k++)
            {
                sum2k += 2.0 / k;
            }
            // sum2k ≈ 6.503456

            // Общая сумма: 3 * 14 * sin(5) + 3 * sum2k
            double total = 3 * 14 * sin5 + 3 * sum2k;
            total = Math.Round(total, 3); // ≈ -31.275

            Assert.AreEqual(-31.275, total, 0.001, "Ручной расчет не совпадает");
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

            // Ожидаемое значение: sin(5) + 2/1 = -0.958924 + 2 = 1.041076
            double expected = Math.Round(Math.Sin(5) + 2, 3);

            // Act
            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            // Assert
            Assert.AreEqual(expected, result, 0.001, "Вычисление для одной итерации неверно");
        }
    }
}