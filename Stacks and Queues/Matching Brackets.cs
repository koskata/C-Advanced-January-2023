using System;
using System.Collections.Generic;

namespace _04._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> indexes = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                

                if (input[i] == '(')
                {
                    int openBracket = i;
                    indexes.Push(openBracket);
                }
                if (input[i] == ')')
                {
                    int neshto = indexes.Pop();

                    for (int j = neshto; j <= i; j++)
                    {
                        Console.Write($"{input[j]}");
                    }
                    Console.WriteLine();
                }

                
            }
        }
    }
}