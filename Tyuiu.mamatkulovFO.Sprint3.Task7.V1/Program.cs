using Tyuiu.mamatkulovFO.Sprint3.Task7.V1.Lib;
namespace Tyuiu.mamatkulovFO.Sprint3.Task7.V1
{
    class Program
    {
        static void Main()
        {
            var service = new DataService();
            var values = service.GetMassFunction(-5, 5);

            Console.WriteLine("x\tF(x)");
            Console.WriteLine("----------------");
            for (int i = 0, x = -5; x <= 5; x++, i++)
                Console.WriteLine($"{x}\t{values[i]}");

            Console.ReadKey();
        }
    }
}
