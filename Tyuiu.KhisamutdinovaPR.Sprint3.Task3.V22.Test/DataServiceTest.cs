
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhisamutdinovaPR.Sprint3.Task3.V22.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint3.Task3.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMaxCharCount()
        {
            // Arrange (Подготовка)
            DataService ds = new DataService();
            string str = "tbtbbb dsthg bbsg";
            char targetChar = 'b';

            // Ожидаемое значение: в строке "tbtbbb dsthg bbsg"
            // Последовательности символов 'b':
            // - "b" (одиночный)
            // - "bbb" (три подряд) - это максимальная последовательность
            // - "bb" (два подряд)
            int expected = 3;

            // Act (Действие)
            int result = ds.GetMaxCharCount(str, targetChar);

            // Assert (Проверка)
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ValidEmptyString()
        {
            // Arrange
            DataService ds = new DataService();
            string str = "";
            char targetChar = 'b';

            int expected = 0;

            // Act
            int result = ds.GetMaxCharCount(str, targetChar);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ValidNoTargetChar()
        {
            // Arrange
            DataService ds = new DataService();
            string str = "acdefgh";
            char targetChar = 'b';

            int expected = 0;

            // Act
            int result = ds.GetMaxCharCount(str, targetChar);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ValidAllTargetChars()
        {
            // Arrange
            DataService ds = new DataService();
            string str = "bbbbbb";
            char targetChar = 'b';

            int expected = 6;

            // Act
            int result = ds.GetMaxCharCount(str, targetChar);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ValidDifferentChar()
        {
            // Arrange
            DataService ds = new DataService();
            string str = "aaabbaaaa";
            char targetChar = 'a';

            int expected = 4;

            // Act
            int result = ds.GetMaxCharCount(str, targetChar);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}