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

            ArrayCase.GetMostFrecuent(new int[] { 1, 2, 3, 2, 2, 4 });

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

            StringProblems.IsOneAway("abc", "bcc");
            StringProblems.IsOneAway("abc", "abcde");
            StringProblems.IsOneAway("aaa", "abc");

            StringProblems.IsOneAwaySameLength("abs", "abc");
            StringProblems.IsOneAwaySameLength("absde", "abcdh");
            StringProblems.IsOneAwaySameLength("absd", "abcd");

            StringProblems.IsOneAway("abcde", "abcd");  // should return true
            StringProblems.IsOneAway("abde", "abcde");  // should return true
            StringProblems.IsOneAway("a", "a");  // should return true
            StringProblems.IsOneAway("abcdef", "abqdef");  // should return true
            StringProblems.IsOneAway("abcdef", "abccef");  // should return true
            StringProblems.IsOneAway("abcdef", "abcde");  // should return true
            StringProblems.IsOneAway("aaa", "abc");  // should return false
            StringProblems.IsOneAway("abcde", "abc");  // should return false
            StringProblems.IsOneAway("abc", "abcde");  // should return false
            StringProblems.IsOneAway("abc", "bcc");  // should return false

            ArrayCase.ModuleUse();

            RecursionCase.PrintMessage50times("Hello World", 1);

            LogicProblems.FizzBuzz(20);

            LogicProblems.MostEfficientLoop(10);

            LogicProblems.PrintArray(new int[] { 10, 20 });


        }
    }

}
