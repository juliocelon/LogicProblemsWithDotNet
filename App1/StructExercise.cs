using System;
namespace LogicProblems
{
   /*
     Decide the best way to implement the structure and operations for memory and time optimization as well as secure coding
     The functions associated with stack are: 
     empty() – Returns whether the stack is empty 
     size() – Returns the size of the stack 
     top() – Returns a reference to the top most element of the stack 
     push(g) – Adds the element ‘g’ at the top of the stack 
     pop() – Deletes the top most element of the stack
    */
    public class StructExercise
    {
        static int MAX_SIZE = 100;
        static int[] stack = new int[100];
        static int currentIndex = -1;

        public static bool empty()
        {
            if(currentIndex < 0)
                return true;
            return false;
        }

        public static int size()
        {
            return currentIndex + 1;
        }

        public static int top()
        {
            return stack[currentIndex];
        }

        public static int push(int value)
        {
            if (currentIndex == MAX_SIZE - 1)
                return -1;

            currentIndex++;
            stack[currentIndex] = value;
            return 0;
        }

        public static int pop()
        {
            if (currentIndex < 0)
                return -1;

            currentIndex--;
            return stack[currentIndex+1];
        }

        public static void Execute()
        {
            Console.WriteLine($"Is empty? = [{empty()}]");
            push(1);
            push(2);
            push(3);
            push(4);
            Console.WriteLine($"size = [{size()}]");
            Console.WriteLine($"top = [{top()}]");
            Console.WriteLine($"pop = [{pop()}]");
            Console.WriteLine($"size = [{size()}]");
            Console.WriteLine($"top = [{top()}]");
            Console.WriteLine($"pop = [{pop()}]");
            Console.WriteLine($"pop = [{pop()}]");
            Console.WriteLine($"pop = [{pop()}]");
            Console.WriteLine($"pop = [{pop()}]");
            Console.WriteLine($"Is empty? = [{empty()}]");
        }
    }
}
