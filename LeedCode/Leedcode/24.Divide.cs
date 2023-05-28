namespace LeedCode.Leedcode;

public class Divide2Int
{
    public int Divide(int dividend, int divisor)
    {
        if (dividend == int.MinValue && divisor == -1) return int.MaxValue;
        var isNeg = dividend < 0 ^ divisor < 0;
        var absDividend = Math.Abs((long)dividend);
        var absDivisor = Math.Abs((long)divisor);
        var quotient = 0;
        var subQuo = 0;

        while (absDividend - absDivisor >= 0)
        {
            for (subQuo = 0; absDividend - (absDivisor << subQuo << 1) >= 0; subQuo++) ;
            quotient += 1 << subQuo;
            absDividend -= absDivisor << subQuo;
        }

        return quotient * (isNeg ? -1 : 1);
    }
}