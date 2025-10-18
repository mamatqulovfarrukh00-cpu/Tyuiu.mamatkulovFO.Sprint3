using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.mamatkulovF0.Sprint3.Task1.V23.Lib;

namespace Tyuiu.mamatkulovF0.Sprint3.Task1.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateMultiply_ForX5_ReturnsCorrectValue()
        {
            double x = 5;
            double expected = 0.0; 

            double actual = DataService.CalculateMultiply(x);

           
            Assert.IsTrue(actual > 0 && actual < 1e-100);
        }
    }
}