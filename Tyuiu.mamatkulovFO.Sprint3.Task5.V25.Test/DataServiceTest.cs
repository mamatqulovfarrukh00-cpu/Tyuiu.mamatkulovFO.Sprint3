using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.mamatkulovFO.Sprint3.Task5.V25.Lib;
namespace Tyuiu.mamatkulovFO.Sprint3.Task5.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateSumTest()
        {
            DataService ds = new DataService();
            int startValue1 = 1;
            int startValue2 = 1;
            int x = 2;
            int stopValue1 = 3;
            int stopValue2 = 10;
            var res = ds.GetSumSumSeries(x,startValue1,startValue2,stopValue1,stopValue2);
            double expected = 6133.748;

            Assert.AreEqual(expected, res);
        }
    }
}
