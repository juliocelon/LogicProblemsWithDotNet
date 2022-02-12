using System;
namespace Recursions
{
    public class RecursionExercises
    {
        public static void printMessage50times(string message, int times)
        {
            Console.WriteLine("{0}. {1}", times, message);
            if (times < 50)
                printMessage50times(message, times + 1);
        }
    }
}
