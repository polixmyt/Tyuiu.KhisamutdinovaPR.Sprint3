using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System;
using Tyuiu.KhisamutdinovaPR.Sprint3.Task2.V3.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task2.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculateSeriesSum()
        {
            DataService ds = new DataService();
            double result = ds.GetSumSeries(4);
            double expected = 0;

            int x = 4;
            for (int i = 1; i <= 15; i++)
            {
                expected += (Math.Pow(x, 2) * i) + 1;
            }

            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}