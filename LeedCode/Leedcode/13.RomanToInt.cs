namespace LeedCode.Leedcode;

public class RomanToInt
{
    public int Execute(string s)
    {
        var dict = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };
        var num = 0;
        var previousNum = 0;
        foreach (var t in s)
        {
            if (dict[t] <= previousNum)
            {
                num += dict[t];
            }
            else
            {
                num += dict[t] - 2 * previousNum;
            }

            previousNum = dict[t];
        }

        return num;
    }
}