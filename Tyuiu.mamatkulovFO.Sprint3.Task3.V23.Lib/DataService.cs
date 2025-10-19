using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.mamatkulovFO.Sprint3.Task4.V23.Lib
{
    public class DataService : ISprint3Task4V23

    {
        public static double CalculateFunctionProduct()
        {
            double product = 1.0; // Начальное значение для умножения

            for (int x = -5; x <= 5; x++)
            {
                if (x == 0)
                    continue; // Прерываем текущую итерацию при x=0

                double y = Math.Cos(x) / x + 3;
                product *= y;
            }

            return product;
        }
        public double Calculate(int startValue, int stopValue)
        {
            throw new NotImplementedException();
        }
    }
}
