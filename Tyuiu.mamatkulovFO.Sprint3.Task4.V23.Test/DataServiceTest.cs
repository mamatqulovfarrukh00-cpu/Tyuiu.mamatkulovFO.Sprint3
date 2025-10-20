using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.mamatkulovFO.Sprint3.Task4.V23.Lib;

namespace Tyuiu.mamatkulovFO.Sprint3.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public double result { get; private set; }

        [TestMethod]
        public void CalculateProduct_ShouldReturnFiniteValue()
        {
            var service = new DataService();
           

            Assert.IsFalse(double.IsNaN(result), "Результат не должен быть NaN");
            Assert.IsTrue(double.IsFinite(result), "Результат должен быть конечным числом");
        }
    }
}