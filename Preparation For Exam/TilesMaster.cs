using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.TilesMaster2
{
    public class TilesMaster
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> locationWithArea = new Dictionary<string, int>()
            {
                { "Sink", 40},
                { "Oven", 50},
                { "Countertop", 60},
                { "Wall", 70},
            };

            Dictionary<string, int> locationWithCounter = new Dictionary<string, int>()
            {
                { "Sink", 0},
                { "Oven", 0},
                { "Countertop", 0},
                { "Wall", 0},
                { "Floor", 0}
            };

            Stack<int> white = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> grey = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));


            while (white.Any() && grey.Any())
            {
                int currWhite = white.Pop();
                int currGrey = grey.Dequeue();

                if (currWhite != currGrey)
                {
                    currWhite /= 2;
                    white.Push(currWhite);
                    grey.Enqueue(currGrey);
                    continue;
                }

                bool isFound = false;

                foreach (var item in locationWithArea)
                {
                    if (currWhite + currGrey == item.Value)
                    {
                        locationWithCounter[item.Key]++;
                        isFound = true;
                        break;

                    }


                }

                if (!isFound)
                {
                    locationWithCounter["Floor"]++;

                }



            }

            if (white.Any())
            {
                Console.WriteLine($"White tiles left: {string.Join(", ", white)}");
            }
            else
            {
                Console.WriteLine($"White tiles left: none");
            }

            if (grey.Any())
            {
                Console.WriteLine($"Grey tiles left: {string.Join(", ", grey)}");
            }
            else
            {
                Console.WriteLine($"Grey tiles left: none");
            }


            //locationWithCounter = (Dictionary<string, int>)locationWithCounter.OrderByDescending(x => x.Value).ThenBy(x => x.Key);//.ToDictionary();
            foreach (var item in locationWithCounter.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                if (item.Value != 0)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");

                }
            }
        }
    }
}
