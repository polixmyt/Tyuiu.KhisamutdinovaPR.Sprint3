using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhisamutdinovaPR.Sprint3.Task5.V14.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calc_SumSumSeries_ReturnsExpected()
        {
            var ds = new DataService();

            double actual = ds.GetSumSumSeries(1, 3, 1, 14, 5);
            double rounded = System.Math.Round(actual, 3);

            Assert.AreEqual(-20.765, rounded);
        }
    }
}