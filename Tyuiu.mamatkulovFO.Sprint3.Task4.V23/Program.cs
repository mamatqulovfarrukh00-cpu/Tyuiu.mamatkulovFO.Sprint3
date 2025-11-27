using System;
using Tyuiu.mamatkulovFO.Sprint3.Task4.V23.Lib;

namespace Tyuiu.mamatkulovFO.Sprint3.Task4.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 3 | Задание 4 | Вариант 23 | Маматкулов Ф.О.";

            DataService ds = new DataService();
            double result = ds.Calculate(-5, 5);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Маматкулов Ф . О                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* РЕЗУЛЬТАТ: {result:F3}                                                 *");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}