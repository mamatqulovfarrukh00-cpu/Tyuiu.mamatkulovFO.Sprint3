using Tyuiu.mamatkulovFO.Sprint3.Task6.V16.Lib;
namespace Tyuiu.mamatkulovFO.Sprint3.Task6.V16
{
    // Главная программа — выводит результаты в консоль
    class Program
    {

        static void Main()
        {
            var service = new DataService();
            int result = service.GetTotalDivisorCount(5, 16);
            System.Console.WriteLine(result); // Вывод: 42
        }
    }
}
