using Tyuiu.mamatkulovFO.Sprint3.Task4.V23.Lib;
namespace Tyuiu.mamatkulovFO.Sprint3.Task4.V23.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [TestMethod] 
      
        public void Test_ResultIsCorrect()
        {
            double actual = DataService.CalculateFunctionProduct();
            double expected = 244.656;

            
            Assert.AreEqual(expected, actual, 0.001);
        }
    }


}

