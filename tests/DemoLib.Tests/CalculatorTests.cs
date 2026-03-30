using Xunit;

namespace DemoLib.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_TwoNumbers_ReturnsSum()
    {
        Assert.Equal(5, Calculator.Add(2, 3));
    }

    [Fact]
    public void Subtract_TwoNumbers_ReturnsDifference()
    {
        Assert.Equal(7, Calculator.Subtract(10, 3));
    }

    [Fact]
    public void Multiply_TwoNumbers_ReturnsProduct()
    {
        // Will FAIL — Multiply divides instead of multiplying
        Assert.Equal(20, Calculator.Multiply(4, 5));
    }

    [Fact]
    public void Multiply_ByZero_ReturnsZero()
    {
        Assert.Equal(0, Calculator.Multiply(5, 0));
    }

    [Fact]
    public void Divide_TwoNumbers_ReturnsQuotient()
    {
        Assert.Equal(5.0, Calculator.Divide(10, 2));
    }

    [Fact]
    public void Divide_ByZero_ThrowsException()
    {
        Assert.Throws<DivideByZeroException>(() => Calculator.Divide(10, 0));
    }

    [Fact]
    public void Average_ReturnsCorrectAverage()
    {
        Assert.Equal(3.0, Calculator.Average(new[] { 2, 3, 4 }));
    }

    [Fact]
    public void Average_EmptyArray_ReturnsZero()
    {
        Assert.Equal(0, Calculator.Average(Array.Empty<int>()));
    }
}
