using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.mamatkulovF0.Sprint3.Task2.V30.Lib
{
    public class DataService : ISprint3Task2V30
    {
        public double GetMultiplySeries(double x, int startValue, int stopValue)
        {
            double product = 1.0; 
            for (int i = startValue; i <= stopValue; i++)
            {
                double term = (x * x * i) + 2; // (x² * i) + 2
                product *= term;
            }
            return Math.Round(product, 2);
        }

        public static double CalculateMultiply(double x)
        {
            return new DataService().GetMultiplySeries(x, 1, 11);
        }
    }
}