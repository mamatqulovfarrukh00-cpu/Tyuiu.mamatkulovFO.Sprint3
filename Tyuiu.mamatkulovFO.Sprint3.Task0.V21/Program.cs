using Tyuiu.mamatkulovFO.Sprint3.Task0.V21.Lib;
namespace Tyuiu.mamatkulovFO.Sprint3.Task0.V21;
using System;


class Program
{
    static void Main()
    {
        double a = 1.5;
        double result = CalculateSum(a);
        Console.WriteLine($"{result:F3}"); 
    }

    
    public static double CalculateSum(double a)
    {
        double sum = 0;
        for (int k = 1; k <= 13; k++)
        {
            sum += (Math.Pow(a, k) + 0.25) * Math.Sin(k);
        }
        return sum; 
    }
}

