namespace LeedCode.Leedcode;

public class SearchInRotatedSortedArray
{
    public int Search(int[] nums, int target)
    {
        var pivot = 0;
        var middle = nums.Length / 2;

        if (nums[middle] < nums[0])
        {
            pivot = GetPivot(nums, 0, middle);
        }
        else if (nums[middle] > nums[^1])
        {
            pivot = GetPivot(nums, middle, nums.Length - 1);
        }

        var index = -1;
        if (pivot == 0)
            index = Array.BinarySearch(nums, 0, nums.Length, target);
        else if (nums[^1] >= target)
            index = Array.BinarySearch(nums, pivot, nums.Length - pivot - 1, target);
        else if (nums[pivot] < target)
            index = Array.BinarySearch(nums, 0, pivot - 1, target);
        return index >= 0 ? index : -1;
    }

    private static int GetPivot(int[] nums, int start, int end)
    {
        while (start < end)
        {
            var mid = (end + start) / 2;
            if (nums[mid] < nums[start])
            {
                end = mid;
                start++;
            }
            else
            {
                start = mid;
                end--;
            }
        }

        return start;
    }

    private int FindValue(int[] nums, int start, int end, int target)
    {
        while (start < end)
        {
            var mid = (start + end) / 2;
            if (nums[mid] == target) return mid;
            if (target > nums[mid]) start = mid;
            else end = mid;
        }

        return -1;
    }
}