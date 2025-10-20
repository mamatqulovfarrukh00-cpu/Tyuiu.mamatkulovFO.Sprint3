using System;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.mamatkulovFO.Sprint3.Task4.V23.Lib;

public class DataService : ISprint3Task4V23
{
    [TestMethod]
    public void CalculateProduct_ShouldReturnFiniteValue()
    {
        var service = new DataService();
        double result = service.CalculateProduct();

        
        Assert.IsFalse(double.IsNaN(result));

      
        Assert.IsTrue(double.IsFinite(result));
    }

    private double CalculateProduct()
    {
        throw new NotImplementedException();
    }

    public double Calculate(int startValue, int stopValue)
    {
        throw new NotImplementedException();
    }
}