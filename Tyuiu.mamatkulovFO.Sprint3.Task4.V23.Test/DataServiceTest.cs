using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.mamatkulovFO.Sprint3.Task4.V23.Lib;

namespace Tyuiu.mamatkulovFO.Sprint3.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateTest()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(-5, 5);
            double expected = 244.656;
            Assert.AreEqual(expected, result, 0.001, "Результат не совпадает!");
        }
    }
}