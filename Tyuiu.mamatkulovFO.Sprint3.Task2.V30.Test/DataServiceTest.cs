using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.mamatkulovF0.Sprint3.Task2.V30.Lib;

namespace Tyuiu.mamatkulovF0.Sprint3.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateMultiply_ForX0_25_ShouldBeApproximately167_89()
        {
            double x = 0.25;
            double expected = 167.89;

            double actual = DataService.CalculateMultiply(x);

          
            Assert.AreEqual(expected, actual, 0.01);
        }
    }
}
