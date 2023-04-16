using LeedCode.Leedcode;

namespace LeedCode.Tests;

public class ContainerWithMostWaterTest
{
    [Theory]
    [InlineData(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
    [InlineData(new[] { 2, 3, 10, 5, 7, 8, 9 }, 36)]
    public void ContainerWithMostWater_Value_ShouldEquals(int[] input, int expected)
    {
        var handler = new ContainerWithMostWater();
        // Act
        var actual = handler.MaxArea(input);
        // Assert
        Assert.Equal(expected, actual);
    }
}