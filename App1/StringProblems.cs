using System;
using System.Collections;
using System.Collections.Generic;

namespace LogicProblems
{
    public class StringProblems
    {
        public static void NoRepeatingCharacter(string message)
        {
            Hashtable ht = new Hashtable();
            List<char> list = new List<char>();

            for (int i = 0; i < message.Length; i++)
            {
                if (ht.ContainsKey(message[i]))
                {
                    ht[message[i]] = (int)ht[message[i]] + 1;
                    list.Remove(message[i]);
                }
                else
                {
                    ht.Add(message[i], 1);
                    list.Add(message[i]);
                }
            }

            if (list.Count > 0)
                Console.WriteLine("Message:[{0}], first character no repeated:[{1}]", message, list[0]);
            else
                Console.WriteLine("Message:[{0}], There isn´t no repeating character", message);
        }

        public static bool IsOneAway(string message1, string message2)
        {
            if (message1.Length == message2.Length)
                IsOneAwaySameLength(message1, message2);
            else if (message1.Length > message2.Length)
                IsOneAwayDifferentLength(message2, message1);
            else
                IsOneAwayDifferentLength(message1, message2);

            return true;
        }

        public static bool IsOneAwaySameLength(string message1, string message2)
        {
            int failCounter = 0;
            for (int i = 0, j = 0; i < message1.Length; i++, j++)
            {
                if (message1[i] != message2[j])
                {
                    if (failCounter == 1)
                    {
                        Console.WriteLine("NO Is One away: [{0}],[{1}]", message1, message2);
                        return false;
                    }
                    else
                        failCounter++;
                }
            }
            Console.WriteLine("Is One away: [{0}],[{1}]", message1, message2);
            return true;
        }

        public static bool IsOneAwayDifferentLength(string message1, string message2)
        {
            // lenght of message1 should be lesser than lenght of message2
            int lenghtDifference = message2.Length - message1.Length;
            if (lenghtDifference >= 2)
            {
                Console.WriteLine("No Is One away: [{0}],[{1}]. They have different length.", message1, message2);
                return false;
            }
            int failCounter = 0;
            for (int i = 0, j = 0; i < message1.Length;)
            {
                if (message1[i] != message2[j])
                {
                    if (failCounter == 1)
                    {
                        Console.WriteLine("No Is One away: [{0}],[{1}]", message1, message2);
                        return false;
                    }
                    else
                        failCounter++;
                    j++;
                }
                else
                {
                    i++;
                    j++;
                }
            }
            Console.WriteLine("Is One away: [{0}],[{1}]", message1, message2);
            return true;
        }
    }


}
