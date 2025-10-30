using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.mamatkulovFO.Sprint3.Task7.V1.Lib
{
    public class DataService : ISprint3Task7V1
    {
     
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            var count = stopValue - startValue + 1;
            var result = new double[count];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double value = CalculateF(x);
                result[index++] = Math.Round(value, 2);
            }

            return result;
        }

        private double CalculateF(int x)
        {
            if (x + 1.2 == 0) return 0;
            return Math.Sin(x) / (x + 1.2) + Math.Cos(x) * 7 * x - 2;
        }
    }
}
    

