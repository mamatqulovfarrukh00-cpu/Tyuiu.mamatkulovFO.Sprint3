using Tyuiu.mamatkulovFO.Sprint3.Task0.V21.Lib;
namespace Tyuiu.mamatkulovFO.Sprint3.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void CalculateSum_ForA1_5_ShouldBeApproximatelyMinus63_727()
        {
            // Arrange
            double a = 1.5;
            double expected = -63.727;

            // Act
            double actual = MathService.CalculateSum(a);

           
            Assert.AreEqual(expected, actual: 3);
        }
    }
}
