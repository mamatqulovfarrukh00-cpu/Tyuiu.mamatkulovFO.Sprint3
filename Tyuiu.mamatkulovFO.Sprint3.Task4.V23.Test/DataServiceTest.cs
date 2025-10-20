
using Tyuiu.mamatkulovFO.Sprint3.Task4.V23.Lib;

namespace Tyuiu.mamatkulovFO.Sprint3.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateProductTest()
        {
            var service = new DataService();
            double result = service.CalculateProduct();

            double expected = 244.656;
            Assert.AreEqual(expected, result, 0.001, "Результат не совпадает с ожидаемым");
        }
    }
}