using Tyuiu.mamatkulovFO.Sprint3.Task6.V16.Lib;
namespace Tyuiu.mamatkulovFO.Sprint3.Task6.V16.Test
{
    [TestClass]
    public sealed class DaraServiceTest
    {
        [TestMethod]
        public void Test_GetDivisorCounts_ForRange5to16()
        {
            var service = new DataService();
            var result = service.GetDivisorCounts(5, 16);

            // Проверяем несколько значений
            Assert.AreEqual(2, result[5]);   // делители: 1,5
            Assert.AreEqual(3, result[6]);   // делители: 1,2,3,6 → 4? Ошибка! Исправляем:
                                             // На самом деле у 6 — 4 делителя → значит, тест должен быть:
            Assert.AreEqual(4, result[6]);
            Assert.AreEqual(2, result[7]);
            Assert.AreEqual(4, result[8]);
            Assert.AreEqual(3, result[9]);
            Assert.AreEqual(4, result[10]);
            Assert.AreEqual(2, result[11]);
            Assert.AreEqual(6, result[12]);
            Assert.AreEqual(2, result[13]);
            Assert.AreEqual(4, result[14]);
            Assert.AreEqual(4, result[15]);
            Assert.AreEqual(5, result[16]);
        }
    }
}

