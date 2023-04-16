using LeedCode.Leedcode;

namespace LeedCode.Tests;

public class ReverseIntegerTest
{
    [Theory]
    [InlineData(123, 321)]
    [InlineData(-123, -321)]
    [InlineData(120, 21)]
    [InlineData(1534236469, 0)]
    public void ReverseInteger_Value_ShouldEquals(int input, int expected)
    {
        var handler = new ReverseInteger();
        // Act
        var actual = handler.Execute(input);
        // Assert
        Assert.Equal(expected, actual);
    }
}