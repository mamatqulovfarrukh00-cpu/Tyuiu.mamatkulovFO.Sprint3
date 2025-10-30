﻿using System;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.mamatkulovFO.Sprint3.Task4.V23.Lib;

public class DataService : ISprint3Task4V23
{
    public double Calculate(int startValue, int stopValue)
    {
        double res = 1.0;

        for (int x = startValue; x <= stopValue; x++)
        {
            if (x == 0)
                continue;

            double y = Math.Cos(x) / x + 3;
            res *= y;
        }

        return Math.Round(res, 3);
    }
}