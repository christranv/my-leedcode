namespace LeedCode.Leedcode;

/// <summary>
/// Solution: Find out the increment rule of mutable number
/// </summary>
public class NextPermutation
{
    public void Execute(int[] nums)
    {
        var marked = -1;
        for (var i = nums.Length - 2; i >= 0; i--)
        {
            if (nums[i] >= nums[i + 1]) continue;
            marked = i;
            break;
        }

        if (marked == -1)
        {
            Array.Reverse(nums);
            return;
        }

        for (var j = nums.Length - 1; j > marked; j--)
        {
            if (nums[j] <= nums[marked]) continue;
            (nums[marked], nums[j]) = (nums[j], nums[marked]);
            Array.Reverse(nums, marked + 1, nums.Length - marked -1);
            return;
        }
    }
}