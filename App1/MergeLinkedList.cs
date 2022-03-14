using System;
using System.Collections.Generic;

namespace LinkedListProblems
{
    public class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }
    }

    public class SinglyLinkedList2
    {
        public SinglyLinkedListNode head;
        public SinglyLinkedListNode tail;

        public SinglyLinkedList2()
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

        public void Print()
        {
            SinglyLinkedListNode runner = head;
            int counter = 0;
            while (runner != null)
            {
                System.Console.WriteLine("Node [{0}] = [{1}]", counter, runner.data);
                counter++;
                runner = runner.next;
            }
        }

        public void Delete(int value)
        {
            SinglyLinkedListNode runner = head;
            while (runner != null)
            {
                if (runner.next != null && runner.next.data == value)
                    runner.next = runner.next.next;
                else
                    runner = runner.next;
            }
        }

        public static void Start()
        {
            SinglyLinkedList2 sll1 = new SinglyLinkedList2();
            sll1.InsertNode(1);
            sll1.InsertNode(3);
            sll1.InsertNode(10);

            SinglyLinkedList2 sll2 = new SinglyLinkedList2();
            sll2.InsertNode(2);
            sll2.InsertNode(4);
            sll2.InsertNode(6);

            SinglyLinkedListNode head1 = mergeLists(sll1.head, sll2.head);

            SinglyLinkedListNode runner = head1;
            Console.WriteLine("Sorted Linked List");
            while (runner != null)
            {
                Console.WriteLine(runner.data);
                runner = runner.next;
            }
        }

        // Complete the mergeLists function below.
        /*
         * For your reference:
         *
         * SinglyLinkedListNode {
         *     int data;
         *     SinglyLinkedListNode next;
         * }
         *
         */
        public static SinglyLinkedListNode mergeLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {
            List<int> list = new List<int>();

            Console.WriteLine("head1");
            SinglyLinkedListNode runner = head1;
            while (runner != null)
            {
                Console.WriteLine(runner.data);
                list.Add(runner.data);
                runner = runner.next;
            }

            Console.WriteLine("head2");
            SinglyLinkedListNode runner2 = head2;
            while (runner2 != null)
            {
                Console.WriteLine(runner2.data);
                list.Add(runner2.data);
                runner2 = runner2.next;

            }
            list.Sort();

            Console.WriteLine("Elements");
            foreach (var item in list)
                Console.WriteLine(item);

            SinglyLinkedList2 sll = new SinglyLinkedList2();
            foreach (var item in list)
            {
                sll.InsertNode(item);
            }

            return sll.head;
        }
    }
}