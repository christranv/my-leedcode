using LeedCode.Leedcode;

namespace LeedCode.Tests;

public class LongestCommonPrefixTest
{
    [Theory]
    [InlineData(new [] {"flower","flow","flight"}, "fl")]
    [InlineData(new [] {"dog","racecar","car"}, "")]
    [InlineData(new [] {"ab", "a"}, "a")]
    public void LongestCommonPrefix_Value_ShouldEquals(string[] input, string expected)
    {
        var handler = new LongestCommonPrefix();
        // Act
        var actual = handler.Execute(input);
        // Assert
        Assert.Equal(expected, actual);
    }
}