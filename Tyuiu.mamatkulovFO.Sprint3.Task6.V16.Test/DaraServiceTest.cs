using Tyuiu.mamatkulovFO.Sprint3.Task6.V16.Lib;
namespace Tyuiu.mamatkulovFO.Sprint3.Task6.V16.Test
{
    [TestClass]
    public sealed class DaraServiceTest
    {
        [TestMethod]
        public void Test_GetTotalDivisorCount_5_to_16_Returns_42()
        {
            var service = new DataService();
            int result = service.GetTotalDivisorCount(5, 16);
            Assert.AreEqual(42, result);
        }
    }
}

