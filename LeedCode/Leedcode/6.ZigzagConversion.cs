namespace LeedCode.Leedcode;

public class ZigzagConversion
{
    public string Execute(string s, int numRows)
    {
        if (numRows == 1 || numRows >= s.Length) return s;
        var matrix = new string[numRows];
        for (var i = 0; i < matrix.Length; i++)
        {
            matrix[i] = "";
        }

        var index = 0;
        var step = 1;
        foreach (var t in s)
        {
            matrix[index] += t;
            if (index == numRows - 1) step = -1;
            else if (index == 0) step = 1;
            index += step;
        }

        return string.Join("", matrix);
    }
}