using System;
using Tyuiu.mamatkulovFO.Sprint3.Task4.V23.Lib;
namespace Tyuiu.mamatkulovFO.Sprint3.Task4.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;
            DataService ds = new DataService();
            double result = ds.Calculate(startValue, stopValue);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
