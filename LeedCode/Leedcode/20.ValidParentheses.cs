
namespace LeedCode.Leedcode;

public class ValidParentheses
{
    public bool IsValid(string s)
    {
        var pDict = new Dictionary<char, char>
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };
        var stack = new Stack<char>();
        foreach (var c in s)
        {
            if (pDict.TryGetValue(c, out var value))
            {
                char result;
                if(!stack.TryPop(out var stackItem) || value != stackItem) return false;
                continue;
            }

            stack.Push(c);
        }

        return stack.Count == 0;
    }
}