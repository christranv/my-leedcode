namespace LeedCode.Leedcode;

public class LetterCombinations
{
    public IList<string> Execute(string digits)
    {
        var keyArr = new[] { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
        var res = new Queue<string>();
        res.Enqueue("");
        while (res.Peek().Length != digits.Length)
        {
            var word = res.Dequeue();
            var keys = keyArr[digits[word.Length] - '0'];
            foreach (var key in keys)
            {
                res.Enqueue(word + key);
            }
        }

        return res.Count == 1 ? new List<string>() : res.ToList();
    }
}