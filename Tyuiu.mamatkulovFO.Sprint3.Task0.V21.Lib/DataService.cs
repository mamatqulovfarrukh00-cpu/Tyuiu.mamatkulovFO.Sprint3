using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.mamatkulovFO.Sprint3.Task0.V21.Lib
{
    public class DataService
    {
        public static double CalculateSum(double a)
        {
            double sum = 0;
            for (int k = 1; k <= 13; k++)
            {
                sum += (Math.Pow(a, k) + 0.25) * Math.Sin(k);
            }
            return sum;
        }
    }
}
