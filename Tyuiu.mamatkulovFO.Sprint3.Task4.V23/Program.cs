using System;
using Tyuiu.mamatkulovFO.Sprint3.Task4.V23.Lib;
namespace Tyuiu.mamatkulovFO.Sprint3.Task4.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DataService service = new DataService();

            
            Console.WriteLine(service.CalculateFunctionProduct());
        }


    }
}
