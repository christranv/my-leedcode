namespace LeedCode.Leedcode;

public class LongestPalindrome
{
    public string Execute(string s)
    {
        var max = 0;
        var startIdx = 0;
        for (var idx = 0; idx < s.Length; idx++)
        {
            var packs = new List<int[]> { new[] { idx, idx } };
            if (idx < s.Length - 1 && s[idx] == s[idx + 1])
                packs.Add(new[] { idx, idx + 1 });
            foreach (var pack in packs)
            {
                var left = pack[0];
                var right = pack[1];
                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                    left--;
                    right++;
                }

                if (max > right - left - 1) continue;
                max = right - left - 1;
                startIdx = left + 1;
            }
        }

        return s.Substring(startIdx, max);
    }
}