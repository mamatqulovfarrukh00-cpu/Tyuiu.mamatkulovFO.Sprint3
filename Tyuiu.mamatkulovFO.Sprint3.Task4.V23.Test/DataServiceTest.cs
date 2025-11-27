
using Tyuiu.mamatkulovFO.Sprint3.Task4.V23.Lib;
using Tyuiu.mamatkulovFO.Sprint4.Task23.V16.Test;

namespace Tyuiu.mamatkulovFO.Sprint3.Task4.V23.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void ValidCalculateTest()
        {
            DataService ds = new DataService();
            double expected = 244.656; // Точно как в системе!

            double actual = ds.Calculate(-5, 5);

            Assert.AreEqual(expected, actual, 0.001, "Результат должен быть 244.656");
        }
    }
}