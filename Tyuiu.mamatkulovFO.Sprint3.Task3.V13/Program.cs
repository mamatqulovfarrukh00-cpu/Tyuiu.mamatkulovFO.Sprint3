using Tyuiu.mamatkulovFO.Sprint3.Task3.V13.Lib;
namespace Tyuiu.mamatkulovFO.Sprint3.Task3.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "?sd!! 5gh. s!";
            int number = DataService.ExtractNumber(str);
            Console.WriteLine(number); 
        }
    }
}
