namespace LeedCode.Leedcode;

public class ReverseInteger
{
    public int Execute(int x)
    {
        var isNev = x < 0;
        if (isNev)
            x *= -1;
        long y = 0;
        while (x > 0)
        {
            y = y * 10 + x % 10;
            if (y > int.MaxValue) return 0;
            x /= 10;
        }

        return (int)(isNev ? y * -1 : y);
    }
}