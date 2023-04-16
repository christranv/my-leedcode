namespace LeedCode.Leedcode;

public class ContainerWithMostWater
{
    public int MaxArea(int[] height)
    {
        var l = 0;
        var r = height.Length - 1;
        var max = 0;
        while (l < r)
        {
            max = Math.Max(max, (r - l) * Math.Min(height[r], height[l]));
            if (height[l] < height[r])
            {
                l++;
                continue;
            }

            r--;
        }

        return max;
    }
}