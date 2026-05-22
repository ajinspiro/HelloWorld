namespace EOPL.Examples;

public static class InSWrapper
{
    public static bool InS(int n)
    {
        if (n == 0)
        {
            return true;
        }
        if ((n - 3) >= 0)
        {
            return InS(n - 3);
        }
        else
        {
            return false;
        }
    }
}