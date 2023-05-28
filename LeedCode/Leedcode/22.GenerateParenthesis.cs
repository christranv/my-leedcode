using LeedCode.Dtos;

namespace LeedCode.Leedcode;

public class GenerateParenthesis
{
    public IList<string> Execute(int n)
    {
        var list = new List<string>();

        void Backtrack(string s, int open, int close, int n)
        {
            if (s.Length == n * 2)
            {
                list.Add(s);
                return;
            }

            if (open < n)
                Backtrack(s + '(', open + 1, close, n);
            if (close < open)
                Backtrack(s + ')', open, close + 1, n);
        }

        Backtrack("", 0, 0, n);
        return list;
    }
}