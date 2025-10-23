using Tyuiu.KhisamutdinovaPR.Sprint3.Task1.V3;
using Tyuiu.KhisamutdinovaPR.Sprint3.Task1.V3.Lib;
namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task1.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Calculate_Product_IsCorrect()
        {
            var ds = new DataService();
            double expected = 24589.4082117849;
            double actual = ds.Calculate();
            Assert.AreEqual(expected, actual, 1e-6);
        }
    }
}