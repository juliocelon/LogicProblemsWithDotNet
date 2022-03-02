using System;
using System.Collections;
using System.Collections.Generic;
using Arrays;
using Recursions;
using LogicProblems;

namespace Logic
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayCase.FindTwoMultiplesOf(new int[] { 2, 3, 4, 5, 6, 7 }, 15);

            ArrayCase.FindThreeMultiplesOf(new int[] { 2, 4, 6, 1, 3, 5 }, 60);

            ArrayCase.CutArray(new int[] { 1, 3, 5, 2, 5, 3 }, 2);

            ArrayCase.GetMostFrecuentNumber(new int[] { 1, 2, 3, 2, 2, 4 });

            ArrayCase.CommonElements(new int[] { 1, 2, 3, 4, 5, 14, 15, 25, 27 }, new int[] { 2, 4, 6, 8, 10, 14, 15, 27, 28, 29, 30 });

            List<int> list = new List<int>();
            list.Add(2);
            list.Add(5);
            list.Add(4);
            list.Add(6);
            list.Add(8);
            ArrayCase.Segment2(3, list);

            Console.WriteLine(ArrayCase.IsArrayRotationV2(new int[] { 1, 2, 3, 4 }, new int[] { 4, 1, 2, 3 }));

            StringProblems.NoRepeatingCharacter("juliocelon");

            StringProblems.IsOneAway("abcde", "abcd");  // should return true
            StringProblems.IsOneAway("aaa", "abc");  // should return false

            LogicProblems.ModuleUse();

            RecursionCase.PrintMessage50times("Hello World", 1);

            LogicProblems.FizzBuzz(20);

            LogicProblems.MostEfficientLoop(10);

            LogicProblems.PrintArray(new int[] { 10, 20 });

            ArrayCase.Minesweeper(new int[,] { { 0, 0 }, { 0, 2 }, { 0, 1 }, { 2, 1 }, { 2, 1 }, { 3, 3 } }, 4, 4);

            List<int> arr1 = new List<int>();
            arr1.Add(123);
            arr1.Add(456);

            List<int> arr2 = new List<int>();
            arr2.Add(789);
            arr2.Add(888);

            ArrayCase.minimumMoves(arr1, arr2);

            ArrayCase.GetDigits(2468);
            ArrayCase.GetDigitsOnIntArray(3463);

            ArrayCase.GetMostFrecuentCharacter("holaa");

            ArrayCase.LongestVowelSubsequence("aeiooua");

            Console.WriteLine(RecursionCase.Factorial(5));
            Console.WriteLine(RecursionCase.Fibonacci(5));
            LogicProblems.Fibonacci(5);

            ArrayCase.Piramid();

            SinglyLinkedList binary = new SinglyLinkedList();

            Console.WriteLine("Insert number of Elements;");
            int binaryCount = Convert.ToInt32(Console.ReadLine().Trim());

            for (int i = 0; i < binaryCount; i++)
            {
                Console.WriteLine("Element {0}:", i);
                int binaryItem = Convert.ToInt32(Console.ReadLine().Trim());
                binary.InsertNode(binaryItem);
            }
            long result = Result.getNumber(binary.head);

            LogicProblems.timeConversion("01:02:03PM");
            LogicProblems.timeConversion("04:02:03PM");
            LogicProblems.timeConversion("05:02:03PM");


            List<int> arr = new List<int>();
            arr.Add(10);
            arr.Add(2);
            arr.Add(8);
            arr.Add(1);
            arr.Add(6);
            arr.Add(3);
            arr.Add(4);

            LogicProblems.findMedian(arr);
            LogicProblems.findMedian2(arr);
            LogicProblems.findMedian3(arr);

            //List<int> arr2 = new List<int>();
            //arr2.Add(1);
            //arr2.Add(2);
            //arr2.Add(3);
            //arr2.Add(2);
            //arr2.Add(1);
            //LogicProblems.lonelyinteger(arr2);

            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> squareSize = new List<int>() { 3 };

            List<List<int>> arr3 = new List<List<int>>();
            arr3.Add(squareSize);
            arr3.Add(list);

            LogicProblems.diagonalDifference(arr3);

            List<int> list2 = new List<int>() { 1, 2, 3, 4, 5, 1, 7, 8, 9, 10, 1, 12, 13, 14, 15, 1 };
            List<int> squareSize2 = new List<int>() { 4 };

            List<List<int>> arr4 = new List<List<int>>();
            arr4.Add(squareSize2);
            arr4.Add(list2);

            LogicProblems.diagonalDifference(arr4);

            List<int> list3 = new List<int>() { 1, 3, 5, 3, 6 };
            LogicProblems.countingSort(list3);

            StringProblems.CaesarCipher("www.abc.xy", 87);
        }
    }

}
