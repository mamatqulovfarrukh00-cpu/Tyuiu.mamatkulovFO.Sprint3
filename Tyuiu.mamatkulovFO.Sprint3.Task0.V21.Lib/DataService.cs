using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.mamatkulovF0.Sprint3.Task0.V21.Lib
{
    public class DataService : ISprint3Task0V21
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            for (int k = startValue; k <= stopValue; k++)
            {
                sum += (Math.Pow(value, k) + 0.25) * Math.Sin(k);
            }
            return sum;
        }

        public static double CalculateSum(double a)
        {
            return new DataService().GetSumSeries(a, 1, 13);
        }
    }
}

