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
            int start = -5;
            int stop = 5;
            double res = ds.Calculate(start, stop);
            double wait = 174.86; // Ожидаемый результат
            Assert.AreEqual(wait, res);
        }
    }
}