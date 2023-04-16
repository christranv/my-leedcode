using LeedCode.Leedcode;

namespace LeedCode.Tests;

public class ZigzagConversionTest
{
    [Theory]
    [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
    [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
    [InlineData("A", 1, "A")]
    [InlineData("AB", 1, "AB")]
    [InlineData("ABCD", 2, "ACBD")]
    public void ZigzagConversion_Value_ShouldEquals(string input, int numRows, string expected)
    {
        var handler = new ZigzagConversion();
        // Act
        var actual = handler.Execute(input, numRows);
        // Assert
        Assert.Equal(expected, actual);
    }
}