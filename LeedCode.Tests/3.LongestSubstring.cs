using LeedCode.Leedcode;

namespace LeedCode.Tests;

public class LongestSubstringTest
{
    // [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    [InlineData("s", 1)]
    [InlineData("au", 2)]
    [InlineData("dvdf", 3)]
    [InlineData("abba", 2)]
    public void LengthOfLongestSubstring_Value_ShouldEquals(string input, int expected)
    {
        var handler = new LongestSubstring();
        // Act
        var actual = handler.LengthOfLongestSubstring(input);
        // Assert
        Assert.Equal(expected, actual);
    }
}