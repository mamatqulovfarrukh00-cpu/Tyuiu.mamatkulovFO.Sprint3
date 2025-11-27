
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
            // Arrange
            DataService ds = new DataService();
            double expected = 7968.784; // Пример ожидаемого значения (проверьте по вашему варианту!)

            // Act
            double actual = ds.Calculate(-5, 5);

            // Assert
            Assert.AreEqual(expected, actual, 0.001, "Результат вычисления неверен.");
        }
    }
}