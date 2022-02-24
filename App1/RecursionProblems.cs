using System;
namespace Recursions
{
    public class RecursionCase
    {
        public static void PrintMessage50times(string message, int times)
        {
            Console.WriteLine("{0}. {1}", times, message);
            if (times < 50)
                PrintMessage50times(message, times + 1);
        }

        public static int Factorial(int n) // O(n!)
        {
            if (n == 1)
                return 1;
            return n * Factorial(n - 1);
        }

        public static int Fibonacci(int n) // O(2 ^ n)
        {
            if (n <= 1)
                return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
