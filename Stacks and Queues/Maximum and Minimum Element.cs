namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] cmdArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int command = cmdArgs[0];

                if (command == 1)
                {
                    int num = cmdArgs[1];

                    stack.Push(num);
                }
                else if (command == 2)
                {
                    stack.Pop();
                }
                else if (command == 3)
                {
                    if (stack.Any())
                    {
                        Console.WriteLine(stack.Max());
                    }

                }
                else if (command == 4)
                {
                    if (stack.Any())
                    {
                        Console.WriteLine(stack.Min());
                    }

                }
            }

            if (stack.Any())
            {
                Console.WriteLine(string.Join(", ", stack));
            }
        }
    }
}