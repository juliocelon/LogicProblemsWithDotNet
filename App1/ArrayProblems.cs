using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Arrays
{
    public class ArrayCase
    {
        public static int[] FindTwoMultiplesOf(int[] array, int goal)
        {
            Hashtable ht = new Hashtable();

            for (int i = 0; i < array.Length; i++)
            {
                if (goal % array[i] == 0) // integer division
                {
                    int multipleNumber = goal / array[i];
                    if (ht.ContainsValue(multipleNumber))
                    {
                        Console.WriteLine("{0}*{1}={2}", multipleNumber, array[i], goal);
                        return new int[] { multipleNumber, array[i] };
                    }
                }

                ht.Add(i, array[i]);
            }
            return new int[] { };
        }

        public static int[] FindThreeMultiplesOf(int[] array, int goal)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (goal % array[i] == 0)
                {
                    int multiplyNumber = goal / array[i];
                    int[] two = { };
                    if (i < array.Length - 2)
                    {
                        int[] newArray = CutArray(array, i + 1);
                        two = FindTwoMultiplesOf(newArray, multiplyNumber);
                    }

                    if (two.Length != 0)
                    {
                        Console.WriteLine("{0}*{1}*{2}={3}", two[0], two[1], array[i], goal);
                        return new int[] { two[0], two[1], array[i] };
                    }
                }
            }
            return new int[] { };
        }

        public static int[] CutArray(int[] array, int positions)
        {
            int[] newArray = new int[array.Length - positions];
            for (int i = positions, j = 0; i < array.Length; i++, j++)
                newArray[j] = array[i];
            return newArray;
        }

        public static void GetMostFrecuentNumber(int[] input)
        {
            Hashtable ht = new Hashtable();
            int[] maximum = { 0, 0 };

            for (int i = 0; i < input.Length; i++)
            {
                if (ht.ContainsKey(input[i]))
                    ht[input[i]] = (int)ht[input[i]] + 1;
                else
                    ht.Add(input[i], 1);

                if ((int)ht[input[i]] > maximum[1])
                {
                    maximum[0] = input[i];
                    maximum[1] = (int)ht[input[i]];
                }
            }

            Console.WriteLine("Most Frecuent number is [{0}], it is [{1}] times", maximum[0], maximum[1]);
        }

        public static char GetMostFrecuentCharacter(string text)
        {
            Hashtable ht = new Hashtable();
            char character = ' ';
            int amount = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (ht.ContainsKey(text[i]))
                    ht[text[i]] = (int)ht[text[i]] + 1;
                else
                    ht.Add(text[i], 1);

                if ((int)ht[text[i]] > amount)
                {
                    character = text[i];
                    amount = (int)ht[text[i]];
                }
            }
            return character;
        }

        //Function that returns the common elements (as an array)
        // between two sorted arrays of integers (ascending order)
        public static ArrayList CommonElements(int[] array1, int[] array2)
        {
            ArrayList commonElements = new ArrayList();
            int array1Pointer = 0;
            int array2Pointer = 0;

            while (array1Pointer < array1.Length && array2Pointer < array2.Length)
            {
                if (array1[array1Pointer] == array2[array2Pointer])
                {
                    commonElements.Add(array1[array1Pointer]);
                    array1Pointer++;
                    array2Pointer++;
                }
                else if (array1[array1Pointer] > array2[array2Pointer])
                    array2Pointer++;
                else
                    array1Pointer++;
            }

            Console.WriteLine("Common Elements:");
            foreach (var item in commonElements)
            {
                Console.WriteLine(item);
            }
            return commonElements;
        }

        /* Disk Space Analysis

        A company is performing an analysis on the computers at its main office. The computers are spaced along a single row.
        For each group of contiguous computers of a certaint length, that is, for each segment, determine the minimum amount
        of disk space available on a computer. Return the maximum of these values as your answer.

        Example.
        n = 4 , number of computers
        space = [8,2, 4, 6]
        x = 2, the segment length

        The free disk space of computers in each of the segments is [8,2], [2,4] and [4,6].
        The minima of the three segments are [2, 2, 4].
        The maximum of these is 4.

        Function Description

        Complete the function Segment

        Segment has the following parameters:
        int x: the segment length to analyze
        int space[n]: the available hard disk space on each of the computers

        Returns:
        int: The maximum of the minimum values of available hard disk space found while analyzing the computers in segments of
        length x.

        Example Case:

        length of segments x = 3
        size of space = 5
        space = [2, 5, 4, 6, 8]

        Explanation:

        The segments of size x=3 are: [2,5,4] , [5,4,6] and [4,6,8]
        The respective minimum values are: 2,4,4
        The maximum of these values is 4
        */

        public static int Segment(int x, List<int> space) // Function using a while
        {
            int numberOfSegments = space.Count - (x - 1);

            Console.WriteLine("Input:");
            Console.WriteLine("Number of Elements : [{0}]", space.Count);
            Console.WriteLine("Length of each segment: [{0}]\n", x);
            Console.WriteLine("Number of segments calculated: [{0}]\n", numberOfSegments);

            int minValue = space[0];
            int maxValue = 0;

            int innerSegmentPointer = 0;
            int nextSegmentPointer = 0;

            while (nextSegmentPointer < numberOfSegments)
            {

                if (innerSegmentPointer == x)
                {
                    innerSegmentPointer = 0;
                    nextSegmentPointer++;

                    Console.WriteLine("Min Value of the segment = [{0}]", minValue);
                    Console.WriteLine();

                    if (maxValue < minValue)
                        maxValue = minValue;

                    minValue = space[nextSegmentPointer + innerSegmentPointer];
                }

                if (minValue > space[nextSegmentPointer + innerSegmentPointer])
                    minValue = space[nextSegmentPointer + innerSegmentPointer];

                if (nextSegmentPointer < numberOfSegments)
                    Console.WriteLine("{0}. {1}.", innerSegmentPointer, space[nextSegmentPointer + innerSegmentPointer]);

                innerSegmentPointer += 1;
            }

            Console.WriteLine("Max Value = [{0}]", maxValue);
            return maxValue;
        }

        public static int Segment2(int x, List<int> space) // Function using a for
        {
            int numberOfSegments = space.Count - (x - 1);

            Console.WriteLine("Input:");
            Console.WriteLine("Number of Elements : [{0}]", space.Count);
            Console.WriteLine("Length of each segment: [{0}]\n", x);
            Console.WriteLine("Number of segments calculated: [{0}]\n", numberOfSegments);

            int minValue = space[0];
            int maxValue = 0;

            for (int nextSegmentPointer = 0, innerSegmentPointer = 0; nextSegmentPointer < numberOfSegments; innerSegmentPointer++)
            {
                if (innerSegmentPointer == x)
                {
                    innerSegmentPointer = 0;
                    nextSegmentPointer++;

                    Console.WriteLine("Min Value of the segment = [{0}]", minValue);
                    Console.WriteLine();

                    if (maxValue < minValue)
                        maxValue = minValue;

                    minValue = space[nextSegmentPointer + innerSegmentPointer];
                }

                if (minValue > space[nextSegmentPointer + innerSegmentPointer])
                    minValue = space[nextSegmentPointer + innerSegmentPointer];

                if (nextSegmentPointer < numberOfSegments)
                    Console.WriteLine("{0}. {1}.", innerSegmentPointer, space[nextSegmentPointer + innerSegmentPointer]);

            }

            Console.WriteLine("Max Value = [{0}]", maxValue);
            return maxValue;
        }

        public static bool IsArrayRotation(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
                return false;

            bool firstElementFounded = false;
            for (int i = 0, j = 0; i < array1.Length;)
            {
                if (array1[i] == array2[j])
                {
                    if (firstElementFounded == false)
                        firstElementFounded = true;

                    i++;

                    if (j == array2.Length - 1)
                        j = 0;
                    else
                        j++;
                }
                else
                {
                    if (firstElementFounded == true)
                        return false;

                    if (j == array2.Length - 1)
                    {
                        if (firstElementFounded == false)
                            return false;
                        j = 0;
                    }
                    else
                        j++;
                }
            }
            return true;
        }

        public static bool IsArrayRotationV2(int[] array1, int[] array2) // using % to control variable j
        {
            if (array1.Length != array2.Length)
                return false;

            bool firstElementFounded = false;
            for (int i = 0, j = 0; i < array1.Length;)
            {
                if (array1[i] == array2[j])
                {
                    if (firstElementFounded == false)
                        firstElementFounded = true;
                    i++;
                }
                else
                {
                    if (firstElementFounded == true)
                        return false;

                    if (j == array2.Length - 1)
                    {
                        if (firstElementFounded == false)
                            return false;
                    }
                }

                j = (j + 1) % array2.Length; // using module to increment j
            }
            return true;
        }


        // Minimum moves between 2 arrays, arr1 to change, arr2 to match foreach digit.
        // Example.
        // arr1 = {123,456}
        // arr2 = {223,557}
        // To make arr1 equal to arr2, you should:
        // 1. increment in one, arr1[0] on position [0], I mean: 1 to 2, 1 move
        // 2. increment in one, arr1[1] on position [0] and [2], I mean: 4 to 5, and 6 to 7, 2 moves
        // Total moves=3 moves
        public static int minimumMoves(List<int> arr1, List<int> arr2)
        {
            int counter = 0;

            for (int i = 0; i < arr1.Count; i++)
            {
                List<char> digitsArr1 = new List<char>();
                foreach (char digit in arr1[i].ToString())
                    digitsArr1.Add(digit);

                List<char> digitsArr2 = new List<char>();
                foreach (char digit in arr2[i].ToString())
                    digitsArr2.Add(digit);

                for (int j = 0; j < digitsArr1.Count; j++)
                {
                    int digitArr1 = Convert.ToInt32(digitsArr1[j]);
                    int digitArr2 = Convert.ToInt32(digitsArr2[j]);
                    if (digitArr1 > digitArr2)
                        counter += digitArr1 - digitArr2;
                    else if (digitsArr1[j] < digitsArr2[j])
                        counter += digitArr2 - digitArr1;
                }
            }
            return counter;
        }

        public static List<int> GetDigits(int number)
        {
            Console.WriteLine("Getdigits, input=[{0}]", number);
            List<int> digits = new List<int>();
            while (number > 0)
            {
                digits.Add(number % 10);
                Console.WriteLine("number % 10=[{0}]", number % 10);
                Console.WriteLine("number / 10=[{0}]", number / 10);
                number = number / 10;
            }
            digits.Reverse();
            return digits;
        }

        public static int[] GetDigitsOnIntArray(int number)
        {
            Console.WriteLine("Getdigits, input=[{0}]", number);
            int[] digits = new int[number.ToString().Length];
            int i = 0;
            while (number > 0)
            {
                digits[i] = number % 10;
                Console.WriteLine("number % 10=[{0}]", number % 10);
                Console.WriteLine("number / 10=[{0}]", number / 10);
                number = number / 10;
            }
            return digits;
        }

        public static void Minesweeper(int[,] bombs, int rows, int columns)
        {
            int[,] a2 = new int[rows, columns];

            for (int i = 0; i < bombs.GetLength(0); i++)
            {
                a2[bombs[i, 0], bombs[i, 1]] = -1;
                Console.WriteLine();
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (a2[i, j] == -1)
                    {
                        if (i - 1 >= 0)
                        {
                            if (j - 1 >= 0)
                                if (a2[i - 1, j - 1] != -1)
                                    a2[i - 1, j - 1] += 1;

                            if (a2[i - 1, j] != -1)
                                a2[i - 1, j] += 1;

                            if (j + 1 < columns)
                                if (a2[i - 1, j + 1] != -1)
                                    a2[i - 1, j + 1] += 1;
                        }

                        if (j - 1 >= 0)
                            if (a2[i, j - 1] != -1)
                                a2[i, j - 1] += 1;

                        if (j + 1 < columns)
                            if (a2[i, j + 1] != -1)
                                a2[i, j + 1] += 1;

                        if (i + 1 < rows)
                        {
                            if (j - 1 >= 0)
                                if (a2[i + 1, j - 1] != -1)
                                    a2[i + 1, j - 1] += 1;

                            if (a2[i + 1, j] != -1)
                                a2[i + 1, j] += 1;

                            if (j + 1 < columns)
                                if (a2[i + 1, j + 1] != -1)
                                    a2[i + 1, j + 1] += 1;
                        }

                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(" [{0,2}] ", a2[i, j]);
                }
                Console.WriteLine();
            }

        }

        // Given a string, determine the length of the longest subsequence that contains all of the vowels,
        //  in order, and no vowels out of order. Vowels in order are the letters in the string 'aeiou'
        // Example:
        // the string aeeiiouu contains all vowels in order.
        // the string aeeiiaouu does not.
        // The function should return the length of the longest subsequence within the input string that
        //  containcs all of the vowels in roder.
        //  If one does not occur in the string, return 0

        public static int LongestVowelSubsequence(string text)
        {
            Hashtable ht = new Hashtable();// id and length
            int htId = 0;

            int subsequenceCounter = 0;
            int maxSubsecuenceCounter = 0;

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int vowelsPointer = 0;

            bool subsequenceOn = false;

            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(">>[{0}]", text[i]);
                Console.WriteLine(">>counter=[{0}]", subsequenceCounter);
                Console.WriteLine(">>maxcounter=[{0}]", maxSubsecuenceCounter);

                if (text[i] == vowels[vowelsPointer])
                {
                    Console.WriteLine("text[i] == vowels[vowelsPointer]");
                    if (vowels[vowelsPointer] == 'u' && i == text.Length - 1)
                    {
                        Console.WriteLine("vowels[vowelsPointer] == 'u' && i==text.Length-1");
                        subsequenceCounter++;
                        Console.WriteLine("Ya esta en la u");
                        if (maxSubsecuenceCounter < subsequenceCounter)
                            maxSubsecuenceCounter = subsequenceCounter;
                        subsequenceOn = false;
                    }
                    else
                    {
                        Console.WriteLine("ELSE vowels[vowelsPointer] == 'u' && i==text.Length-1");
                        subsequenceCounter++;
                        subsequenceOn = true;
                    }
                }
                else
                {
                    Console.WriteLine("ELSE text[i] == vowels[vowelsPointer]");
                    if (i == text.Length - 1)
                    {
                        Console.WriteLine("i == text.Length - 1");
                        if (vowels[(vowelsPointer + 1) % vowels.Length] == 'u')
                        {
                            Console.WriteLine("vowels[vowelsPointer] == 'u'");
                            subsequenceCounter++;
                            Console.WriteLine("Ya esta en la u");
                            if (maxSubsecuenceCounter < subsequenceCounter)
                                maxSubsecuenceCounter = subsequenceCounter;
                        }
                        subsequenceOn = false;
                        vowelsPointer = 0;
                        subsequenceCounter = 0;
                    }
                    else
                    {
                        if (text[i] == vowels[(vowelsPointer + 1) % vowels.Length])
                        {
                            Console.WriteLine("siguiente vocal ok");
                            subsequenceOn = true;
                            subsequenceCounter++;
                            vowelsPointer++;
                            if (vowels[vowelsPointer] == 'u' && i == text.Length - 1)
                            {
                                Console.WriteLine("vowels[vowelsPointer] == 'u' && i==text.Length-1");
                                subsequenceCounter++;
                                Console.WriteLine("Ya esta en la u");
                                if (maxSubsecuenceCounter < subsequenceCounter)
                                    maxSubsecuenceCounter = subsequenceCounter;
                                subsequenceOn = false;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Termina la secuencia");
                            subsequenceOn = false;
                            vowelsPointer = 0;
                            subsequenceCounter = 0;
                        }
                    }
                }
            }

            Console.WriteLine(maxSubsecuenceCounter);

            return 0;
        }

        public static void Piramid()
        {
            int space, startsLength = 1, numberRows;
            Console.WriteLine("Enter row count : ");
            numberRows = Convert.ToInt32(Console.ReadLine());
            space = numberRows - 1;

            for (int i = 1; i <= numberRows; i++)
            {
                for (int r = 1; r <= space; r++)
                {
                    Console.Write(" ");
                }
                for (int s = 1; s <= startsLength; s++)
                {
                    Console.Write("*");
                }
                space--;
                startsLength = startsLength + 2;
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        /*
            * 
            * Given an array of integers and a target value, determine the number of pairs of array elements 
            * that have a difference equal to the target value.
            * 
            * Example
            * k=1
            * arr=[1,2,3,4]
            * 
            * There´re that differ by k=1: 2-1,3-2,4-3. Return 3.
            * 
            * Complete the 'pairs' function below.
            *
            * The function is expected to return an INTEGER.
            * The function accepts following parameters:
            *  1. INTEGER k
            *  2. INTEGER_ARRAY arr
         */
        public static void startPairs()
        {
            List<int> arr = new List<int> { 1,3,2,4};

            Console.WriteLine(pairs(1,arr));
        }


        public static int pairs(int k, List<int> arr)
        {
            int counter = 0;

            HashSet<int> hs = new HashSet<int>(arr);

            for (int i = 0; i < arr.Count; i++)
            {
                int numberToFind = 0;
                numberToFind = arr[i] + k;
                if (hs.Contains(numberToFind))
                    counter++;
            }

            // Slow alternative:
            //for (int i = 0; i < arr.Count; i++)
            //{
            //    for (int j = i+1; j < arr.Count; j++)
            //    {
            //        int difference = arr[i] - arr[j];
            //        if (difference == k || difference == -k)
            //        {
            //            counter += 1;
            //        }
            //    }
            //}
            return counter;
        }
    }
}