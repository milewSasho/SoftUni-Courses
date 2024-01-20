namespace ImplementingQueue
{
    public class CustomQueue
    {
        private const int InitialCapacity = 4;
        private const int FirstElementIndex = 0;
        private int[] items;

        public CustomQueue()
        {
            items = new int[InitialCapacity];
        }


        public int Count { get; private set; }


        public void Enqueue(int item)
        {
            if (items.Length == Count)
            {
                Resize();
            }
            items[Count] = item;
            Count++;
        }
        public int Dequeue()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            int removedElement = items[FirstElementIndex];
            ShiftLeft(FirstElementIndex);
            Count--;

            return removedElement;
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
        public void Clear()
        {
            items = new int[InitialCapacity];
            Count = 0;
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
        private void ShiftLeft(int index)
        {
            for (int i = 0; i < Count - 1; i++)
            {
                items[i] = items[i + 1];
            }
        }
    }
}
