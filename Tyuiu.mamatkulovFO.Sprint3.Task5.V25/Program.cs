using System;
using Tyuiu.mamatkulovFO.Sprint3.Task5.V25.Lib;
namespace Tyuiu.mamatkulovFO.Sprint3.Task5.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            int startValue1 = 1;
            int startValue2 = 1;
            int x = 2;
            int stopValue1 = 3;
            int stopValue2 = 10;

            DataService ds = new DataService();
            double result = ds.GetSumSumSeries(x,startValue1,startValue2,stopValue1,stopValue2);

            Console.WriteLine("Результат: " + result);
            Console.ReadKey();
        }
    }
}
