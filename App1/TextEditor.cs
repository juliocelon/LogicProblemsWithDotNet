using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class TextEditor
{
    static StringBuilder myMessage = new StringBuilder();
    static List<StringBuilder> myPreviousMessage = new List<StringBuilder>();
    //static StringBuilder myPreviousMessage = new StringBuilder();

    public static void Start()
    {
        Append(new StringBuilder("z"));
        Append(new StringBuilder("rmkrpry"));

        StringBuilder nm = new StringBuilder("holaa");
        
    }



    static void Main2(String[] args)
    {
        int commandsCount = int.Parse(Console.ReadLine());
        myPreviousMessage.Add(new StringBuilder());
        while (commandsCount > 0)
        {
            StringBuilder item = new StringBuilder(Console.ReadLine());
            StringBuilder command = new StringBuilder();
            StringBuilder parameter = new StringBuilder();

            if (item.Length > 1)
            {
                command.Append(item[0]);
                parameter.Append(item.ToString(2, item.Length - 2));
            }
            else
                command.Append(item[0]);

            if (command.Equals(new StringBuilder("1")))
                Append(parameter);

            if (command.Equals(new StringBuilder("2")))
                Delete(int.Parse(parameter.ToString()));

            if (command.Equals(new StringBuilder("3")))
                Print(int.Parse(parameter.ToString()));

            if (command.Equals(new StringBuilder("4")))
                Undo();

            commandsCount--;
        }
    }

    public static void Append(StringBuilder input)
    {
        if (myPreviousMessage.Count > 0)
            myPreviousMessage.Add(input);
        myMessage.Append(input);
    }

    public static void Delete(int k)
    {
        if (k <= myMessage.Length)
        {
            StringBuilder keepMessage = new StringBuilder().Append(myMessage);
            myMessage.Remove(myMessage.Length - k, k);
            myPreviousMessage.Add(keepMessage);
        }
    }

    public static void Print(int k)
    {
        if (k <= myMessage.Length)
        {
            if (k - 1 >= 0)
                Console.WriteLine(myMessage[k - 1]);
        }
    }

    public static void Undo()
    {
        if (myPreviousMessage.Count > 0)
        {
            myMessage.Clear();
            myMessage.Append(myPreviousMessage[myPreviousMessage.Count - 1]);

            if (myPreviousMessage.Count > 1)
                myPreviousMessage.RemoveAt(myPreviousMessage.Count - 1);
        }
    }
}
