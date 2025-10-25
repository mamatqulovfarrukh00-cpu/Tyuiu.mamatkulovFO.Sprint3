using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.mamatkulovFO.Sprint3.Task6.V16.Lib
{
    public class DataService:ISprint3Task6V16
    {
        // Метод возвращает количество всех делителей для каждого числа в диапазоне [start, end]
        public Dictionary<int, int> GetDivisorCounts(int start, int end)
        {
            var result = new Dictionary<int, int>();

            for (int x = start; x <= end; x++)
            {
                int count = 0;
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        count++;
                    }
                }
                result[x] = count;
            }

            return result;
        }
    }
}

