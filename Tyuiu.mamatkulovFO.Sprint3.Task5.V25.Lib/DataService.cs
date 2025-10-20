using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.mamatkulovFO.Sprint3.Task5.V25.Lib
{
    public class DataService : ISprint3Task5V25
    {
        public double Calculate()
        {
            throw new NotImplementedException();
        }

        public double CalculateSum()
        {
            double sum = 0;
            int x = 2;

            for (int i = 1; i <= 3; i++)
            {
                for (int k = 1; k <= 10; k++)
                {
                    double term = Math.Pow(x, k) + Math.Cos(k);
                    sum += term;
                }
            }

            return Math.Round(sum, 3);
        }
       
    }
}
