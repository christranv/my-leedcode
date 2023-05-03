namespace LeedCode.Leedcode;

public class FourSum
{
    public IList<IList<int>> Execute(int[] nums, int target)
    {
        Array.Sort(nums);
        var results = new List<IList<int>>();
        for (var i = 0; i < nums.Length - 3; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            for (var j = i + 1; j < nums.Length - 2; j++)
            {
                if (j > i + 1 && nums[j] == nums[j - 1]) continue;
                var outerSum = nums[i] + nums[j];
                var left = j + 1;
                var right = nums.Length - 1;
                while (left < right)
                {
                    var sum = (long)outerSum + nums[left] + nums[right];
                    if (sum <= int.MaxValue && sum == target)
                    {
                        results.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });
                        left++;
                        right--;
                        while (left < right && nums[left] == nums[left - 1]) left++;
                        while (left < right && nums[right] == nums[right + 1]) right--;
                    }
                    else if (sum > target) right--;
                    else left++;
                }
            }
        }

        return results;
    }
}