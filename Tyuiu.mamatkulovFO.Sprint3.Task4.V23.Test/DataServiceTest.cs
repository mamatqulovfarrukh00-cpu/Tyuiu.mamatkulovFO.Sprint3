
using Tyuiu.mamatkulovFO.Sprint3.Task4.V23.Lib;

namespace Tyuiu.mamatkulovFO.Sprint3.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateProduct_ShouldReturnCorrectValue()
        {
            var service = new DataService();
            double result = service.CalculateProduct();

        
            Assert.IsFalse(double.IsNaN(result), "Результат не должен быть NaN");

          
            Assert.IsFalse(double.IsInfinity(result), "Результат не должен быть бесконечностью");
        }
    }
}