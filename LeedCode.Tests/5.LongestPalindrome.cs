using LeedCode.Leedcode;

namespace LeedCode.Tests;

public class LongestPalindromeTest
{
    // [Theory]
    [InlineData("babad", "aba")]
    [InlineData("cbbd", "bb")]
    [InlineData("ccc", "ccc")]
    [InlineData("bb", "bb")]
    [InlineData("aaaa", "aaaa")]
    public void LongestPalindrome_Value_ShouldEquals(string input, string expected)
    {
        var handler = new LongestPalindrome();
        // Act
        var actual = handler.Execute(input);
        // Assert
        Assert.Equal(expected, actual);
    }
}