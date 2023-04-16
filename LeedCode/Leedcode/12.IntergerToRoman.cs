using System.Text;

namespace LeedCode.Leedcode;

public class IntegerToRoman
{
    public string IntToRoman(int num)
    {
        var numArr = new[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        var romanArr = new[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        var romanBuilder = new StringBuilder();
        for (var i = 0; i < numArr.Length; i++)
        {
            var division = num / numArr[i];
            if (division <= 0) continue;
            for (var time = 0; time < division; time++)
                romanBuilder.Append(romanArr[i]);
            num %= numArr[i];
        }

        return romanBuilder.ToString();
    }

    /// <summary>
    /// O(1) solution
    /// </summary>
    public string IntToRomanO1(int num)
    {
        var M = new[] { "", "M", "MM", "MMM" };
        var C = new[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        var X = new[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        var I = new[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        return M[num / 1000] + C[num % 1000 / 100] + X[num % 100 / 10] + I[num % 10];
    }
}