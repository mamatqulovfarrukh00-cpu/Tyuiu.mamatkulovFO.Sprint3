using Tyuiu.mamatkulovFO.Sprint3.Task3.V23.Lib;
namespace Tyuiu.mamatkulovFO.Sprint3.Task3.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисляем значение функции y = cos(x)/x + 3 для x от -5 до 5 (x ≠ 0)...");
            Console.WriteLine("Значения перемножаются.");

            double result = DataService.CalculateFunctionProduct();

            Console.WriteLine($"Результат (произведение): {result:F6}");
            Console.ReadKey();
        }
    }
}
