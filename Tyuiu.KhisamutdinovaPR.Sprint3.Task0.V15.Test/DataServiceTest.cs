namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            double t = 0.7;
            double expected = Math.Round(
                Enumerable.Range(1, 10)
                .Sum(k => (Math.Pow(t, k) + 2.0 / (k + 1)) * Math.Sin(t)), 3);

            double result = ds.Calculate(t);

            Assert.AreEqual(expected, result);
        }
    }
}