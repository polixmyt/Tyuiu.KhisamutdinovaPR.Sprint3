using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhisamutdinovaPR.Sprint3.Task3.V22.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task3.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMaxConsecutiveB_ReturnsCorrectValue()
        {
            DataService ds = new DataService();
            string text = "thbbbb dsfbg bbg";
            int expected = 4;
            int result = ds.GetMaxConsecutiveB(text);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetMaxConsecutiveB_NoBs_ReturnsZero()
        {
            DataService ds = new DataService();
            string text = "hello world";
            int expected = 0;
            int result = ds.GetMaxConsecutiveB(text);
            Assert.AreEqual(expected, result);
        }
    }
}