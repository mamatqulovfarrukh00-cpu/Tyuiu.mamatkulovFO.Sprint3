using Tyuiu.mamatkulovFO.Sprint3.Task6.V16.Lib;
namespace Tyuiu.mamatkulovFO.Sprint3.Task6.V16
{
    // Главная программа — выводит результаты в консоль
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Вариант 16 ===");
            Console.WriteLine("Поиск количества делителей чисел в диапазоне [5, 16]\n");

            var service = new DataService();
            var counts = service.GetDivisorCounts(5, 16);

            foreach (var kvp in counts)
            {
                Console.WriteLine($"Число {kvp.Key} имеет {kvp.Value} делителей.");
            }

            Console.WriteLine($"\nОбщее количество делителей всех чисел: {counts.Values.Sum()}");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
