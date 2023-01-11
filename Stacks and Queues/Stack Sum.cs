using System;
using System.Collections.Generic;

namespace _02._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(nums);

            string input = Console.ReadLine().ToLower();

            while (input != "end")
            {
                string[] cmdArgs = input.Split();

                string cmdType = cmdArgs[0];

                if (cmdType == "add")
                {
                    int first = int.Parse(cmdArgs[1]);
                    int second = int.Parse(cmdArgs[2]);

                    stack.Push(first);
                    stack.Push(second);
                }
                else if (cmdType == "remove")
                {
                    int n = int.Parse(cmdArgs[1]);

                    if (stack.Count >= n)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            stack.Pop();
                        }
                    }
                    
                }

                input = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}