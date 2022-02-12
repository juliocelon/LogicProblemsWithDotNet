using System;
using System.Collections;

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
    }
}
