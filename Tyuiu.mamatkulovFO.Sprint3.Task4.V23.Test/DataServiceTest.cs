using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.mamatkulovFO.Sprint3.Task4.V23.Lib;

namespace Tyuiu.mamatkulovFO.Sprint3.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test_CalculateFunctionProduct()
        {
            DataService service = new DataService();
            double actual = service.CalculateFunctionProduct();
            double expected = 244.656;

            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}