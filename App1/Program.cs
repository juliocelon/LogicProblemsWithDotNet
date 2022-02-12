using System;
using System.Collections;
using Arrays;
using Recursions;

namespace LogicProblems
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayCase.FindTwoNumbersThatMultiply(new int[] { 2, 3, 4, 5, 6, 7 }, 15);

            ArrayCase.FindThreeNumbersThatMultiply(new int[] { 2, 4, 6, 1, 3, 5 }, 60);

            ArrayCase.CutArray(new int[] { 1, 3, 5, 2, 5, 3 }, 2);

            RecursionCase.PrintMessage50times("Hello World", 1);

        }
    }

}
