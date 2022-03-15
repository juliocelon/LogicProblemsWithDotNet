using System;
using System.Collections.Generic;

namespace LogicProblems
{
    class BraketsChallenge
    {

        public static void Start()
        {
            Console.WriteLine(isBalanced("{[()]}"));
        }

        /*
         * Complete the 'isBalanced' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */


        public static string isBalanced(string s)
        {
            List<int> list = new List<int>();

            foreach (char c in s)
            {
                int val = ReturnVal(c);

                if (val < 0 && list.Count == 0)
                    return "NO";

                if (val < 0)
                {
                    int difference = list[list.Count - 1] + val;
                    list.RemoveAt(list.Count - 1);

                    if (difference != 0)
                        return "NO";
                }
                else
                    list.Add(ReturnVal(c));
            }

            if (list.Count > 0)
                return "NO";

            return "YES";
        }

        public static int ReturnVal(char c)
        {
            switch (c)
            {
                case '(':
                    return 1;
                case ')':
                    return -1;
                case '[':
                    return 2;
                case ']':
                    return -2;
                case '{':
                    return 3;
                case '}':
                    return -3;
                default:
                    return 0;
            }
        }
    }
}
