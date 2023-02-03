using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList
    {
        private const int InitialCapacity = 2;
        private int[] items;

        public CustomList()
        {
            this.items = new int[InitialCapacity];
        }



        public int Count { get; private set; }

        public int this[int index] 
        { 
            get 
            {
                if (index >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return items[index]; 
            } 
            set 
            {
                if (index >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                items[index] = value;
            }
        }

        public void Add(int item) 
        {
            if (Count == items.Length)
            {
                Resize();
            }

            items[Count] = item;
            Count++;
        }

        public int RemoveAt(int index) 
        {
            ValidateIndex(index);


            var item = items[index];
            items[index] = default;
            ShiftLeft(index);
            Count--;

            if (Count <= items.Length / 4)
            {
                Shrink();
            }

            return item;
        }

        public bool Contains(int item) 
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i] == item)
                {
                    return true;
                }
            }

            return false;
        }

        public void Swap(int firstIndex, int secondIndex) 
        {
            ValidateIndex(firstIndex);
            ValidateIndex(secondIndex);

            int temp = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = temp;
        }

        public void Insert(int index, int item) 
        {
            ValidateIndex(index);

            if (Count == items.Length)
            {
                Resize();
            }

            ShiftRight(index);
            items[index] = item;

        }

        private void ShiftLeft(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                items[i] = items[i + 1];
            }
        }

        private void ShiftRight(int index) 
        {
            for (int i = Count; i > index; i--)
            {
                items[i] = items[i - 1];
            }
        }

        private int[] Resize() 
        {
            int[] copy = new int[items.Length * 2];
            for (int i = 0; i < Count; i++)
            {
                copy[i] = items[i];
            }

            items = copy;

            return items;
        }
        private int[] Shrink() 
        {
            int[] copy = new int[items.Length / 2];
            for (int i = 0; i < Count; i++)
            {
                copy[i] = items[i];
            }

            items = copy;
            return items;
        }
        private bool ValidateIndex(int index) 
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            return true;
        }

    }

    
}
