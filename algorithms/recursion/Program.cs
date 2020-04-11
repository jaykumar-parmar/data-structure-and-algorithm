using System;

namespace recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Factorial");

            FindFactorial factorial = new FindFactorial();
            Console.WriteLine("Find Factorial of 5 Recursive : {0}", factorial.FindFactorialRecursive(5));
            Console.WriteLine("Find Factorial of 5 Iterative : {0}", factorial.FindFactorialIterrative(5));


            Console.WriteLine("Find Fibonacci");

            FindFibonacci fibonacci = new FindFibonacci();
            Console.WriteLine("Find Fibonacci of 6 Recursive : {0}", fibonacci.FindFibonacciRecursive(6));
            Console.WriteLine("Find Fibonacci of 7 Recursive : {0}", fibonacci.FindFibonacciRecursive(7));
            Console.WriteLine("Find Fibonacci of 8 Recursive : {0}", fibonacci.FindFibonacciRecursive(8));

            Console.WriteLine("Find Fibonacci of 6 Iterative : {0}", fibonacci.FindFibonacciIterative(6));
            Console.WriteLine("Find Fibonacci of 7 Iterative : {0}", fibonacci.FindFibonacciIterative(7));
            Console.WriteLine("Find Fibonacci of 8 Iterative : {0}", fibonacci.FindFibonacciIterative(8));
        }
    }
}
