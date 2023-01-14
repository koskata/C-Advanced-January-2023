﻿namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            //int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();


            Queue<int> orders = new Queue<int>(
                Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            Console.WriteLine(orders.Max());

            while (orders.Any())
            {
                quantity -= orders.Peek();

                if (quantity < 0)
                {
                    break;
                }

                orders.Dequeue();
            }


            if (orders.Any())
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}