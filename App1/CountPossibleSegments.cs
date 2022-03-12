using System;
using System.Collections.Generic;

namespace LogicProblems
{
    /*
     Amazon warehouse has a group of n items of various weights lined up in a row. A segment of contiguosly places items
        can be shipped together if and only if the difference between the weights of the heaviest and lightest item
        differs by at most k to avoid load imbalance.

        Given the weights of the n items and an integer k, find the number of segments of items that can be shipped together

        Note: A segment (l,r) is a subarray starting at index l and ending at index r where l <=r.

        Example:
        k = 3
        weights = [1,3,6]

    Weight difference between max and min for each (l,r) index pair are:

    (0,0) -> max(weights[0])- min(weights[0]) = max(1) - min(1) = 0
    (0,1)
    (0,2)
    (1,1)
    (1,2)
    (2,2)

    5 of the 6 possible segments have a difference less than or equal to 3. Return 5.

    Function description.

    Complete the function

    countPossibleSegments in the editor

    countPossibleSegments has the following parameters:

    int k: the maximum tolerable difference in weights
    int weights
        int weights[n]: the weights of the items

    Returns
        long int: the number of segments of items that can be shipped together.


     */
    public class CountPossibleSegments
    {
        public CountPossibleSegments()
        {


    /*
     * Complete the 'countPossibleSegments' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. INTEGER_ARRAY weights
     */

        }

        public static long countPossibleSegments(int k, List<int> weights)
        {
            int counter = 0;
            int index = 0;
            for (int i = 0; i <= weights.Count; i++)
            {
                for (int j = index; j <= weights.Count; j++)
                {
                    if ((max(weights, i, j) - min(weights, i, j)) <= k)
                        counter++;
                }
                index++;
            }

            return counter;
        }

        public static int max(List<int> weights, int minIndex, int maxIndex)
        {
            int max = weights[minIndex];
            for (int i = minIndex; i <= maxIndex; i++)
            {
                if (weights[i] > max)
                    max = weights[i];
            }
            return max;
        }

        public static int min(List<int> weights, int minIndex, int maxIndex)
        {
            int min = weights[minIndex];
            for (int i = minIndex; i <= maxIndex; i++)
            {
                if (weights[i] < min)
                    min = weights[i];
            }
            return min;
        }
    }
}
