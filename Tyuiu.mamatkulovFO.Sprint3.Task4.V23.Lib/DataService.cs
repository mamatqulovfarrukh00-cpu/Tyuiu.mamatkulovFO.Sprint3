using System;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.mamatkulovFO.Sprint3.Task4.V23.Lib;

public class DataService : ISprint3Task4V23
{
    public double Calculate(int startValue, int stopValue)
    {
        double product = 1.0;
        for (int x = startValue; x <= stopValue; x++)
        {
            if (x == 0) continue; // Пропускаем x=0, чтобы не делить на ноль!
            double y = Math.Cos(x) / x + 3;
            product *= y;
        }
        return Math.Round(product, 3); // Округляем до 3 знаков
    }
}
