using Tyuiu.mamatkulovFO.Sprint3.Task0.V21.Lib;
namespace Tyuiu.mamatkulovFO.Sprint3.Task0.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        public void CalculateSum_ShouldReturnCorrectValue_ForA_1_5()
        {
            // Arrange
            double a = 1.5;
            double expected = -1.977818; // 1.5 uchun taxminiy natija

            // Act
            double actual = MathService.CalculateSum(a);

            // Assert
            object value = Assert(actual, expected - 0.01, expected + 0.01);
        }

        private object Assert(double actual, double v1, double v2)
        {
            throw new NotImplementedException();
        }
    }
}
