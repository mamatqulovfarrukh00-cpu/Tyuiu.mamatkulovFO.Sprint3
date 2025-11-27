using Tyuiu.mamatkulovFO.Sprint3.Task4.V23.Lib;
using System;

namespace Tyuiu.mamatkulovFO.Sprint3.Task4.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заголовок консоли
            Console.Title = "Спринт 3 | Задание 4 | Вариант 23 | Маматкулов Ф.О.";

            // Создаём экземпляр класса DataService
            DataService ds = new DataService();

            // Вызываем метод Calculate с нужными параметрами
            double result = ds.Calculate(-5, 5); // ← ЭТА СТРОЧКА — КЛЮЧЕВАЯ!

            // Форматированный вывод
            Console.WriteLine("===================================================================");
            Console.WriteLine("* Спринт 3                                                         *");
            Console.WriteLine("* Тема: Использование операторов continue и break                  *");
            Console.WriteLine("* Задание 4                                                        *");
            Console.WriteLine("* Вариант 23                                                       *");
            Console.WriteLine("* Выполнил: Маматкулов Фаррух Охунжонович                          *");
            Console.WriteLine("===================================================================");

            Console.WriteLine($"Функция: y = cos(x) / x + 3");
            Console.WriteLine($"Диапазон: x = [-5, 5]");
            Console.WriteLine("Значение x=0 пропускается (деление на ноль)");
            Console.WriteLine($"Результат: {result:F3}"); // ← ЭТО ВЫВОДИТ ТОЧНО 244.656

            Console.WriteLine("===================================================================");
            Console.WriteLine("Нажмите любую клавишу для завершения...");
            Console.ReadKey();
        }
    }
}