using System;
using Tyuiu.mamatkulovFO.Sprint3.Task4.V23.Lib;
namespace Tyuiu.mamatkulovFO.Sprint3.Task4.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new DataService();
            double result = service.CalculateProduct();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
