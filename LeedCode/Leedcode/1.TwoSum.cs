namespace LeedCode.Leedcode;

public class TwoSum
{
    public int[] Execute(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();
        for (var idx = 0; idx < nums.Length; idx++)
        {
            if (dict.TryGetValue(target - nums[idx], out var firstIdx))
                return new[] { firstIdx, idx };
            dict[nums[idx]] = idx;
        }

        return new[] { 0, 0 };
    }
}