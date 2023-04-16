using LeedCode.Leedcode;

namespace LeedCode.Tests;

public class ThreeSumTest
{
    public static IEnumerable<object[]> Data()
    {
        yield return new object[]
        {
            new[] { -1, 0, 1, 2, -1, -4 },
            new List<IList<int>> { new List<int> { -1, -1, 2 }, new List<int> { -1, 0, 1 } }
        };
        yield return new object[] { new[] { 0, 1, 1 }, new List<IList<int>>() };
        yield return new object[] { new[] { 0, 0, 0 }, new List<IList<int>> { new List<int> { 0, 0, 0 } } };
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void ThreeSum_Value_ShouldEquals(int[] input, IList<IList<int>> expected)
    {
        var handler = new ThreeSum();
        // Act
        var actual = handler.Execute(input);
        // Assert
        Assert.Equal(expected, actual);
    }
}