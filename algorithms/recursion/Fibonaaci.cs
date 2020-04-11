public class FindFibonacci
{

    public int FindFibonacciRecursive(int n)
    {

        if (n == 0)
            return 0;

        if (n == 1)
            return 1;

        return FindFibonacciRecursive(n - 1) + FindFibonacciRecursive(n - 2);
    }

    public int FindFibonacciIterative(int n){
        int first = 0;
        int second = 1;
        int result = 0;

        if(n == 0)
            return 0;

        if(n == 1)
            return 1;

        for (int i = 2; i <= n; i++)
        {
            result = first + second;
            first = second;
            second = result;
        }
        return result;
    }
}