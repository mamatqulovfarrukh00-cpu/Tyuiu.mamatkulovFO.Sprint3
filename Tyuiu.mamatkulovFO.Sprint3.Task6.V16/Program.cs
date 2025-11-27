using Tyuiu.mamatkulovFO.Sprint3.Task6.V16.Lib;
namespace Tyuiu.mamatkulovFO.Sprint3.Task6.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 3 | Задание 6 | Вариант 16 | Маматкулов Ф.О.";

            DataService service = new DataService();

            int start = 5;
            int stop = 16;

            int result = service.GetSumTheDivisors(start, stop);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 3                                                                *");
            Console.WriteLine("* Тема: Циклы                                                             *");
            Console.WriteLine("* Задание 6                                                               *");
            Console.WriteLine("* Вариант 16                                                              *");
            Console.WriteLine("* Выполнил: Маматкулов Фаррух Охунжонович                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* Результат: {result}                                                    *");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}

