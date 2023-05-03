namespace LeedCode.Leedcode;

public class ThreeSumClosest
{
    public int Execute(int[] nums, int target)
    {
        Array.Sort(nums);
        var result = int.MaxValue;
        var currentDistance = Math.Abs(int.MaxValue - target);
        for (var i = 0; i < nums.Length; i++)
        {
            var j = i + 1;
            var k = nums.Length - 1;
            while (j < k)
            {
                var sum = nums[i] + nums[j] + nums[k];
                var distance = Math.Abs(target - sum);
                if (sum == target) return sum;
                if (distance < currentDistance)
                {
                    result = sum;
                    currentDistance = distance;
                }

                if (sum > target)
                {
                    k--;
                    continue;
                }

                j++;
            }
        }

        return result;
    }
}