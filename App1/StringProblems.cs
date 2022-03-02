using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

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

 /*
 * Julius Caesar protected his confidential information by encrypting it using a cipher. 
 * Caesar's cipher shifts each letter by a number of letters. If the shift takes you past the end of 
 * the alphabet, just rotate back to the front of the alphabet. In the case of a rotation by 3, w, x, y 
 * and z would map to z, a, b and c.
 * 
 * */

 public static string CaesarCipher(string s, int k)
 {
     StringBuilder newMessage = new StringBuilder();
           
     for (int i = 0; i < s.Length; i++)
     {
         int character = (int)s[i];
         Console.WriteLine("value=[{0}], intValue=[{1}]", (char)s[i], (int)s[i]);

         int newCharacter = 0;
         if (character >= 65 && character <= 90)
         {
             Console.WriteLine("mayus");
             if (character + k > 90)
             {
                 int difference = 90 - character;
                 newCharacter = 64 + (k - difference);
             }
             else
                 newCharacter = character + k;
         }
         else if (character >= 97 && character <= 122)
         {
             if (character + k > 122)
             {
                 int difference = 122 - character;
                 newCharacter = 96 + (k - difference);
             }
             else
                 newCharacter = character + k;
         }
         else
             newCharacter = character;

         Console.WriteLine("newValue = [{0}], intNewValue = [{1}]", (char)newCharacter, newCharacter);
         newMessage.Append((char)newCharacter);
     }

     Console.WriteLine("newMessage = [{0}]", newMessage);

     return newMessage.ToString();
 }

    }
}
