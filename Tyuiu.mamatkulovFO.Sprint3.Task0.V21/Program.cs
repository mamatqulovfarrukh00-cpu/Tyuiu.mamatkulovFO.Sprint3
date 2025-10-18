using Tyuiu.mamatkulovFO.Sprint3.Task0.V21.Lib;
namespace Tyuiu.mamatkulovFO.Sprint3.Task0.V21;
using System;


class Program
{
    static void Main()
    {
        double a = 1.5;
        double result = DataService.CalculateSum(a);
        System.Globalization.CultureInfo inv = System.Globalization.CultureInfo.InvariantCulture;
        Console.WriteLine(result.ToString("F3", inv));
    }
}

