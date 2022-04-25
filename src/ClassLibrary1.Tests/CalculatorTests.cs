using FluentAssertions;
using Xunit;

namespace ClassLibrary1.Tests;

public class UnitTest1
{
    [Theory]
    [InlineData(5, 3, 8)]
    [InlineData(123, -100, 23)]
    [InlineData(-3, 0, -3)]
    public void Add(int a, int b, int expectedResult)
    {
        var calculator = new Calculator();
        var result = calculator.Add(a, b);

        result.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData(5, 3, 2)]
    [InlineData(123, -100, 223)]
    [InlineData(-3, 0, -3)]
    public void Subtract(int a, int b, int expectedResult)
    {
        var calculator = new Calculator();
        var result = calculator.Subtract(a, b);

        result.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData(5, 3, 15)]
    [InlineData(123, -1, -123)]
    [InlineData(-3, 0, 0)]
    [InlineData(42, 1, 42)]
    public void Multiply(int a, int b, int expectedResult)
    {
        var calculator = new Calculator();
        var result = calculator.Multiply(a, b);

        result.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData(6, 3, 2)]
    [InlineData(123, -1, -123)]
    [InlineData(42, 1, 42)]
    public void Divide(int a, int b, int expectedResult)
    {
        var calculator = new Calculator();
        var result = calculator.Divide(a, b);

        result.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData(1, 0, 1)]
    [InlineData(1, 99, 1)]
    [InlineData(2, 10, 1024)]
    public void Power(int a, int b, int expectedResult)
    {
        var calculator = new Calculator();
        var result = calculator.Power(a, b);

        result.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 1)]
    [InlineData(2, 2)]
    [InlineData(3, 6)]
    [InlineData(10, 3628800)]
    public void Factorial(int a, int expectedResult)
    {
        var calculator = new Calculator();
        var result = calculator.Factorial(a);

        result.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(2, 2)]
    [InlineData(3, 3)]
    [InlineData(10, 89)]
    public void Fibonacci(int a, int expectedResult)
    {
        var calculator = new Calculator();
        var result = calculator.Fibonacci(a);

        result.Should().Be(expectedResult);
    }
}
