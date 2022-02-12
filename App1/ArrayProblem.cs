using System;
using System.Collections;

namespace Arrays
{
    public class ArrayCase
    {
        public static int[] FindTwoNumbersThatMultiply(int[] array, int goal)
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

        public static int[] FindThreeNumbersThatMultiply(int[] array, int goal)
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
                        two = FindTwoNumbersThatMultiply(newArray, multiplyNumber);
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
    }
}
