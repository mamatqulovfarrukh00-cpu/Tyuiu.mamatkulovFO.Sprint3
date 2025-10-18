using Tyuiu.mamatkulovFO.Sprint3.Task0.V21.Lib;
namespace Tyuiu.mamatkulovFO.Sprint3.Task0.V21
{
     class Program
    {
        static void Main()
        {
            double a = 1.5;
            double sum = 0;

            // k = 1 dan 13 gacha tsikl
            for (int k = 1; k <= 13; k++)
            {
                sum += (Math.Pow(a, k) + 0.25) * Math.Sin(k);
            }

            Console.WriteLine($" S = {sum:F6}");
            Console.ReadKey();
        }
    }
}
