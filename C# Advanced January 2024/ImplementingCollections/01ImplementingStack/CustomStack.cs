namespace ImplementingStack
{
    public class CustomStack
    {
        private int[] items;
        private const int InitialCapacity = 4;


        public CustomStack()
        {
            items = new int[InitialCapacity];
        }


        public int Count { get; private set; }


        public void Push(int element)
        {
            if (items.Length == Count)
            {
                Resize();
            }

            items[Count] = element;
            Count++;
        }
        public int Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            int removedItem = items[Count - 1];
            Count--;

            if (Count <= items.Length / 4)
            {
                Shrink();
            }

            return removedItem;
        }
        public int Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            return items[Count - 1];
        }
        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < Count; i++)
            {
                action(items[i]);
            }
        }

        private void Resize()
        {
            int[] newArr = new int[items.Length * 2];
            for (int i = 0; i < Count; i++)
            {
                newArr[i] = items[i];
            }

            items = newArr;
        }
        private void Shrink()
        {
            int[] newArr = new int[items.Length / 2];

            for (int i = 0; i < Count; i++)
            {
                newArr[i] = items[i];
            }

            items = newArr;
        }
    }
}
