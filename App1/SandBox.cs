using System;
using System.Collections;
using System.Collections.Generic;

namespace LogicProblems
{
    public class SandBox
    {
        public SandBox()
        {
        }

        public static void Start()
        {
            string message = "My message";

            for (int i = message.Length; i > 0; i--)
            {
                Console.WriteLine(message[i - 1]);
            }

            //using System.Collections.Generic;
            List<int> list = new List<int>();
            for (int i = 1; i < 11; i++)
            {
                list.Add(i);
            }

            int[] ar = { 1, 2, 3 };
            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine(ar[i]);
            }

            Hashtable ht = new Hashtable();
            ht[1] = "Uno";
            ht[2] = "Dos";


            string name = "jafet";
            string myMessage = $"my name is {name}"; // interpolation
            Console.WriteLine(myMessage);

            // Tuples
            (double, int) t1 = (4.5, 3);
            Console.WriteLine($"Tuple with elements {t1.Item1} and {t1.Item2}.");
            // Output: Tuple with elements 4.5 and 3.

            (double Sum, int Count) t2 = (4.5, 3);
            Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");
            // Output: Sum of 3 elements is 4.5.

            // Lambdaexpresion
            Func<int, int, int> multiplyByFive = (num, num2) => num * num2;
            int result = multiplyByFive(7, 5);
            Console.WriteLine(result);

            Animal animal = new Animal();
            animal.name = "Rocky";

            animal.Run();
            animal.Live();
            animal.Sleep();
            animal.WakeUp();

            Human h = new Human();
            h.name = "Jafet";
            h.Live();
            h.Listening();
        }
    }


    public interface IThink
    {
        public static string thought; // An interface can contain static fields and methods, but
        //public string name; // An interface cannot contain instance fields

        public void Thinking();

        // an interface can contain methods implemented. (of instance and static)
        public void WakeUpListening() { Console.WriteLine("WakeUp from IThink!"); }
        public static void ThinkFast() { Console.WriteLine("Think fast!"); }
    }

    public interface IListen
    {
        public void Listening();

    }

    public abstract class Being
    {
        public string name; // Abstract class can have instance fields
        private string surname;
        protected string nickname;

        public static string staticVal;

        public abstract void Die(); // abstract method
        public void Live() { Console.WriteLine("Live today!"); } // an abstract class can implement methods
        public virtual void WakeUp() { Console.WriteLine("WakeUp!"); } // an abstract class can implement methods

    }

    public class Alive : Being
    {
        public void Run()
        {
            Console.WriteLine("Run!");
        }

        protected void Eat()
        {
            Console.WriteLine("Eat!");
        }

        // This method hides the Live method of the base class
        // I´m not overriding the Live method form the base class
        public void Live()
        {
            Console.WriteLine("I´m living");
            name = "Alive";
            // surname = "being" // surname is private.
            nickname = "nickname";

        }

        public override void WakeUp() // Overriding a virtual method
        {
            base.WakeUp(); // calling the base method
            Console.WriteLine("WakeUp from Alive");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("Sleeping");
        }

        public override void Die() // As Die is an abstract method from abstrac class, it should be implemented in the subclass that inheritance from base class
        {
            Console.WriteLine("I die!");
        }
    }

    public class Animal : Alive
    {
        public void Run()
        {
            Console.WriteLine("Run like animal!");
        }

        public void Live()
        {
            Eat();
        }

        public override void Sleep()
        {
            Console.WriteLine("Animal Sleeping");
        }

        public override void WakeUp() // Overriding a virtual method
        {
            base.WakeUp(); // calling the base method
            Console.WriteLine("WakeUp from Animal");
        }

    }

    public class Human : Alive, IThink, IListen
    {
        public void Run()
        {
            Console.WriteLine("Run like animal!");
        }

        public void Live()
        {
            Thinking();
            WakeUpListening();
        }

        public void Thinking()
        {
            Console.WriteLine("I think");
            IThink.ThinkFast();
        }

        public void Listening()
        {
            Console.WriteLine("I listen");
        }

        public void WakeUpListening()
        {
            Console.WriteLine("WakeUp from Listening!");
        }
    }
}
