using Tyuiu.mamatkulovFO.Sprint3.Task6.V16.Lib;
namespace Tyuiu.mamatkulovFO.Sprint3.Task6.V16.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void TestGetSumTheDivisors()
        {
            var service = new DataService();
            int result = service.GetSumTheDivisors(5, 16);
            Assert.AreEqual(48, result); 
        }

        [Test]
        public void TestGetSumTheDivisors_WithSingleNumber()
        {
            var service = new DataService();
            int result = service.GetSumTheDivisors(10, 10);
            Assert.AreEqual(4, result); 
        }
    }
}
