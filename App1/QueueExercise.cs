using System;
using System.Collections.Generic;

namespace LogicProblems
{
    public class QueueExercise
    {
        public static void Start()
        {
            try
            {
                Queue queue = new Queue();
                string input = Console.ReadLine();
                while (input != null)
                {
                    input = Console.ReadLine();
                    string option = input.Substring(0, 1);
                    switch (option)
                    {
                        case "1":
                            queue.Enqueue(input.Substring(2, input.Length - 2));
                            break;
                        case "2":
                            queue.Dequeue();
                            break;
                        case "3":
                            queue.Print();
                            break;
                    }
                }
            }
            catch (Exception) { }
        }
    }

    public class Queue
    {
        List<string> queue = new List<string>();

        public void Enqueue(string value)
        {
            queue.Add(value);
        }

        public void Dequeue()
        {
            queue.RemoveAt(0);
        }

        public void Print()
        {
            Console.WriteLine("{0}", queue[0]);
        }

    }
}
