using System;
namespace Recursions
{
    public class RecursionCase
    {
        public static void PrintMessage50times(string message, int times)
        {
            Console.WriteLine("{0}. {1}", times, message);
            if (times < 50)
                PrintMessage50times(message, times + 1);
        }
    }
}
