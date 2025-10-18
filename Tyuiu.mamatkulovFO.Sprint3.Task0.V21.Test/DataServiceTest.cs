using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.mamatkulovF0.Sprint3.Task0.V21.Lib;

namespace Tyuiu.mamatkulovF0.Sprint3.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateSum_ForA1_5_ShouldBeApproximatelyMinus63_727()
        {
            // Arrange
            double a = 1.5;
            double expected = -63.727;

            // Act
            double actual = DataService.CalculateSum(a);

            // Assert
            Assert.AreEqual(expected, actual, 3); 
        }
    }
}