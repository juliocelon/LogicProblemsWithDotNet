using System;
using System.Collections;
using System.Collections.Generic;

namespace Arrays
{
    public class ArrayCase
    {
        public static int[] FindTwoMultiplesOf(int[] array, int goal)
        {
            Hashtable ht = new Hashtable();

            for (int i = 0; i < array.Length; i++)
            {
                if (goal % array[i] == 0)
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

        public static void GetMostFrecuent(int[] input)
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
            int numberOfSegments = space.Count -  (x - 1);

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
            for (int i = 0, j=0; i < array1.Length;)
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

        public static void ModuleUse()
        {
            int[] a1 = { 1, 2, 3, 4, 5, 6 };

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("i=[{0}], i%{1}=[{2}], array[{2}]=[{3}]",i, a1.Length, i % a1.Length, a1[i % a1.Length]);
            }
        }
    }
}
