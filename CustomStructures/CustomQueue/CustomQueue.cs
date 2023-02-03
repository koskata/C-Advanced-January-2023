using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomQueue
{
    public class CustomQueue
    {
        private const int InitialCapacity = 4;
        private const int FirstElement = 0;

        private int[] items;

        public CustomQueue()
        {
            items = new int[InitialCapacity];
        }

        public int Count { get; private set; }


        public void Enqueue(int item) 
        {
            if (Count == items.Length)
            {
                Resize();
            }

            items[Count] = item;
            Count++;
        }

        public int Dequeue() 
        {
            ValidateLength();

            int num = items[FirstElement];
            Count--;

            Shift();

            return num;
        }

        public int Peek()
        {
            ValidateLength();

            int num = items[FirstElement];

            return num;
        }

        public int Clear() 
        {
            ValidateLength();

            int temp = Count;

            for (int i = 0; i < temp; i++)
            {
                items[i] = default;
                Count--;
            }

            return Count;
        }

        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < Count; i++)
            {
                action(items[i]);
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

        private bool ValidateLength()
        {
            if (items.Length == 0)
            {
                throw new InvalidOperationException();
            }
            return true;
        }

        private void Shift() 
        {
            items[FirstElement] = default;
            for (int i = 0; i < Count; i++)
            {
                items[i] = items[i + 1];
            }
        }
    }
}
