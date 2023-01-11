using System;
using System.Collections.Generic;

namespace _07._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            int counter = 1;

            Queue<string> kids = new Queue<string>(names);

            while (kids.Count > 1)
            {
                if (counter == n)
                {
                    
                    Console.WriteLine($"Removed {kids.Peek()}");

                    kids.Dequeue();
                    counter = 1;
                }
                else
                {
                    counter++;
                    string currKid = kids.Peek();
                    kids.Dequeue();
                    kids.Enqueue(currKid);
                }
            }

            Console.WriteLine($"Last is {kids.Peek()}");


        }
    }
}