using System;
using Tyuiu.mamatkulovFO.Sprint3.Task4.V23.Lib;


namespace Tyuiu.mamatkulovFO.Sprint4.Task23.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 4 | Задание 23 | Вариант 16 | Маматкулов Ф.О.";

            DataService service = new DataService();

            int start = -5;
            int stop = 5;

            double result = service.Calculate(start, stop);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 4                                                                *");
            Console.WriteLine("* Тема: Циклы                                                             *");
            Console.WriteLine("* Задание 23                                                              *");
            Console.WriteLine("* Вариант 16                                                              *");
            Console.WriteLine("* Выполнил: Маматкулов Фаррух Охунжонович                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* Результат: {result:F2}                                                 *");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}