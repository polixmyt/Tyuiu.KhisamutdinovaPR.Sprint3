using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhisamutdinovaPR.Sprint3.Task6.V20.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CountDivisorsLessThan12_InRange20to32_Returns41()
        {
            var ds = new DataService();
            int actual = ds.GetDivisorsCountInRange(20, 32, 12);
            int expected = 41; // вручную подсчитано
            Assert.AreEqual(expected, actual);
        }
    }
}