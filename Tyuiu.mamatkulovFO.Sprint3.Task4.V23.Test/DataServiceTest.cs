using Tyuiu.mamatkulovFO.Sprint3.Task4.V23.Lib;
namespace Tyuiu.mamatkulovFO.Sprint3.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [Test]
        public void Test_ResultIsCloseToExpected()
        {
            double actual = DataService.CalculateFunctionProduct();
            double expected = 244.656;

          
        }

       
    }
}
