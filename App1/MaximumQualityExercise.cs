using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

public class MaximumQuality
{

    /*
     Amazon´s AWS provides fast and efficient server solutions. The developers want to stress-test the quality
        of the servers´channels. They must ensure the following:

    - Each of the packets must be sent via a single channel
    - Each of the channels must transfer at least one packet

    The quality of the transfer for a channel is defined by the median of the sizes of all the data packets sent
        through that channel.

    Note: The median of an array is the middle element if the array is sorted in non-decreasing order. If the number
        of elements in the array is even, the median is the average of the two middle elements.

    Find the maximum possible sum of the qualities of all channels. If the answer is a floating-point value, round it
    to the next higher integer.

    Example
    packets = [1,2,3,4,5]
    channels = 2

    At least one packet has to go through each of the channels. One maximal solution is to transfer packets {1,2,3,4}
        through channel 1 and packet {5} through channel 2.

    Channel 1: {1,2,3,4}
    Channel 2: {5}

    The quality of transfer for channel 1 is (2+3)/2 = 2.5 and that of channel 2 is 5. Their sum is 2.5+5=7.5
        which rounds up to 8.

    Function description
    Complete the function maximumQuality in the editor below.

    maximumQuality has the following
    parameter(s):
        int packets[n]: the packet sizes.
        int channels: the number of channels

    Returns:
        long int: the maximum sum possible

    Sample Case 0

        packets[] size = 5
        packets = [2,2,1,5,3]
        channels = 2

        Samples Output = 7

        Explanation

        On solution is to send packet {5} through one channel and {2,2,1,3} through the other.
        The sum of quality is 5 + (2+2)/2 = 7

     */
    /*
     * Complete the 'maximumQuality' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY packets
     *  2. INTEGER channels
     */

    public static void Start()
    {
        List<int> packets = new List<int>();
        packets.Add(5);
        packets.Add(2);
        packets.Add(3);
        packets.Add(1);
        packets.Add(2);

        int channels = 2;

        Console.WriteLine(maximumQuality(packets, channels));
    }

    public static long maximumQuality(List<int> packets, int channels)
    {
        packets.Sort();

        List<List<int>> list = new List<List<int>>();

        Console.WriteLine("channels=" + channels);

        for (int i = packets.Count - 1, counter = 1; counter < packets.Count - 1; i--, counter++)
        {
            if (counter == channels)
                list.Add(packets);
            else
            {
                List<int> partialList = new List<int>();
                partialList.Add(packets[i]);

                list.Add(partialList);
                packets.RemoveAt(i);
            }
        }

        long sumQuality = 0;

        foreach (List<int> item in list)
        {
            Console.WriteLine("median=[{0}]", median(item));
            sumQuality += median(item);
        }

        Console.WriteLine("sumQuality=[{0}]", sumQuality);
        return sumQuality;
    }

    public static long median(List<int> input)
    {
        if (input.Count % 2 == 0)
            return (input[input.Count / 2] + input[(input.Count / 2) - 1]) / 2;
        else
            return input[input.Count / 2];
    }

}