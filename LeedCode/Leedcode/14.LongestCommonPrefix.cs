namespace LeedCode.Leedcode;

public class LongestCommonPrefix
{
    public string Execute(string[] strs)
    {
        Array.Sort(strs);
        var first = strs[0];
        var last = strs[^1];
        for (var i = 0; i < Math.Min(first.Length, last.Length); i++)
        {
            if (first[i] == last[i]) continue;
            return first[..i];
        }

        return first;
    }
}