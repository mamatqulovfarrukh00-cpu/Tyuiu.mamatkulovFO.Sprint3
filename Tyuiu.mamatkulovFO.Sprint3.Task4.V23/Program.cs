using System;

namespace Tyuiu.mamatkulovFO.Sprint3.Task4.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 3 | Задание 4 | Вариант 23 | Маматкулов Ф.О.";

            int startValue = -5;
            int stopValue = 5;
            double product = 1.0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0) continue; 
                double y = Math.Cos(x) / x + 3;
                product *= y;
            }

            double result = Math.Round(product, 3);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Маматкулов Ф.О                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* РЕЗУЛЬТАТ: {result:F3}                                                 *");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}