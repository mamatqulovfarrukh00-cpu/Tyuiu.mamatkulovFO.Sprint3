using Tyuiu.mamatkulovFO.Sprint3.Task5.V25.Lib;
namespace Tyuiu.mamatkulovFO.Sprint3.Task5.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new Tyuiu.mamatkulovFO.Sprint3.Task5.V25.Lib.DataService();
            double result = service.CalculateSum();

            Console.WriteLine("Результат: " + result);
            Console.ReadKey();
        }
    }
}
