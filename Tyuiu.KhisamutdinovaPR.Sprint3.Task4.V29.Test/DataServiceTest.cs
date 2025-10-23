using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhisamutdinovaPR.Sprint3.Task4.V29.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetSumSeries()
        {
            DataService ds = new DataService();
            double result = ds.GetSumSeries();

            double expected = -0.241; // предварительно вычисленное значение
            Assert.AreEqual(expected, result);
        }
    }
}