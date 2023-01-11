using System;
using System.Collections.Generic;

namespace _05._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();

            List<int> list = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                queue.Enqueue(nums[i]);
            }

            while (queue.Count > 0)
            {
                if (queue.Peek() % 2 == 0)
                {
                    list.Add(queue.Peek());

                    //Console.Write($"{queue.Peek()}, ");
                }

                queue.Dequeue();
            }

            Console.WriteLine(String.Join(", ", list));
        }
    }
}