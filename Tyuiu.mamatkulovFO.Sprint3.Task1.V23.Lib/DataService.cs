using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.mamatkulovF0.Sprint3.Task1.V23.Lib
{
    public class DataService : ISprint3Task1V23
    {
        public double GetMultiplySeries(double x, int startValue, int stopValue)
        {
            double product = 1.0;
            for (int k = startValue; k <= stopValue; k++)
            {
                double denominator = Math.Sin(x) + Math.Pow(x, k);
               
                double term = Math.Pow(300.0 / denominator, k);
                product *= term;
            }
            return Math.Round(product, 3);
        }

        public static double CalculateMultiply(double x)
        {
            return new DataService().GetMultiplySeries(x, 1, 5);
        }

        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            throw new NotImplementedException();
        }
    }
}