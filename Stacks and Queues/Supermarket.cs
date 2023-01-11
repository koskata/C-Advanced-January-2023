using System;
using System.Collections.Generic;

namespace _06._Supermarket
{
    internal class Supermarket
    {
        static void Main(string[] args)
        {
            Queue<string> customers = new Queue<string>();

            int count = 0;

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Paid")
                {
                    while (customers.Count > 0)
                    {
                        Console.WriteLine(customers.Dequeue());
                        count--;
                    }
                        
                }
                else
                {
                    customers.Enqueue(input);
                    count++;
                }
                
            }

            Console.WriteLine($"{count} people remaining.");
        }
    }
}