using Tyuiu.mamatkulovFO.Sprint3.Task4.V23.Lib;
namespace Tyuiu.mamatkulovFO.Sprint3.Task4.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = DataService.CalculateFunctionProduct();
            Console.WriteLine(result); // ⚠️ ВАЖНО: только число, без текста!
        }
    }
}
