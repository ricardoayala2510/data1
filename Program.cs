public class Algorithms
{
    //2.1
    public int Pow(int baseValue, int exponent)
    {
        if (exponent == 0)
            return 1;
        return baseValue * Pow(baseValue, exponent - 1);
    }

    //2.5
    public static long PowerOf2Iterative(int n)
    {
        long result = 1;
        for (int i = 0; i < n; i++)
        {
            result *= 2;
        }
        return result;
    }

    public static long PowerOf2Recursive(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        return 2 * PowerOf2Recursive(n - 1);
    }

    public static long SuperPowerOf2(int n)
    {
        if (n <= 30)
        {
            return PowerOf2Recursive(n);
        }
        else
        {
            return PowerOf2Iterative(n);
        }
    }


}