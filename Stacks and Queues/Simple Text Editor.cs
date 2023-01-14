using System;
using System.Text;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<string> stack = new Stack<string>();

            string text = "";
;
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();

                string command = cmdArgs[0];

                if (command == "1")
                {
                    stack.Push(text);

                    string textToAppend = cmdArgs[1];

                    text += textToAppend;
                    
                    
                }
                else if (command == "2")
                {
                    stack.Push(text);

                    int removeElements = int.Parse(cmdArgs[1]);

                    text = text.Remove(text.Length - removeElements);

                    
                }
                else if (command == "3")
                {
                    int num = int.Parse(cmdArgs[1]);
                    int index = num - 1;

                    Console.WriteLine(text[index]);
                }
                else if (command == "4")
                {
                    text = stack.Pop();
                    
                }
            }
        }
    }
}