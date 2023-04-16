using LeedCode.Leedcode;

namespace LeedCode.Tests;

public class IntegerToRomanTest
{
    [Theory]
    [InlineData(58, "LVIII")]
    [InlineData(1994, "MCMXCIV")]
    public void IntegerToRomanTest_Value_ShouldEquals(int input, string expected)
    {
        var handler = new IntegerToRoman();
        // Act
        var actual = handler.IntToRoman(input);
        // Assert
        Assert.Equal(expected, actual);
    }
}