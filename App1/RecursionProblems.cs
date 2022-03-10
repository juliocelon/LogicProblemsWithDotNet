using System;
using System.Text;

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

        public static int superDigit(string n, int k)
        {
            string newN = repeatString(n, k);
            Console.WriteLine(">[{0}]", newN);

            int result = superDigitR(newN);
            return result;
        }

        public static int superDigitR(string n)
        {
            if (n.Length == 1)
            {
                return int.Parse(n);
            }

            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                int num = int.Parse(n[i].ToString());
                sum += num;
            }
            return superDigitR(sum.ToString());
        }

        public static string repeatString(string n, int k)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < k; i++)
                sb.Append(n);
            return sb.ToString();
        }

        // Get Number of
        public static int numOfDigits = 0;

        public static void GetNumberOfDigits(int value)
        {
            if (value > 0)
            {
                numOfDigits++;
                GetNumberOfDigits(value/10);
            }
        }
    }
}
