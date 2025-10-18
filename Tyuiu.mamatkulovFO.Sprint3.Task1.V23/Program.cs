using System;
using Tyuiu.mamatkulovF0.Sprint3.Task1.V23.Lib;

namespace Tyuiu.mamatkulovF0.Sprint3.Task1.V23
{
    class Program
    {
        static void Main()
        {
            double x = 5;
            double result = DataService.CalculateMultiply(x);

          
            var inv = System.Globalization.CultureInfo.InvariantCulture;
            Console.WriteLine(result.ToString("E5", inv)); 
        }
    }
}
