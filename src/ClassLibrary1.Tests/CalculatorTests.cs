using FluentAssertions;
using Xunit;

namespace ClassLibrary1.Tests;

public class UnitTest1
{
    [Theory]
    [InlineData(5)]
    [InlineData(123)]
    [InlineData(-3)]
    public void Add_Zero_ReturnsOriginalValue(int a)
    {
        var calculator = new Calculator();
        var result = calculator.Add(a, 0);

        result.Should().Be(a);
    }
}
