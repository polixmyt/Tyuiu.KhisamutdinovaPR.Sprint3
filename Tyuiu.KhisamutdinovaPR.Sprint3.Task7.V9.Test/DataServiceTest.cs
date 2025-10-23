using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhisamutdinovaPR.Sprint3.Task7.V9.Lib;
using System;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Tabulate_CorrectCalculation_ReturnsExpectedValues()
        {
            // Arrange
            DataService ds = new DataService();
            int start = -5;
            int end = 5;

            // Act
            double[] result = ds.Tabulate(start, end);

            // Assert
            // Проверяем длину массива: [-5;5] → 11 элементов
            Assert.AreEqual(11, result.Length);

            // Проверим несколько контрольных значений
            // x = 0 → (2*0-3)/(cos(0)-0) + 0 - sin(0) = -3 / 1 = -3
            Assert.AreEqual(-3.00, result[5], 0.01);

            // x = 1 → (2*1-3)/(cos(1)-2) + 5*1 - sin(1)
            // Вычисляем ожидаемое значение вручную
            double expectedX1 = (2 * 1 - 3) / (Math.Cos(1) - 2 * 1) + 5 * 1 - Math.Sin(1);
            expectedX1 = Math.Round(expectedX1, 2, MidpointRounding.AwayFromZero);

            Assert.AreEqual(expectedX1, result[6], 0.01);

            // Проверка, что при делении на 0 (если встретится) значение не вызывает ошибок
            // и программа корректно возвращает 0
            for (int i = 0; i < result.Length; i++)
            {
                Assert.IsFalse(double.IsNaN(result[i]));
            }
        }
    }
}