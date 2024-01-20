namespace ImplementingLinkedList
{
    public class CustomLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Count { get; set; }


        public void AddLast(int value)
        {
            Count++;
            Node node = new(value);

            if (Tail == null)
            {
                Head = node;
                Tail = node;
                return;
            }

            Tail.Next = node;
            node.Previous = Tail;
            Tail = node;
        }

        public void AddFirst(int value)
        {
            Count++;
            Node node = new(value);

            if (Head == null)
            {
                Head = node;
                Tail = node;
                return;
            }

            Head.Previous = node;
            node.Next = Head;
            Head = node;
        }

        public Node RemoveFirst()
        {
            if (Head == null)
            {
                return null;
            }

            Count--;
            Node oldHead = Head;
            if (Head.Next == null)
            {
                Head = null;
                Tail = null;
                return oldHead;
            }

            Node newHead = Head.Next;

            Head.Next = null;
            newHead.Previous = null;
            Head = newHead;

            return oldHead;
        }

        public Node RemoveLast()
        {
            if (Tail == null)
            {
                return null;
            }

            Count--;
            Node oldTail = Tail;
            if (Tail.Previous == null)
            {
                Head = null;
                Tail = null;
                return oldTail;
            }

            Node newTail = Tail.Previous;

            Tail.Previous = null;
            newTail.Next = null;
            Tail = newTail;

            return oldTail;
        }

        public void ForEach(Action<Node> action)
        {
            Node node = Head;

            while (node != null)
            {
                action(node);
                node = node.Next;
            }
        }

        public int[] ToArray()
        {
            int[] arr = new int[Count];
            int i = 0;
            ForEach(n => arr[i] = n.Value);
            i++;

            return arr;
        }
    }
}
