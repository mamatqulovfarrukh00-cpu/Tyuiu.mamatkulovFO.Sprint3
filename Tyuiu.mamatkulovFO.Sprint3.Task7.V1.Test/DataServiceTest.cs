using Tyuiu.mamatkulovFO.Sprint3.Task7.V1.Lib;
namespace Tyuiu.mamatkulovFO.Sprint3.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunction_DivisionByZero_ReturnsZero()
        {
            var service = new DataService();
            var result = service.GetMassFunction(-2, -1); 
            Assert.AreEqual(0, result[1]); 
           
        }

        [TestMethod]
        public void GetMassFunction_RangeMinus5To5_Contains11Values()
        {
            var service = new DataService();
            var result = service.GetMassFunction(-5, 5);
            Assert.AreEqual(11, result.Length);
        }
    }

}

