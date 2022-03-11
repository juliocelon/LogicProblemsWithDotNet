namespace LogicProblems
{
    public class SinglyLinkedListNode
    {
        public int data { get; set; }
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int data)
        {
            this.data = data;
        }
    }

    public class SinglyLinkedList2
    {
        int count;
        public SinglyLinkedListNode head;

        public SinglyLinkedList2()
        {
            head = null;
            count = 0;
        }

        public void AddNode(int value)
        {
            SinglyLinkedListNode node = new SinglyLinkedListNode(value);
            node.next = head;
            head = node;
            count++;
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

    }


}