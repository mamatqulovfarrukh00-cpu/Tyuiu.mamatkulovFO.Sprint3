using Tyuiu.mamatkulovFO.Sprint3.Task6.V16.Lib;
namespace Tyuiu.mamatkulovFO.Sprint3.Task6.V16
{
    // Главная программа — выводит результаты в консоль
    class Program
    {
        static void Main()
        {
            var service = new DataService();
            var counts = service.GetDivisorCounts(5, 16);
            Console.WriteLine(counts.Values.Sum()); // Chiqadi: 42
        }
    }
}
