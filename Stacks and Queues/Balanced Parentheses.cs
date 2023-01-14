using System;

namespace _08._Balanced_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> brackets = new Stack<char>();

            foreach (var bracket in input)
            {
                if (bracket == '{' || bracket == '(' || bracket == '[')
                {
                    brackets.Push(bracket);
                }

                if (bracket == '}')
                {
                    if (brackets.Count == 0 || brackets.Pop() != '{')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }

                if (bracket == ')')
                {
                    if (brackets.Count == 0 || brackets.Pop() != '(')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }

                if (bracket == ']')
                {
                    if (brackets.Count == 0 || brackets.Pop() != '[')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                
            }

            if (brackets.Count > 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }

            
        }
    }
}
