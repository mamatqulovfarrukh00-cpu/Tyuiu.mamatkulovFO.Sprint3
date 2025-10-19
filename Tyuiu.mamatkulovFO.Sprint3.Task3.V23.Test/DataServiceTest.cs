using Tyuiu.mamatkulovFO.Sprint3.Task4.V23.Lib;
namespace Tyuiu.mamatkulovFO.Sprint3.Task4.V23.Test;

  [TestFixture]
public class DataServiceTest
{
    [Test]
    public void Test_CalculateFunctionProduct()
    {
        // Простой тест — проверяем, что результат не NaN и не Infinity
        double result = DataService.CalculateFunctionProduct();
        Assert.IsFalse(double.IsNaN(result));
        Assert.IsFalse(double.IsInfinity(result));
    }
}



