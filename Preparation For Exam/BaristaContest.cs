using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace _01.BaristaContest2
{
    public class BaristaContest
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> quantities = new Dictionary<string, int>()
            {
                { "Cortado", 50},
                { "Espresso", 75},
                { "Capuccino", 100},
                { "Americano", 150},
                { "Latte", 200},
            };

            Dictionary<string, int> counts = new Dictionary<string, int>()
            {
                { "Cortado", 0},
                { "Espresso", 0},
                { "Capuccino", 0},
                { "Americano", 0},
                { "Latte", 0},
            };

            int[] input1 = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] input2 = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> coffee = new Queue<int>(input1);
            Stack<int> milk = new Stack<int>(input2);

            while (coffee.Any() && milk.Any())
            {
                int currCoffee = coffee.Dequeue();
                int currMilk = milk.Pop();

                bool isFound = false;

                foreach (var item in quantities)
                {
                    if (currCoffee + currMilk == item.Value)
                    {
                        counts[item.Key]++;
                        isFound = true;
                        break;
                    }

                    
                }

                if (!isFound)
                {
                    currMilk -= 5;
                    milk.Push(currMilk);
                }
            }

            if (!coffee.Any() && !milk.Any())
            {
                Console.WriteLine($"Nina is going to win! She used all the coffee and milk!");
                Console.WriteLine("Coffee left: none");
                Console.WriteLine("Milk left: none");
            }
            else
            {
                Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
                if (coffee.Any())
                {
                    Console.WriteLine($"Coffee left: {string.Join(", ", coffee)}");

                }
                else
                {
                    Console.WriteLine("Coffee left: none");
                }
                if (milk.Any())
                {
                    Console.WriteLine($"Milk left: {string.Join(", ", milk)}");
                }
                else
                {
                    Console.WriteLine("Milk left: none");
                }
            }

            foreach (var item in counts.OrderBy(x => x.Value).ThenByDescending(x => x.Key))
            {
                if (item.Value > 0)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
        }
    }
}