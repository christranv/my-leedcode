namespace LeedCode.Tests;

public class Template
{
    // [Theory]
    [InlineData("", 0)]
    public void Add_EmptyEntries_ShouldBeTreatedAsZero(string input, int expected)
    {
        // Act
        var actual = 0;

        // Assert
        Assert.Equal(expected, actual);
    }
}