using Tyuiu.KhisamutdinovaPR.Sprint3.Task0.V15;
using Tyuiu.KhisamutdinovaPR.Sprint3.Task0.V15.Lib;
namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(ds.GetSumSeries(0, 1, 1), 0);
            
        }
    }
}
