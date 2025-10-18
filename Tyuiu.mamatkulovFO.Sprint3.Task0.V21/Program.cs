using System;
using Tyuiu.mamatkulovF0.Sprint3.Task0.V21;
using Tyuiu.mamatkulovF0.Sprint3.Task0.V21.Lib;

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