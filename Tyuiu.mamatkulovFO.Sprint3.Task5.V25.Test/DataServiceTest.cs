using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.mamatkulovFO.Sprint3.Task5.V25.Lib;
namespace Tyuiu.mamatkulovFO.Sprint3.Task5.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateSumTest()
        {
            var service = new DataService();
            double result = service.CalculateSum();

            double expected = 6136.898; 

            Assert.AreEqual(expected, result, 0.001, "Результат не совпадает с ожидаемым");
        }
    }
}
