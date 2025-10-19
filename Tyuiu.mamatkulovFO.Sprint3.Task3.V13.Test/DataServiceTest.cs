using Tyuiu.mamatkulovFO.Sprint3.Task3.V13.Lib;
namespace Tyuiu.mamatkulovFO.Sprint3.Task3.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [Test]
        public void Test_ExtractNumber()
        {
            
            string input = "?sd!! 5gh. s!";
            int expected = 5;
            int actual = DataService.ExtractNumber(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
