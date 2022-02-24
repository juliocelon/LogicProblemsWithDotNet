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
            for (int i = 0; i < n; i = i + 2)
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

        public static void ModuleUse()
        {
            int[] a1 = { 1, 2, 3, 4, 5, 6 };

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("i=[{0}], i%{1}=[{2}], array[{2}]=[{3}]", i, a1.Length, i % a1.Length, a1[i % a1.Length]);
            }
        }

        public static void Fibonacci(int n) // O(n)
        {
            int n1 = 0, n2 = 1, n3, i, number;
            Console.Write("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
            for (i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
