using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public class CustomStack
    {
        private const int InitialCapacity = 4;

        private int[] items;

        public CustomStack()
        {
            items = new int[InitialCapacity];
        }

        public int Count { get; private set; }

        public void Push(int item) 
        {
            if (Count == items.Length)
            {
                Resize();
            }

            items[Count] = item;
            Count++;
        }

        public int Pop() 
        {
            ValidateLength();


            int num = items[Count - 1];
            Count--;
            return num;
        }

        public int Peek() 
        {
            ValidateLength();

            int num = items[Count - 1];
            
            return num;
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
    }
}
