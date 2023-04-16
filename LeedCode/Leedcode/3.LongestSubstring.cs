namespace LeedCode.Leedcode;

public class LongestSubstring
{
    /// <summary>
    /// Optimized solution
    /// </summary>
    public int LengthOfLongestSubstring(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;
        var dict = new Dictionary<char, int>();
        var left = 0;
        var max = 0;
        for (var i = 0; i < s.Length; i++)
        {
            if (dict.ContainsKey(s[i]))
            {
                dict.Remove(s[left++]);
            }

            dict[s[i]] = i;
            max = Math.Max(max, dict.Count);
        }

        return max;
    }

    /// <summary>
    /// My solution
    /// </summary>
    public int LengthOfLongestSubstring1(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;
        var dict = new Dictionary<char, int>();
        var left = 0;
        var max = 1;
        for (var i = 0; i < s.Length; i++)
        {
            if (dict.TryGetValue(s[i], out var dupIndex) && dupIndex >= left)
            {
                left = dupIndex + 1;
            }

            dict[s[i]] = i;
            max = Math.Max(max, i - left + 1);
        }

        return max;
    }
}