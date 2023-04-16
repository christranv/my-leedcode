using LeedCode.Leedcode;

namespace LeedCode.Tests;

public class StringToIntegerTest
{
    [Theory]
    [InlineData("42", 42)]
    [InlineData("   -42", -42)]
    [InlineData("4193 with words", 4193)]
    [InlineData("+-1232", 0)]
    [InlineData("00000-42a1234", 0)]
    [InlineData("9223372036854775808", 2147483647)]
    [InlineData("-91283472332", -2147483648)]
    [InlineData("-2147483648", -2147483648)]
    [InlineData("  +  413", 0)]
    [InlineData("", 0)]
    [InlineData(" ", 0)]
    public void StringToInteger_Value_ShouldEquals(string input, int expected)
    {
        var handler = new StringToInteger();
        // Act
        var actual = handler.Execute(input);
        // Assert
        Assert.Equal(expected, actual);
    }
}