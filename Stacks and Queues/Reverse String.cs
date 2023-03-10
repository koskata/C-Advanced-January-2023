using System;
using System.Collections.Generic;

namespace _01._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> reversed = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                reversed.Push(ch);
            }

            while (reversed.Count > 0)
            {
                Console.Write(reversed.Pop());
            }
        }
    }
}