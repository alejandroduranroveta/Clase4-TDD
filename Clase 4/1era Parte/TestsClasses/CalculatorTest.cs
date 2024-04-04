


using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Clase_4;

[TestClass]
public class CalculatorTest
{
    [TestMethod]
    public void TestSum2Numbers()
    {
        // Arrange
        var calculator = new Calculator();
        
        var a = 2;
        var b = 3;
        var expected = 5;

        // Act
        var result = calculator.Suma(a, b);

        // Assert
        Assert.AreEqual(expected, result);
        
    }
    
    // [TestMethod]
    // public void TestSumList()
    // {
    //     // Arrange
    //     var calculator = new Calculator();
    //
    //     var numbers = new List<int> { 1, 2, 3, 4, 5 };
    //     var expected = 15;
    //
    //     // Act -> Metodo que suma una lista
    //     var result = calculator.SumList(numbers);
    //
    //     // Assert
    //     Assert.AreEqual(expected, result);
    // }
    
 }