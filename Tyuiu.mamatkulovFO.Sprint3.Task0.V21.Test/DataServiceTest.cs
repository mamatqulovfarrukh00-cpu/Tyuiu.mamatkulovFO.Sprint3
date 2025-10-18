using Tyuiu.mamatkulovFO.Sprint3.Task0.V21.Lib;
namespace Tyuiu.mamatkulovFO.Sprint3.Task0.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        public void CalculateSum_ShouldReturnCorrectValue_ForA_1_5()
        {
            double a = 1.5;
            double expected = -63.727; // Kutilgan natija

            double actual = MathService.CalculateSum(a);

            // Natijani 3 xonagacha tekshirish
            Assert.AreEqual(expected, actual, 3);
        }
    }
}
