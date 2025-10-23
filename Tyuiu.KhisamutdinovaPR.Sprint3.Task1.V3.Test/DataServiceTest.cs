using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhisamutdinovaPR.Sprint3.Task1.V3.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_Product_Ok()
        {
            var ds = new DataService();
            double got = ds.Calculate();
            // Контрольное значение вычислено заранее
            double expected = 0.040722;
            Assert.AreEqual(expected, got, 1e-6);
        }
    }
}
