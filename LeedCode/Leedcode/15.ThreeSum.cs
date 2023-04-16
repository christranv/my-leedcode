namespace LeedCode.Leedcode;

public class ThreeSum
{
    public IList<IList<int>> Execute(int[] nums)
    {
        Array.Sort(nums);
        var deDupDict = new Dictionary<string, bool>();
        var results = new List<IList<int>>();
        for (var i = 0; i < nums.Length; i++)
        {
            var j = i + 1;
            var k = nums.Length - 1;
            while (j < k)
            {
                var sum = nums[i] + nums[j] + nums[k];
                switch (sum)
                {
                    case 0:
                        var result = new List<int> { nums[i], nums[j++], nums[k--] };
                        if (!deDupDict.TryAdd(string.Join(",", result), true)) continue;
                        results.Add(result);
                        break;
                    case > 0:
                        k--;
                        break;
                    default:
                        j++;
                        break;
                }
            }
        }

        return results;
    }
}