using System;
namespace LogicProblems
{
    public class OopExercise1
    {
        public static void Start()
        {
            Balance b = new Balance();
            b.Add(4).Add(20).Dec(5).Add(12);
            Console.WriteLine(b.balance);

            Balance b1 = new Balance();
            b1.balance = 5;

            Balance b2 = new Balance();
            b2.balance = 5;

            Console.WriteLine(b1.Equals(b2));
            Console.WriteLine(b1.Equals("dsdsd"));
            Console.WriteLine(b1.Equals(null));
        }
    }

    public class Balance
    {
        public int balance = 0;

        public Balance Add(int val)
        {
            this.balance += val;
            Console.WriteLine(this.balance);
            return this;
        }

        public Balance Dec(int val)
        {
            this.balance -= val;
            Console.WriteLine(this.balance);
            return this;
        }

        public override bool Equals(object obj)
        {
            if (obj is Balance)
            {
                if (this.balance == ((Balance)obj).balance)
                    return true;
            }
            return false;
        }
    }
}
