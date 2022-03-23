using System;
using System.Collections.Generic;

namespace LogicProblems
{
    public class CoderByteMWS
    {
        public static void Start()
        {
            string[] strArr = { "ahffaksfajeeubsne", "jefaa" };
            //string[] strArr = { "aaabaaddae", "aed" };
            Console.WriteLine(MinWindowSubstring(strArr));
        }

        public static string MinWindowSubstring2(string[] strArr )
        {

            //Console.WriteLine("minWord = {0}", findSubString(strArr[0], strArr[1]));

            //List<string> words = new List<string>();
            //string keyWord = strArr[1];
            //string temp = string.Empty;

            //for(int j=0;j< strArr[0].Length;j++)
            //for (int i = j; i < strArr[0].Length; i++)
            //{
            //    char currentCharacter = strArr[0][i];
            //    if (keyWord.Contains(currentCharacter))
            //    {
            //        temp += strArr[0][i];
            //        int index = keyWord.IndexOf(currentCharacter);
            //        keyWord = keyWord.Remove(index, 1);

            //        if (keyWord.Length == 0)
            //        {
            //            words.Add(temp);
            //            temp = string.Empty;
            //            keyWord = strArr[1];
            //        }
            //    }
            //    else if (temp.Length > 0)
            //    {
            //        temp += strArr[0][i];
            //    }
            //}

            //string minWord = string.Empty;
            //foreach (var item in words)
            //{
            //    if (minWord.Length == 0)
            //        minWord = item;

            //    if (minWord.Length > item.Length)
            //        minWord = item;

            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("minWord = {0}", minWord);

            return "ok";
        }

        static String MinWindowSubstring(string[] strArr)
        {
            String input = strArr[0];
            String subKey = strArr[1];

            int inputLength = input.Length;
            int subKeyLength = subKey.Length;

            if (inputLength < subKeyLength)
            {
                Console.WriteLine("No such window exists");
                return "";
            }

            int[] subkeyValues = new int[256];
            int[] inputValues = new int[256];

            for (int i = 0; i < subKeyLength; i++)
                subkeyValues[subKey[i]]++;

            int start = 0;
            int start_index = -1;
            int min_len = int.MaxValue;

            // Start traversing the string
            // Count of characters
            int count = 0;
            for (int j = 0; j < inputLength; j++)
            {

                // Count occurrence of characters
                // of string
                inputValues[input[j]]++;

                // If string's char matches
                // with pattern's char
                // then increment count
                if (inputValues[input[j]] <= subkeyValues[input[j]])
                    count++;

                // if all the characters are matched
                if (count == subKeyLength)
                {

                    // Try to minimize the window
                    while (inputValues[input[start]]
                               > subkeyValues[input[start]]
                           || subkeyValues[input[start]] == 0)
                    {

                        if (inputValues[input[start]]
                            > subkeyValues[input[start]])
                            inputValues[input[start]]--;
                        start++;
                    }

                    // update window size
                    int len_window = j - start + 1;
                    if (min_len > len_window)
                    {
                        min_len = len_window;
                        start_index = start;
                    }
                }
            }

            // If no window found
            if (start_index == -1)
            {
                Console.WriteLine("No such window exists");
                return "";
            }

            // Return substring starting from start_index
            // and length min_len
            return input.Substring(start_index, min_len);
        }
    }

}
