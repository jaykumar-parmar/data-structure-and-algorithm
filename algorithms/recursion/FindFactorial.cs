
public class FindFactorial
{

    public int FindFactorialRecursive(int n)
    {

        int result = 1;

        if (n == 1)
        {
            return 1;
        }
        else if (n < 1)
        {
            return 0;
        }
        else
        {
            result = n * FindFactorialRecursive(n - 1);
        }

        return result;

    }

    public int FindFactorialIterrative(int n)
    {

        if (n < 1)
            return 0;

        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result = result * i;
        }

        return result;
    }
}