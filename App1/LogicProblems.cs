using System;
using System.Collections;
using System.Collections.Generic;

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

        /*
         Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero.
        Print the decimal value of each fraction on a new line with  places after the decimal.
        Note: This challenge introduces precision problems. The test cases are scaled to six decimal places,
        though answers with absolute error of up to  are acceptable.
        Example
        There are 5 elements, two positive, two negative and one zero. Their ratios are 2/5, 2/5 and 1/5.
        Results are printed as:
        0.4
        0.4
        0.2
         */
        public static void plusMinus(List<int> arr) // 6 min.
        {
            double positives = 0;
            double negatives = 0;
            double zeros = 0;

            double totalElements = arr.Count;

            foreach (var item in arr)
            {
                if (item > 0)
                    positives++;
                else if (item < 0)
                    negatives++;
                else
                    zeros++;
            }

            Console.WriteLine("{0}", positives/totalElements);
            Console.WriteLine("{0}", negatives / totalElements);
            Console.WriteLine("{0}", zeros / totalElements);
        }

        /*
         * Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly 
         * four of the five integers. Then print the respective minimum and maximum values as a single line of two 
         * space-separated long integers.
         */
        public static void miniMaxSum(List<int> arr)
        {
            double minSum = 0;
            double maxSum = 0;
            double totalSum = 0;
            foreach (var item in arr)
            {
                totalSum += item;
            }

            double partialSum = 0;

            foreach (var item in arr)
            {
                partialSum = totalSum - item;

                if (maxSum < partialSum)
                    maxSum = partialSum;

                if (minSum == 0)
                    minSum = partialSum;

                if (minSum > partialSum)
                    minSum = partialSum;

            }

            Console.WriteLine("{0} {1}", minSum, maxSum);
        }

        public static string timeConversion(string s)
        {
            // s = hh:mm:ssAM or hh:mm:ssPM

            int hour;
            int.TryParse(s.Substring(0, 2), out hour);

            string time = s.Substring(s.Length - 2, 2);

            if (hour == 12 && time == "AM")
                hour = 0;

            if (time == "PM" && hour < 12)
                hour += 12;

            string hourNewformat = string.Format("{0,2:D2}", hour) + s.Substring(2, s.Length - 4);

            Console.WriteLine("Time New=[{0}]", hourNewformat);

            return hourNewformat;
        }

        public static int findMedian(List<int> arr)
        {
            Console.WriteLine("Input, unsorted array:");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            bool change = true;
            while (change)
            {
                change = false;
                for (int i = 0; i < arr.Count; i++)
                {
                    if (i < arr.Count - 1)
                    {
                        if (arr[i] > arr[i + 1])
                        {
                            change = true;
                            int temp = arr[i + 1];
                            arr[i + 1] = arr[i];
                            arr[i] = temp;
                        }
                    }
                }
            }

            Console.WriteLine("Sorted array:");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Median=[{0}]", arr[arr.Count / 2]);
            return arr[arr.Count/2];
        }

        public static int findMedian2(List<int> arr)
        {
            int[] a = new int[arr.Count];
            for (int i = 0; i < arr.Count; i++)
            {
                a[i] = arr[i];
            }
            Array.Sort(a);

            Console.WriteLine("Median=[{0}]", a[a.Length / 2]);
            return a[a.Length / 2];
        }

        public static int findMedian3(List<int> arr)
        {
            arr.Sort();
            Console.WriteLine("Median=[{0}]", arr[arr.Count / 2]);
            return arr[arr.Count / 2];
        }

        public static int lonelyinteger(List<int> a)
        {
            Hashtable ht = new Hashtable();

            foreach (var item in a)
            {
                if (ht.ContainsKey(item))
                    ht.Remove(item);
                else
                    ht.Add(item, 1);
            }

            foreach (var item in ht.Keys)
                return (int)item;

            return 0;
        }

        //Input: List arr with: arr[0] << number of square, arr[1] << the list of the numbers.
        public static int diagonalDifference(List<List<int>> arr)
        {
            List<int> elements = arr[1];
            int size = arr[0][0];
            int leftToRigth = 0;
            int rigthToLeft = 0;

            for (int i = 0; i < elements.Count;i++)
            {
                Console.WriteLine(elements[i]);
                if (i % (size + 1) == 0 || i==0)
                {
                    Console.WriteLine("LeftToRigth partial sum= [{0}]", elements[i]);
                    leftToRigth += elements[i];
                }

                if (i % (size -1) == 0 && i != 0 && i<elements.Count-1)
                {
                    Console.WriteLine("RigthToLeft partial sum= [{0}]", elements[i]);
                    rigthToLeft += elements[i];
                }

            }

            Console.WriteLine("LeftToRigth total sum = [{0}]", leftToRigth);
            Console.WriteLine("RigthToLeft total sum = [{0}]", rigthToLeft);

            int difference = 0;
            if (rigthToLeft > leftToRigth)
                difference = rigthToLeft - leftToRigth;
            else
                difference = leftToRigth - rigthToLeft;

            Console.WriteLine("Difference = [{0}]", difference);
            return difference;
        }

        // Receiving a list of lists of integers
        public static int diagonalDifference2(List<List<int>> arr)
        {
            List<int> elements = new List<int>();
            int size = arr[0].Count;
            int leftToRigth = 0;
            int rigthToLeft = 0;

            foreach (List<int> l in arr)
                elements.AddRange(l);

            for (int i = 0; i < elements.Count; i++)
            {
                Console.WriteLine(elements[i]);
                if (i % (size + 1) == 0 || i == 0)
                    leftToRigth += elements[i];

                if (i % (size - 1) == 0 && i != 0 && i < elements.Count - 1)
                    rigthToLeft += elements[i];
            }

            int difference = 0;
            if (rigthToLeft > leftToRigth)
                difference = rigthToLeft - leftToRigth;
            else
                difference = leftToRigth - rigthToLeft;

            return difference;
        }

        public static List<int> countingSort(List<int> arr)
        {

            int[] result = new int[100];

            for (int i = 0; i < arr.Count; i++)
            {
                result[arr[i]] += 1;
            }

            List<int> lst = new List<int>();
            lst.AddRange(result);

            foreach (var item in lst)
            {
                Console.Write("{0},", item);
            }

            return lst;
        }

        public static void SumNumber(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            Console.WriteLine("Sum=[{0}]", sum);
        }
    }
}
