using System;
using System.Collections.Generic;

namespace _03._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            int sum = 0;

            for (int i = 0; i < input.Count; i += 2)
            {
                if (input[i + 2] == " ")
                {
                    break;
                }
                else
                {
                    if (input[i + 1] == "+")
                    {
                        sum += int.Parse(input[i] + input[i + 2]);
                    }
                    else if (input[i + 1] == "-")
                    {
                        sum -= int.Parse(input[i]) - int.Parse(input[i + 2]);
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}