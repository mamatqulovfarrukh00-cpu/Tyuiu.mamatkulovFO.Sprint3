using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.mamatkulovFO.Sprint3.Task3.V13.Lib
{
    public class DataService : ISprint3Task3V13
    {
        public static int ExtractNumber(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            string digitsOnly = "";
            foreach (char c in input)
            {
                if (Char.IsDigit(c))
                    digitsOnly += c;
            }

            return int.TryParse(digitsOnly, out int result) ? result : 0;
        }
        public int ConvertStringToInt(string value)
        {
            throw new NotImplementedException();
        }
    }
}
