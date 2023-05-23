namespace CalculatorLib.Tests;

public class CalculatorLibUnitTests
{
    [Fact]
    public void TestingAdding2and2()
    {
        double a = 2, b = 2, expected = 4;
        Calculator calc = new();
        double actual = calc.Add(a, b);
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void TestingAdding2and3(){
        double a = 2, b = 3, expected = 5;
        Calculator calc = new();
        double actual = calc.Add(a, b);
        Assert.Equal(expected, actual);
    }
}