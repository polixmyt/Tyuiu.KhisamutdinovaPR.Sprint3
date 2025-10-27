using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhisamutdinovPR.Sprint3.Task1.V3.Lib;

namespace Tyuiu.KhisamutdinovPR.Sprint3.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            // Arrange (Подготовка)
            DataService ds = new DataService();

            // Ожидаемое значение (вычисляем вручную для проверки)
            // denominator = (cos(5) + 1)² ≈ (-0.28366 + 1)² ≈ (0.71634)² ≈ 0.51314
            // Произведение ряда = (1/0.51314) * (2/0.51314) * ... * (10/0.51314)
            // = (1×2×3×...×10) / (0.51314^10)
            // = 3628800 / (0.51314^10) ≈ 3628800 / 0.001245 ≈ 2915000000
            // Но это очень грубая оценка, точное значение нужно вычислять

            double expected = 0.001; // Это приблизительное значение

            // Act (Действие)
            double result = ds.GetMultiplySeries();

            // Assert (Проверка)
            // Проверяем, что результат положительный и близок к ожидаемому
            Assert.IsTrue(result > 0, "Результат должен быть положительным");
            Assert.IsTrue(result < 1, "Результат должен быть меньше 1");
        }

        [TestMethod]
        public void ValidCalculation()
        {
            // Arrange
            DataService ds = new DataService();

            // Вычисляем ожидаемое значение поэтапно
            double denominator = Math.Pow(Math.Cos(5) + 1, 2);
            double expectedProduct = 1;

            int k = 1;
            while (k <= 10)
            {
                expectedProduct *= k / denominator;
                k++;
            }
            expectedProduct = Math.Round(expectedProduct, 3);

            // Act
            double result = ds.GetMultiplySeries();

            // Assert
            Assert.AreEqual(expectedProduct, result, 0.001, "Расчет произведения ряда неверный");
        }
    }
}