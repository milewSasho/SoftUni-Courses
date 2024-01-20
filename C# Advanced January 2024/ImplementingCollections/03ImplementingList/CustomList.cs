namespace ImplementingList
{
    public class CustomList
    {
        private int[] items;
        private const int InitialCapacity = 2;


        public CustomList()
        {
            items = new int[InitialCapacity];
        }


        public int Count { get; private set; }
        public int this[int index]
        {
            get
            {
                CheckIsIndexValid(index);
                return items[index];
            }
            set
            {
                CheckIsIndexValid(index);
                items[index] = value;
            }
        }


        public void Add(int element)
        {
            if (items.Length == Count)
            {
                Resize();
            }

            items[Count] = element;
            Count++;
        }
        public int RemoveAt(int index)
        {
            CheckIsIndexValid(index);

            int removedElement = items[index];
            ShiftLeft(index);

            Count--;
            if (Count <= items.Length / 4)
            {
                Shrink();
            }

            return removedElement;
        }
        public int InsertAt(int index, int element)
        {
            CheckIsIndexValid(index);

            if (items.Length == Count)
            {
                Resize();
            }

            ShiftRight(index);
            items[index] = element;
            Count++;

            return element;
        }
        public bool Contains(int element)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == element)
                {
                    return true;
                }
            }
            return false;
        }
        public void Swap(int firstIndex, int secondIndex)
        {
            CheckIsIndexValid(firstIndex);
            CheckIsIndexValid(secondIndex);

            (items[firstIndex], items[secondIndex]) = (items[firstIndex], items[secondIndex]);
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
        private void CheckIsIndexValid(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }
        }
        private void ShiftLeft(int index)
        {
            for (int i = 0; i < Count - 1; i++)
            {
                items[i] = items[i + 1];
            }
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
        private void ShiftRight(int index)
        {
            for (int i = Count; i >= index; i--)
            {
                items[i + 1] = items[i];
            }
        }
    }
}
