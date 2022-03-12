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

class SinglyLinkedListNode
{
    public int data;
    public SinglyLinkedListNode next;

    public SinglyLinkedListNode(int nodeData)
    {
        this.data = nodeData;
        this.next = null;
    }
}

class SinglyLinkedList
{
    public SinglyLinkedListNode head;
    public SinglyLinkedListNode tail;

    public SinglyLinkedList()
    {
        this.head = null;
        this.tail = null;
    }

    public void InsertNode(int nodeData)
    {
        SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

        if (this.head == null)
        {
            this.head = node;
        }
        else
        {
            this.tail.next = node;
        }

        this.tail = node;
    }
}

class SinglyLinkedListPrintHelepr
{
    public static void PrintList(SinglyLinkedListNode node, string sep, TextWriter textWriter)
    {
        while (node != null)
        {
            textWriter.Write(node.data);

            node = node.next;

            if (node != null)
            {
                textWriter.Write(sep);
            }
        }
    }
}

class MaximumQ
{

    /*
     * Complete the 'getNumber' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts INTEGER_SINGLY_LINKED_LIST binary as parameter.
     */

    /*
     * For your reference:
     *
     * SinglyLinkedListNode
     * {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     
     1. Recorrer los elementos de la lista uno por uno
     2. Por cada elemento de la lista que contenga 1, obtener la potencia de 2
     3. ir sumando estos valores por cada elemento en una variable result
     4. regresar la variable result
     
     */

    public static long getNumber(SinglyLinkedListNode binary)
    {
        Console.WriteLine("getNumber starts");
        int positions = 0;
        long result = 0;
       
        List<int> number = new List<int>();

        while (binary.next != null)
        {
            Console.WriteLine(binary.data);
            number.Add(binary.data);
            positions++;

            binary = binary.next;

            if (binary.next == null)
            {
                Console.WriteLine(binary.data);
                number.Add(binary.data);
                positions++;
            }
        }

        Console.WriteLine("positions = [{0}]", positions);

        for (int i = 0; i < number.Count; i++)
        {
            if (number[i] == 1)
            {
                result += (long)Math.Pow(2, positions - 1);
                Console.WriteLine("2^{0}=[{1}]", positions - 1, Math.Pow(2, positions - 1));
            }
            positions--;
        }

        Console.WriteLine("Number = [{0}]", result);
        return result;
    }
}

class Solution
{
    public static void Main2(string[] args)
    {
        SinglyLinkedList binary = new SinglyLinkedList();

        Console.WriteLine("Insert number of Elements;");
        int binaryCount = Convert.ToInt32(Console.ReadLine().Trim());

        for (int i = 0; i < binaryCount; i++)
        {
            Console.WriteLine("Element:");
            int binaryItem = Convert.ToInt32(Console.ReadLine().Trim());
            binary.InsertNode(binaryItem);
        }
        long result = MaximumQ.getNumber(binary.head);
    }
}
