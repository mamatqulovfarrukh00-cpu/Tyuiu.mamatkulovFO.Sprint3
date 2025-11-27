using System;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.mamatkulovFO.Sprint3.Task4.V23.Lib;

public class DataService : ISprint3Task4V23
{
    public double Calculate(int startValue, int stopValue)
    {
        double product = 1.0; // Начальное значение для умножения

        for (int x = startValue; x <= stopValue; x++)
        {
            if (x == 0)
            {
                break; // Прерываем цикл при x = 0, чтобы избежать деления на ноль
            }

            double y = Math.Cos(x) / x + 3;
            product *= y;
        }

        return product;
    }
}
