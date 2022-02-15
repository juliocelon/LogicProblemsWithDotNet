using System;
namespace Logic
{
    public class LogicProblems
    {
        public static void FizzBuzz(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                        Console.WriteLine("FizzBuzz");
                    else
                        Console.WriteLine("Fizz");
                }
                else
                {
                    if (i % 5 == 0)
                        Console.WriteLine("Buzz");
                    else
                        Console.WriteLine(i);
                }
            }
        }

        public static void MostEfficientLoop(int n)
        {
            Console.WriteLine("for (int i = 0; i < n; i++)");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("int i = 0; i < n; i = i+2");
            for (int i = 0; i < n; i = i+2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("int i = 1; i < n; i = i * 2");
            for (int i = 1; i < n; i = i * 2)
            {
                Console.WriteLine(i);
            }

            //Console.WriteLine("int i = n; i > -1; i /= 2");
            //for (int i = n; i > -1; i /= 2)
            //{
            //    Console.WriteLine(i);
            //}
        }

        public static void PrintArray(int[] a)
        {
            int len = a.Length; int i = 0;
            if (len == 0)
                Console.WriteLine("Empty Array");
            else
            {
                do
                {
                    Console.WriteLine(a[i]);
                } while (++i < len);
            }
        }
    }
}
