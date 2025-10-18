using System;
using Tyuiu.mamatkulovF0.Sprint3.Task2.V30.Lib;

namespace Tyuiu.mamatkulovF0.Sprint3.Task2.V30
{
    class Program
    {
        static void Main()
        {
            double x = 0.25;
            double result = DataService.CalculateMultiply(x);

            
            var inv = System.Globalization.CultureInfo.InvariantCulture;
            Console.WriteLine(result.ToString("F2", inv)); 
        }
    }
}
