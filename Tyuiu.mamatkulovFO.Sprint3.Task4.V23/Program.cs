using Tyuiu.mamatkulovFO.Sprint3.Task4.V23.Lib;

namespace Tyuiu.mamatkulovFO.Sprint3.Task4.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 3 | Задание 4 | Вариант 23 | Маматкулов Ф.О.";

            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double result = ds.Calculate(startValue, stopValue);

            Console.WriteLine("===================================================================");
            Console.WriteLine("* Спринт 3                                                         *");
            Console.WriteLine("* Тема: Цикл foreach                                               *");
            Console.WriteLine("* Задание 4                                                        *");
            Console.WriteLine("* Вариант 23                                                       *");
            Console.WriteLine("* Выполнил: Маматкулов Фаррух Охунжонович                          *");
            Console.WriteLine("===================================================================");

            Console.WriteLine($"Функция: y = cos(x)/x + 3");
            Console.WriteLine($"Диапазон x: от {startValue} до {stopValue}");
            Console.WriteLine("Цикл прерывается при x = 0");
            Console.WriteLine($"Результат (произведение y): {result:F3}");

            Console.WriteLine("===================================================================");
            Console.WriteLine("Нажмите любую клавишу для завершения...");
            Console.ReadKey();
        }
    }
}